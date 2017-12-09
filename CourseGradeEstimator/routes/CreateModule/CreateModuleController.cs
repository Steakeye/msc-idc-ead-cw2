using CourseGradeEstimator.core.data;
using CourseGradeEstimator.core.view.Create;
using System;
using System.Collections;
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

            Hashtable eventMap = view.EventBindings;

            eventMap.Add(CreateViewBindings.Add, new core.view.VoidDelegate(navToCreateAssignment));
            eventMap.Add(CreateViewBindings.Cancel, new core.view.VoidDelegate(navToBack));

            view.BindDelegates();
        }

        private void navToCreateAssignment()
        {
            Console.WriteLine("navToCreateAssignment!!");
            router.navTo(Routings.AssignmentCreate);
        }
    }
}
