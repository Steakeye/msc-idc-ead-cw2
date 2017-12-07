using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseGradeEstimator.models;
using CourseGradeEstimator.core.utils;

namespace CourseGradeEstimator.core.io
{
    public class GradeIO : CoreIO<CourseGrade, GradeFS, CourseDB>, IConcreteIO<CourseGrade>
    {
        public GradeIO() : base(new GradeFS(), new CourseDB()) {
            resourceType = Properties.Resources.AppResourceTypeCourse;
        }

        public override CourseGrade LoadData()
        {
            string rawData = LoadRawData();
            DataEntry<CourseGrade> data = null;

            if (rawData != null)
            {
                data = DataEntry<CourseGrade>.GetInstanceFromJson(rawData);
            }

            return data?.Data;
        }

        public override void SaveData(CourseGrade data)
        {
            DataEntry<CourseGrade> entry = new DataEntry<CourseGrade>(Utils.GetUserName(), data);

            //Add date
            entry.Date = DateTime.UtcNow;

            string rawData = DataEntry<CourseGrade>.GetJsonFromInstance(entry);

            SaveRawData(rawData);
        }

        public override void DeleteData()
        {
            DeleteRawData();
        }
    }
}
