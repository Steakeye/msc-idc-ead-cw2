using CourseGradeEstimator.core.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CreateModule
{
    class CreateModuleController : core.view.ViewController<CreateModule>
    {
        public CreateModuleController(Router r) : base(r) {
            view = new CreateModule();
        }
    }
}
