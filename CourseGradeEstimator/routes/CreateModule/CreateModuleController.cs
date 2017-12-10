using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
using CourseGradeEstimator.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CreateModule
{
    class CreateModuleController : core.view.ComplexViewController<CreateModule>
    {
        public CreateModuleController(Router r, DataDTO<Module, Course, ModuleGrade> d) : base(r) {
            item = d.Data;
            parent = d.Parent;
            grade = d.Grade;

            view = new CreateModule();

            populateView();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateAssignment));
            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));
            eventMap.Add(CreateViewBindings.Save, new core.view.VoidDelegate(saveData));

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

            if (parent.Modules == null)
            {
                parent.Modules = new List<Module>();
            }

            if (!parent.Modules.Contains(item))
            {
                parent.Modules.Add(item);
            }

            dataLayer.SaveCourseData(parent);
            router.navBack();
        }

        private void navToCreateAssignment()
        {
            Console.WriteLine("navToCreateAssignment!!");
            router.navTo(Routings.AssignmentCreate);
        }

        private Module item;
        private Course parent;
        private ModuleGrade grade;
    }
}
