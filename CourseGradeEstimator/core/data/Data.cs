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
        public static Data GetInstance()
        {
            //Data dl = instance;

            if (instance == null) {
                //dl = 
                instance = new Data();
            }

            return instance;
        }

        Data()
        {
            courseIO = new CourseIO();
        }
        public Course LoadCourseData()
        {
            return courseIO.LoadData();
        }
        public void SaveCourseData(Course course)
        {
            string jsonData = Course.GetJsonFromInstance(course);

            courseIO.SaveData(jsonData);
        }

        private static Data instance;

        private CourseIO courseIO;
    }
}
