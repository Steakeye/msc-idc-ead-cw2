using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.control;
using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.core.view.interfaces;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CreateCourse
{
    class CreateCourseController : core.view.ComplexViewController<CreateCourse>
    {
        /*public CreateCourseController(Router r) : this(r, new Course()) {
        }*/
        public CreateCourseController(Router r, DataDTO<Course, Course, CourseGrade> course) : base(r) {
            item = course.Data == null ? dataLayer.CreateCourseData() : course.Data;
            gradeItem = course.Grade == null ? dataLayer.CreateGradeData() : course.Grade;

            view = new CreateCourse();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateModule));
            eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));
            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));
            view.ChildItemEventBindings.Add(CreateViewBindings.Edit, new core.view.VoidDelegateWithArgs<string>(navToCreateModule));
            view.ChildItemEventBindings.Add(CreateViewBindings.Delete, new core.view.VoidDelegateWithArgs<string>(removeModule));

            view.BindDelegates();
        }

        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            buildChildSection();
        }

        private void buildChildSection() {
            string[][] data = getChildItemViewData(item.Modules, mod => {
                return new string[] { mod.Title, mod.Description, mod.Code };
            });

            view.SetChildItems(data);
        }
        private void populateModel()
        {
            item.Title = view.ItemTitle;
            item.Code = view.ItemCode;
            item.Description = view.ItemDescription;
        }

        private void saveData()
        {
            Console.WriteLine("saveData!!");
            populateModel();
            dataLayer.SaveCourseData(item);
            router.restart(item);
        }

        private void navToCreateModule(string code)
        {
            Console.WriteLine($"navToCreateModule {code}");

            navToCreateModule(findModuleByCode(code));
        }
        private void navToCreateModule()
        {
            Console.WriteLine("navToCreateModule!! new!");

            navToCreateModule(new Module());
        }
        private void navToCreateModule(Module module)
        {
            Console.WriteLine("navToCreateModule!!");

            DataDTO<Module, Course, ModuleGrade> dto = new DataDTO<Module, Course, ModuleGrade> { Data = module, Parent = item };

            router.navTo(Routings.ModuleCreate, dto);
        }

        private Module findModuleByCode(string code)
        {
            Predicate<Module> moduleFinder = (Module module) => { return module.Code == code; };

            return item.Modules.Find(moduleFinder);
        }

        private void removeModule(string code)
        {
            Console.WriteLine($"removeModule {code}");
            Module foundModule = findItemByCode(item.Modules, code);
            
            if (foundModule != null)
            {
                bool actuallyDel = confirmDelete();

                if (actuallyDel)
                {
                    //TODO: Deleting an module deletes the corresponding grade item

                    item.Modules.Remove(foundModule);
                    buildChildSection();
                    dataLayer.SaveCourseData(item);
                }
            }
        }

        private Course item;
        private CourseGrade gradeItem;
    }
}
