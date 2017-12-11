using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.core.view.Summary;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseGradeEstimator.routes.AssignmentSummary
{
    class AssignmentSummaryController : core.view.ViewController<AssignmentSummaryView>
    {
        public AssignmentSummaryController(Router r, DataDTO<Assignment, Module, AssignmentGrade> d) : base(r)
        {
            item = d.Data;
            parent = d.Parent;
            grade = d.Grade;

            view = new AssignmentSummaryView();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(SummaryViewBindings.Back, new core.view.VoidDelegate(navToBack));
            //eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));

            view.BindDelegates();
        }


        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;
            view.Weighting = item.CreditWeight.ToString();
            //view
        }

        private void saveData()
        {
            Console.WriteLine("saveData!!");
        }

        private Assignment item;
        private Module parent;
        private AssignmentGrade grade;
    }
}
