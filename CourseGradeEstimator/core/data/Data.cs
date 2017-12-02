using CourseGradeEstimator.core.io;
using CourseGradeEstimator.models;
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
        public Course LoadCourseData() {
            return courseIO.LoadData();
        }

        private string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private CourseIO courseIO;
    }
}
