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
            courseIO = new CourseIO();
        }
        public Course LoadCourseData() {
            return courseIO.LoadData();
        }

        private CourseIO courseIO;
    }
}
