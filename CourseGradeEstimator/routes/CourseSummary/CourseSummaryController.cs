using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.routes.CourseSummary
{
    class CourseSummaryController : core.ViewController<CourseSummaryView>
    {
        public CourseSummaryController(Router r): base(r) {
            view = new CourseSummaryView();
        }
    }
}
