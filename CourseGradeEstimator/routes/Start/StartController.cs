using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseGradeEstimator;

namespace CourseGradeEstimator.routes.Start
{
    delegate void NavToCreate();
    class StartController : core.view.ViewController<StartView>
    {
        public StartController(Router r) : base(r) {
            view = new StartView();
            Hashtable eventMap = view.EventBindings;

            eventMap.Add(StartViewBindings.Create, new core.view.VoidDelegate(navToCreate));

            view.BindDelegates();
        }

        protected void navToCreate() {
            System.Console.WriteLine("NavToCreate!!");
            router.navTo(Routings.CourseCreate);
        }
    }
}
