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

            if (instance == null) {
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
            courseIO.SaveData(course);
        }

        private static Data instance;

        private CourseIO courseIO;
    }
}
