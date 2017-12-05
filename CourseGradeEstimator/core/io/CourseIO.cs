using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseGradeEstimator.models;

namespace CourseGradeEstimator.core.io
{
    public class CourseIO : CoreIO<Course, CourseFS, CourseDB>
    {
        public CourseIO(string user) : base(user, new CourseFS()) {
            resourceType = Properties.Resources.AppResourceTypeCourse;
        }

        //public void LoadData() { }
    }
}
