using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Summary;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CourseSummary
{
    class CourseSummaryController : core.view.ViewController<CourseSummaryView>
    {
        public CourseSummaryController(Router r, Course course): base(r) {
            item = course;

            view = new CourseSummaryView();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(SummaryViewBindings.Edit, new core.view.VoidDelegate(navToCreateModule));
            eventMap.Add(SummaryViewBindings.Delete, new core.view.VoidDelegate(deleteDataAndRestart));

            view.BindDelegates();
        }

        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;
        }

        private void deleteDataAndRestart()
        {
            Console.WriteLine("deleteDataAndRestart!!");
            //populateModel();
            //dataLayer.SaveCourseData(item);
        }

        private void navToCreateModule()
        {
            Console.WriteLine("navToCreateCourse!!");
            router.navTo(Routings.CourseCreate, item);
        }

        private Course item;
    }
}

