using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.Start
{
    class StartController : core.ViewController<StartView>
    {
        public StartController() {
            view = new StartView();
            Dictionary<core.IEnumLike, Action<object>> eventMap = view.EventBindings;
        }
    }
}
