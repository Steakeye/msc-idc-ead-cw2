using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CourseGradeEstimator.core.data;
using CourseGradeEstimator.models;

namespace CourseGradeEstimator
{
    class CourseGradeEstimatorInit
    {
        public CourseGradeEstimatorInit() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Course courseData = dataLayer.LoadCourseData();

            Routings initRoute = courseData != null ? Routings.CourseSummary: Routings.Start;

            router.navTo(initRoute, courseData);

            Application.Run(router);
        }

        private Router router = new Router();
        private Data dataLayer = Data.GetInstance();
    }
}
