using CourseGradeEstimator.core.view.Summary;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CourseGradeEstimator.routes.CourseSummary
{
    class CourseSummaryController : core.view.ViewController<CourseSummaryView>
    {
        public CourseSummaryController(Router r, Course course): base(r) {
            item = course;

            view = new CourseSummaryView();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(SummaryViewBindings.Edit, new core.view.VoidDelegate(navToCreateCourse));
            eventMap.Add(SummaryViewBindings.Delete, new core.view.VoidDelegate(deleteDataAndRestart));
            view.ChildItemEventBindings.Add(SummaryViewBindings.View, new core.view.VoidDelegateWithArgs<string>(navToModuleSummary));

            view.BindDelegates();
        }

        private void populateView()
        {
            List<Module> modules = item.Modules;

            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            if (modules != null && modules.Count > 0)
            {
                string[][] data; 

                data = modules.Select(module => {
                    return new string[] { module.Title, module.Description, module.Code };
                }).ToArray();

                view.SetChildItems(data);
            }
        }

        private void deleteDataAndRestart()
        {
            Console.WriteLine("deleteDataAndRestart!!");
            dataLayer.DeleteCourseData();
            router.restart();
        }

        private void navToCreateCourse()
        {
            Console.WriteLine("navToCreateCourse!!");
            router.navTo(Routings.CourseCreate, item);
        }
        private void navToModuleSummary(string code)
        {
            Console.WriteLine($"navToModuleSummary: {code}");

            Module module = findModuleByCode(code);

            //router.navTo(Routings.CourseCreate, item);
        }

        private Module findModuleByCode(string code)
        {
            Predicate<Module> moduleFinder = (Module module) => { return module.Code == code; };

            return item.Modules.Find(moduleFinder);
        }

        private Course item;
    }
}

