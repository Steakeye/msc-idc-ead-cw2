using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseGradeEstimator.routes.CreateAssignment
{
    class CreateAssignmentController : core.view.ViewController<CreateAssignment>
    {
        public CreateAssignmentController(Router r, DataDTO<Assignment, Module, AssignmentGrade> d) : base(r)
        {
            item = d.Data;
            parent = d.Parent;
            grade = d.Grade;

            view = new CreateAssignment();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));
            eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(navToBack));

            view.BindDelegates();
        }


        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;
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

            if (parent.Assignments == null)
            {
                parent.Assignments  = new List<Assignment>();
            }

            if (!parent.Assignments.Contains(item))
            {
                parent.Assignments.Add(item);
            }

            dataLayer.SaveCourseData(root);
            router.navBack();
        }

        private Assignment item;
        private Module parent;
        private Course root;
        private AssignmentGrade grade;
    }
}
