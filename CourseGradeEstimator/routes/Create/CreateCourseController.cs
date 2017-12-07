using CourseGradeEstimator.core.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.Create
{
    class CreateCourseController : core.view.ViewController<CreateView>
    {
        public CreateCourseController(Router r) : base(r) {
            view = new CreateCourse();
        }
    }
}
