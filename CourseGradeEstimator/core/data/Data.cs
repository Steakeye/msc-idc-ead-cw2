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
            gradeIO = new GradeIO();
        }
        public Course LoadCourseData()
        {
            return courseIO.LoadData();
        }
        public void SaveCourseData(Course course)
        {
            courseIO.SaveData(course);
        }

        public void DeleteCourseData()
        {
            courseIO.DeleteData();
        }

        public CourseGrade LoadGradeData()
        {
            return gradeIO.LoadData();
        }
        public void SaveGradeData(CourseGrade course)
        {
            gradeIO.SaveData(course);
        }

        public void DeleteGradeData()
        {
            gradeIO.DeleteData();
        }

        private static Data instance;

        private CourseIO courseIO;
        private GradeIO gradeIO;
    }
}
