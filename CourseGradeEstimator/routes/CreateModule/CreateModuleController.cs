using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CreateModule
{
    class CreateModuleController : core.view.ComplexViewController<CreateModule>
    {
        public CreateModuleController(Router r, DataDTO<Module, Course, ModuleGrade> d) : base(r) {
            item = d.Data;
            parent = d.Parent;
            grade = d.Grade;

            view = new CreateModule();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateAssignment));
            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));
            eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));
            view.ChildItemEventBindings.Add(CreateViewBindings.Edit, new core.view.VoidDelegateWithArgs<string>(navToCreateAssignment));
            view.ChildItemEventBindings.Add(CreateViewBindings.Delete, new core.view.VoidDelegateWithArgs<string>(removeAssignment));

            view.BindDelegates();
        }

        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemYear = item.Year.ToString();
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            buildChildSection();
        }

        private void buildChildSection()
        {
            string[][] data = getChildItemViewData(item.Assignments, mod => {
                return new string[] { mod.Title, mod.Description, mod.Code };
            });

            view.SetChildItems(data);
        }
        private void populateModel()
        {
            int yearVal;
            Int32.TryParse(view.ItemYear, out yearVal);

            item.Title = view.ItemTitle; view.ItemYear = item.Year.ToString();
            item.Year = yearVal;
            item.Code = view.ItemCode;
            item.Description = view.ItemDescription;
        }

        private void saveData()
        {
            Console.WriteLine("saveData!!");
            populateModel();

            if (parent.Modules == null)
            {
                parent.Modules = new List<Module>();
            }

            if (!parent.Modules.Contains(item))
            {
                parent.Modules.Add(item);
            }

            dataLayer.SaveCourseData(parent);
            //router.navBack(parent);
            router.navBack();
        }

        private void navToCreateAssignment()
        {
            Console.WriteLine("navToCreateAssignment!! new!");

            navToCreateAssignment(new Assignment());
        }

        private void navToCreateAssignment(string code)
        {
            Console.WriteLine($"navToCreateModule {code}");

            navToCreateAssignment(findAssigmentByCode(code));
        }
        private void navToCreateAssignment(Assignment assignment)
        {
            Console.WriteLine("navToCreateAssignment!!");

            DataDTO<Assignment, Module, AssignmentGrade> dto = new DataDTO<Assignment, Module, AssignmentGrade> { Data = assignment, Parent = item };
            
            router.navTo(Routings.AssignmentCreate, dto);
        }
        
        private Assignment findAssigmentByCode(string code)
        {
            Predicate<Assignment> assignmentFinder = (Assignment assignment) => { return assignment.Code == code; };

            return item.Assignments.Find(assignmentFinder);
        }

        private void removeAssignment(string code)
        {
            Console.WriteLine($"removeModule {code}");
            Assignment foundAssignment = findItemByCode(item.Assignments, code);

            if (foundAssignment != null)
            {
                bool actuallyDel = confirmDelete();

                if (actuallyDel)
                {
                    //TODO: Deleting an assignment deletes the corresponding grade item

                    item.Assignments.Remove(foundAssignment);
                    buildChildSection();
                    dataLayer.SaveCourseData();
                }
            }
        }

        private Module item;
        private Course parent;
        private ModuleGrade grade;
    }
}
