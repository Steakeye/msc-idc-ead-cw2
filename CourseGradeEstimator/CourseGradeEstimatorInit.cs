using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseGradeEstimator.Start;

namespace CourseGradeEstimator
{
    class CourseGradeEstimatorInit
    {
        public CourseGradeEstimatorInit() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            appContext = new ApplicationContext();

            router = new Router();

            router.navTo(Routings.Start);

            Application.Run(router);
            //Application.Run(new Start());
        }

        private ApplicationContext appContext;
        private Router router;
    }
}
