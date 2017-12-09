using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CreateCourse
{
    class CreateCourseController : core.view.ViewController<CreateCourse>
    {
        public CreateCourseController(Router r) : this(r, new Course()) {
        }
        //public CreateCourseController(Router r, Course course = null) : base(r) {
        public CreateCourseController(Router r, Course course) : base(r) {
            item = course;

            view = new CreateCourse();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateModule));
            eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));
            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));

            view.BindDelegates();
        }

        private void populateView()
        {
            view.ItemTitle = item.Title;
            view.ItemCode = item.Code;
            view.ItemDescription = item.Description;
        }
        private void populateModel()
        {
            item.Title = view.ItemTitle;
            item.Code = view.ItemCode;
            item.Description = view.ItemDescription;
        }

        private void saveData()
        {
            Console.WriteLine("saveData!!");
            populateModel();
            dataLayer.SaveCourseData(item);
            router.restart(item);
        }

        private void navToCreateModule()
        {
            Console.WriteLine("navToCreateModule!!");

            DataDTO<Module, Course, ModuleGrade> dto = new DataDTO<Module, Course, ModuleGrade> { Data = new Module(), Parent = item };

            router.navTo(Routings.ModuleCreate, dto);
        }

        private Course item;
    }
}
