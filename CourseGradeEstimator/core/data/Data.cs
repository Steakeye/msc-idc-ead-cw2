using CourseGradeEstimator.core.io;
using CourseGradeEstimator.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.data
{
    public class Data
    {

        public Data()
        {
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
// Match userMatch = Regex.Match(name, @"\w+\\\\(\w+)");
            Match userMatch = Regex.Match(name, @"\w+\\(\w+)");
            userName = userMatch.Groups[1].Value;
            courseIO = new CourseIO(userName);
        }
        public Course LoadCourseData() {
            return courseIO.LoadData();
        }

        private string userName;

        private CourseIO courseIO;
    }
}
