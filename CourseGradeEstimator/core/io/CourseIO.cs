using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseGradeEstimator.models;
using System.Text.RegularExpressions;

namespace CourseGradeEstimator.core.io
{
    public class CourseIO : CoreIO<Course, CourseFS, CourseDB>, IConcreteIO<Course>
    {
        public CourseIO() : base(new CourseFS(), new CourseDB()) {
            resourceType = Properties.Resources.AppResourceTypeCourse;
        }

        public override Course LoadData()
        {
            string rawData = LoadRawData();

            if (rawData != null)
            {
                return Course.GetInstanceFromJson<Course>(rawData);
            }

            return null;
            
        }
    }
}
