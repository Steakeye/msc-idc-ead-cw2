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

            router.navTo(Routings.Start);

            Application.Run(router);
        }

        private Router router = new Router();
        private Data dataLayer = new Data();
    }
}
