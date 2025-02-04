﻿using CourseGradeEstimator.core.data;
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

            fillOutAssignmentGrades();

            populateView();

            Hashtable eventMap = view.EventBindings;

            //eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateAssignment));
            eventMap.Add(SummaryViewBindings.Back, new core.view.VoidDelegate(navToBack));
            //eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));
            view.ChildItemEventBindings.Add(SummaryViewBindings.View, new core.view.VoidDelegateWithArgs<string>(navToAssignmentSummary));
            //view.ChildItemEventBindings.Add(SummaryViewBindings.Grade, new core.view.VoidDelegateWithArgs<string[]>(updateGrade));
            eventMap.Add(SummaryViewBindings.Grade, new core.view.VoidDelegateWithArgs<string[]>(updateGrade));


            view.BindDelegates();
        }

        private void populateView()
        {
            List<Assignment> assignments = item.Assignments;

            view.ItemTitle = item.Title;
            view.ItemYear = item.Year.ToString(); 
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            if (assignments != null && assignments.Count > 0)
            {
                string[][] data;

                data = assignments.Select(assignment => {
                    AssignmentGrade ag = grade.Assignments.Find(agItem => agItem.Code == assignment.Code);

                    return new string[] { assignment.Title, assignment.Description, assignment.Code, ag.Score.ToString() };
                }).ToArray();

                view.SetChildItems(data);
            }
        }

        private void navToAssignmentSummary(string code)
        {
            Console.WriteLine($"navToAssignmentSummary: {code}");

            Assignment assignment = findAssignmentByCode(code);

            DataDTO<Assignment, Module, AssignmentGrade> data = new DataDTO<Assignment, Module, AssignmentGrade> { Data = assignment, Parent = item };

            router.navTo(Routings.AssignmentSummary, data);
        }

        //private void updateGrade(string code, string value)
        private void updateGrade(string[] data)
        {
            //Console.WriteLine($"updateGrade: {code} - val: {value}");
            Console.WriteLine($"updateGrade: {data[0]} - val: {data[1]}");
            int val = 0;
            Int32.TryParse(data[1], out val);
            string code = data[0];

            AssignmentGrade ag = findAssignmentGradeByCode(code);

            if (ag != null && ag.Score != val)
            {
                ag.Score = val;

                dataLayer.SaveGradeData();
            }

            /*DataDTO<Assignment, Module, AssignmentGrade> data = new DataDTO<Assignment, Module, AssignmentGrade> { Data = assignment, Parent = item };

            router.navTo(Routings.AssignmentSummary, data);*/
        }

        private void fillOutAssignmentGrades()
        {
            List<Assignment> assignments = item.Assignments;

            if (assignments != null)
            {
                if (grade.Assignments == null)
                {
                    grade.Assignments = new List<AssignmentGrade>();
                }

                List<AssignmentGrade> assignmentGrades = grade.Assignments;

                assignments.ForEach((assignment) => {
                    string code = assignment.Code;

                    if (code != null)
                    {
                        bool foundAG = assignmentGrades.Exists(ag => ag.Code == code);

                        if (!foundAG)
                        {
                            assignmentGrades.Add(new AssignmentGrade() { Code = code });
                        }

                    }
                });
            }
        }

        private Assignment findAssignmentByCode(string code)
        {
            Predicate<Assignment> assignmentFinder = (Assignment assignment) => { return assignment.Code == code; };

            return item.Assignments.Find(assignmentFinder);
        }

        private AssignmentGrade findAssignmentGradeByCode(string code)
        {
            Predicate<AssignmentGrade> assignmentFinder = (AssignmentGrade grade) => { return grade.Code == code; };

            return grade.Assignments.Find(assignmentFinder);
        }

        private void createAssignmentGradeIfMissing(string code, ref AssignmentGrade grade)
        {
            if (grade == null)
            {
                grade = new AssignmentGrade() { Code = code };
                //grade.Assignments.Add(grade);
            }
        }

        private Module item;
        private Course parent;
        private ModuleGrade grade;
    }
}
