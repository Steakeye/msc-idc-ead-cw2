using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Summary;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CourseGradeEstimator.routes.CourseSummary
{
    class CourseSummaryController : core.view.ViewController<CourseSummaryView>
    {
        public CourseSummaryController(Router r, DataDTO<Course, Course, CourseGrade> data) : base(r) {
            //item = course;
            /*if (data == null)
            {
                item = dataLayer.CreateCourseData();
                gradeItem = dataLayer.CreateGradeData();
            }*/
            //else

            item = data.Data;
            gradeItem = data.Grade == null ? dataLayer.CreateGradeData() : data.Grade;

            view = new CourseSummaryView();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(SummaryViewBindings.Edit, new core.view.VoidDelegate(navToCreateCourse));
            eventMap.Add(SummaryViewBindings.Delete, new core.view.VoidDelegate(deleteDataAndRestart));
            view.ChildItemEventBindings.Add(SummaryViewBindings.View, new core.view.VoidDelegateWithArgs<string>(navToModuleSummary));

            view.BindDelegates();
        }

        private void populateView()
        {
            List<Module> modules = item.Modules;

            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;

            setGradeMessage();

            if (modules != null && modules.Count > 0)
            {
                string[][] data; 

                data = modules.Select(module => {
                    return new string[] { module.Title, module.Description, module.Code };
                }).ToArray();

                view.SetChildItems(data);
            }
        }

        private void deleteDataAndRestart()
        {
            Console.WriteLine("deleteDataAndRestart!!");
            dataLayer.DeleteCourseData();
            router.restart();
        }

        private void setGradeMessage()
        {
            double? estimate = estimator.CalculateGrade(item, gradeItem);
            string message;

            if (estimate.HasValue)
            {
                message = estimate.ToString();
            }
            else
            {
                message = "not ready!";
            }
            view.AddSummaryMessage(message);
        }

        private void navToCreateCourse()
        {
            Console.WriteLine("navToCreateCourse!!");
            DataDTO<Course, Course, CourseGrade> dto = new DataDTO<Course, Course, CourseGrade> { Data = item, Parent = item, Grade = gradeItem};

            router.navTo(Routings.CourseCreate, dto);
        }
        private void navToModuleSummary(string code)
        {
            Console.WriteLine($"navToModuleSummary: {code}");

            Module module = findModuleByCode(code);
            ModuleGrade moduleGrade = null;

            if (gradeItem.Modules == null)
            {
                gradeItem.Modules = new List<ModuleGrade>();
            }
            else
            { 
                moduleGrade = findModuleGradeByCode(code);
            }

            createModuleGradeIfMissing(code, ref moduleGrade);

            DataDTO<Module, Course, ModuleGrade> dto = new DataDTO<Module, Course, ModuleGrade> { Data = module, Parent = item, Grade = moduleGrade };

            router.navTo(Routings.ModuleSummary, dto);
        }

        private Module findModuleByCode(string code)
        {
            Predicate<Module> moduleFinder = (Module module) => { return module.Code == code; };

            return item.Modules.Find(moduleFinder);
        }

        private ModuleGrade findModuleGradeByCode(string code)
        {
            Predicate<ModuleGrade> moduleFinder = (ModuleGrade grade) => { return grade.Code == code; };

            return gradeItem.Modules.Find(moduleFinder);
        }

        private void createModuleGradeIfMissing(string code, ref ModuleGrade grade)
        {
            if (grade == null)
            {
                grade = new ModuleGrade() { Code = code };
                gradeItem.Modules.Add(grade);
            }
        }
        
        private Course item;
        private CourseGrade gradeItem;

        private GradePredictor estimator = GradePredictor.GetInstance();
    }
}

