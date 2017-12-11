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
            CourseGrade gradeData = dataLayer.LoadGradeData();

            Routings initRoute = courseData != null ? Routings.CourseSummary: Routings.Start;

            DataDTO<Course, Course, CourseGrade > data = null;

            if (courseData != null)
            {
                data = new DataDTO<Course, Course, CourseGrade> { Data = courseData, Grade = gradeData };
            }

            router.navTo(initRoute, data);

            Application.Run(router);
        }

        private Router router = new Router();
        private Data dataLayer = Data.GetInstance();
    }
}
