using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseGradeEstimator.routes.Start;
using CourseGradeEstimator.routes.Create;
using CourseGradeEstimator.routes.CourseSummary;
using System.Drawing;
using CourseGradeEstimator.core.data;

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

            object[] args;

            if (data != null)
            {
                args = new object[2];
                args[1] = data;
            }
            else
            {
                args = new object[1];
            }

            args[0] = this;

            core.IViewController<core.View> nextRoute = (core.IViewController<core.View>)Activator.CreateInstance(routes[route], args);
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
