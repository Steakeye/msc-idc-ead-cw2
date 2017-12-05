using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseGradeEstimator.models;

namespace CourseGradeEstimator.core.io
{
    public class GradeIO : CoreIO<CourseGrade, GradeFS, CourseDB>, IConcreteIO<CourseGrade>
    {
        public GradeIO(string user) : base(user, new GradeFS()) {
            resourceType = Properties.Resources.AppResourceTypeCourse;
        }

        public override CourseGrade LoadData()
        {
            string rawData = LoadRawData();

            if (rawData != null)
            {
                return CourseGrade.GetInstanceFromJson<CourseGrade>(rawData);
            }

            return null;
            
        }
    }
}
