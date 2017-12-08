using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
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
        public CreateCourseController(Router r) : base(r) {
            view = new CreateCourse();

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));

            view.BindDelegates();
        }
    }
}
