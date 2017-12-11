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
    public class GradePredictor
    {
        public static GradePredictor GetInstance()
        {

            if (instance == null) {
                instance = new GradePredictor();
            }

            return instance;
        }


        //public Nullable<double> CalculateGrade(Course course, CourseGrade grade)
        public double? CalculateGrade(Course course, CourseGrade grade)
        {
            List<ModuleGrade> mods = grade.Modules;
            //Let's just do something basic as a token effort given the time!
            /*courseCache = courseIO.LoadData();
            return courseCache;*/
            List < AssignmentGrade > allAGs = new List<AssignmentGrade>();
            //IEnumerable filteredAGs;

           if (mods != null)
            {
                mods.ForEach((mod) => {
                    List<AssignmentGrade> agList = mod.Assignments;

                    if (agList != null)
                    {
                        allAGs.AddRange(agList);
                    }
                });
            }

            IEnumerable<AssignmentGrade> filteredAGs = allAGs.Where((ag) => {
                return ag.Score != null;
            });

            Nullable<double> totalScore;

            if (filteredAGs.Count() > 0)
            {
                totalScore = filteredAGs.Average((ag) => {
                    return ag.Score;
                });

                //return totalScore;
            }
            else
            {
                totalScore = null;
            }


            return totalScore;
        }

        private static GradePredictor instance;

    }
}
