using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.Start
{
    delegate void NavToCreate();
    class StartController : core.ViewController<StartView>
    {
        public StartController() {
            view = new StartView();
            Hashtable eventMap = view.EventBindings;

            //eventMap.Add(StartViewBindings.Create, (obj) => { });
            eventMap.Add(StartViewBindings.Create, new NavToCreate(navToCreate));
        }

        protected void navToCreate() {
            System.Console.WriteLine("NavToCreate!!");
        }
    }
}
