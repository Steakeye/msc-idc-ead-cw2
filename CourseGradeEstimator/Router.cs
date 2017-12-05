using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseGradeEstimator.routes.Start;
using CourseGradeEstimator.routes.Create;
using CourseGradeEstimator.routes.CourseSummary;
using System.Drawing;

namespace CourseGradeEstimator
{
    public enum Routings {
        Start,
        Create,
        CourseSummary
    }
    public class Router : ApplicationContext
    {
        public Router() {
            registerRoutes();
        }

        public void navTo(Routings route, object data = null) {
            core.View oldView = null;
            Point? pos = null;

            core.IViewController<core.View> nextRoute = (core.IViewController<core.View>)Activator.CreateInstance(routes[route], this, data);
            core.View view = nextRoute.View;

            if (currentRoute != null)
            {
                oldView = currentRoute.View;
                pos = new Point(oldView.Location.X, oldView.Location.Y); ;
                currentRoute.tearDown();
            }

            currentRoute = nextRoute;

            view = currentRoute.View;
           
            MainForm = view;

            view.Show();

            if (pos != null)
            {
                view.Location = pos.Value;
            }
            if (oldView != null)
            {
                oldView.Close();
            }
        }

        private void registerRoutes() {
            routes.Add(Routings.Start, typeof(StartController));
            routes.Add(Routings.Create, typeof(CreateController));
            routes.Add(Routings.CourseSummary, typeof(CourseSummaryController));
        }

        private Dictionary<Routings, Type> routes = new Dictionary<Routings, Type>();

        //private core.ViewController<core.View> currentRoute;
        private core.IViewController<core.View> currentRoute;
        private Stack<core.ViewController<core.View>> routeHistory = new Stack<core.ViewController<core.View>>();

    }
}
