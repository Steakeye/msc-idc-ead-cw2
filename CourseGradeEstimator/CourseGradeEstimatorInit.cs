using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CourseGradeEstimator.core.data;

namespace CourseGradeEstimator
{
    class CourseGradeEstimatorInit
    {
        public CourseGradeEstimatorInit() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //appContext = new ApplicationContext();
            
            router.navTo(Routings.Start);

            Application.Run(router);
        }

        //private ApplicationContext appContext;
        private Router router = new Router();
        private Data dataLayer = new Data();
    }
}
