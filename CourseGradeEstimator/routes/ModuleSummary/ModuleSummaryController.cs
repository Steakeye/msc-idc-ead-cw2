using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.core.view.Summary;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.ModuleSummary
{
    class ModuleSummaryController : core.view.ViewController<ModuleSummaryView>
    {
        public ModuleSummaryController(Router r, DataDTO<Module, Course, ModuleGrade> d) : base(r) {
            item = d.Data;
            parent = d.Parent;
            grade = d.Grade;

            view = new ModuleSummaryView();

            populateView();

            Hashtable eventMap = view.EventBindings;

            //eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateAssignment));
            eventMap.Add(SummaryViewBindings.Back, new core.view.VoidDelegate(navToBack));
            //eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));
            view.ChildItemEventBindings.Add(SummaryViewBindings.View, new core.view.VoidDelegateWithArgs<string>(navToAssignmentSummary));


            view.BindDelegates();
        }

        private void populateView()
        {
            List<Assignment> assignments = item.Assignments;

            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            if (assignments != null && assignments.Count > 0)
            {
                string[][] data;

                data = assignments.Select(assignment => {
                    return new string[] { assignment.Title, assignment.Description, assignment.Code };
                }).ToArray();

                view.SetChildItems(data);
            }
        }

        private void navToAssignmentSummary(string code)
        {
            Console.WriteLine($"navToAssignmentSummary: {code}");

            Assignment module = findAssignmentByCode(code);

            //router.navTo(Routings.CourseCreate, item);
        }

        private Assignment findAssignmentByCode(string code)
        {
            Predicate<Assignment> assignmentFinder = (Assignment assignment) => { return assignment.Code == code; };

            return item.Assignments.Find(assignmentFinder);
        }

        private Module item;
        private Course parent;
        private ModuleGrade grade;
    }
}
