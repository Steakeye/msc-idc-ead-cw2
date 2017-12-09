using CourseGradeEstimator.core.data;
using CourseGradeEstimator.models;
using System;
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
        }

        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;
        }

        private Course item;
    }
}

