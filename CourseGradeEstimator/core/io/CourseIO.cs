using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseGradeEstimator.models;
using System.Text.RegularExpressions;
using CourseGradeEstimator.core.utils;

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
            DataEntry<Course> data = null;

            if (rawData != null)
            {
                data = DataEntry<Course>.GetInstanceFromJson(rawData);
            }

            return data?.Data;
        }

        public override void SaveData(Course data)
        {
            //string rawData = Course.GetJsonFromInstance(data);
            DataEntry<Course> entry = new DataEntry<Course>(Utils.GetUserName(), data);

            //Add date
            entry.Date = DateTime.UtcNow;

            string rawData = DataEntry<Course>.GetJsonFromInstance(entry);

            SaveRawData(rawData);
        }
    }
}
