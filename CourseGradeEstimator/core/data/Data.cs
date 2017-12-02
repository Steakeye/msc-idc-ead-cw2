using CourseGradeEstimator.core.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.data
{
    public class Data
    {

        public Data() {
            courseIO = new CourseIO(userName);
        }
        public void loadCourseData() {
            courseIO.loadData();
        }

        private string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private CourseIO courseIO;
    }
}
