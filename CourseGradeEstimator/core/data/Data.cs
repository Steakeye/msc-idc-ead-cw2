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
        public Course CreateCourseData()
        {
            courseCache = new Course();
            return courseCache;
        }
        public Course LoadCourseData()
        {
            courseCache = courseIO.LoadData();
            return courseCache;
        }
        public void SaveCourseData(Course course)
        {
            courseIO.SaveData(course);
        }
        public void SaveCourseData()
        {
            SaveCourseData(courseCache);
        }

        public void DeleteCourseData()
        {
            courseIO.DeleteData();
        }

        public CourseGrade CreateGradeData()
        {
            gradeCache = new CourseGrade();
            return gradeCache;
        }
        public CourseGrade LoadGradeData()
        {
            gradeCache = gradeIO.LoadData();
            return gradeCache;
        }
        public void SaveGradeData(CourseGrade course)
        {
            gradeIO.SaveData(course);
        }
        public void SaveGradeData()
        {
            SaveGradeData(gradeCache);
        }
        public void DeleteGradeData()
        {
            gradeIO.DeleteData();
        }

        public Course CourseCache { set => courseCache = value; }
        public CourseGrade GradeCache { set => gradeCache = value; }

        private static Data instance;

        private CourseIO courseIO;
        private GradeIO gradeIO;

        private Course courseCache;
        private CourseGrade gradeCache;
    }
}
