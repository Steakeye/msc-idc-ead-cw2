using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

using CourseGradeEstimator.routes.Start;
using CourseGradeEstimator.routes.CreateCourse;
using CourseGradeEstimator.routes.CourseSummary;
using CourseGradeEstimator.routes.CreateModule;
using CourseGradeEstimator.routes.ModuleSummary;
using CourseGradeEstimator.routes.CreateAssignment;
using CourseGradeEstimator.models;

namespace CourseGradeEstimator
{
    public enum Routings {
        Start,
        CourseCreate,
        CourseSummary,
        ModuleCreate,
        ModuleSummary,
        AssignmentCreate
    }
    public class Router : ApplicationContext
    {
        public Router() {
            registerRoutes();
        }

        public void navTo(Routings route, object data = null, bool forward = true) {
            Type routeClass;

            if (!routes.TryGetValue(route, out routeClass))
            {
                Console.WriteLine("Route not present in Routings!");
                return;
            }

            core.view.View oldView = null;
            Point? pos = null;

            object[] args;

            addToHistory(route, data, forward);

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

            core.view.IViewController<core.view.View> nextRoute = (core.view.IViewController<core.view.View>)Activator.CreateInstance(routeClass, args);
            core.view.View view = nextRoute.View;

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

        public void navBack()
        {
            routeHistory.Pop();
            HistoryItem lastRoute = routeHistory.Peek();

            routeHistory.Peek();

            if (lastRoute != null)
            {
                navTo(lastRoute.Route, lastRoute.Data, false);
            }
        }
        public void restart(Course data = null)
        {
            Routings route = data == null ? Routings.Start : Routings.CourseSummary;

            routeHistory.Clear();
            navTo(route, data);
        }

        private void registerRoutes() {
            routes.Add(Routings.Start, typeof(StartController));
            routes.Add(Routings.CourseCreate, typeof(CreateCourseController));
            routes.Add(Routings.CourseSummary, typeof(CourseSummaryController));
            routes.Add(Routings.ModuleCreate, typeof(CreateModuleController));
            routes.Add(Routings.ModuleSummary, typeof(ModuleSummaryController));
            routes.Add(Routings.AssignmentCreate, typeof(CreateAssignmentController));
        }

        private void addToHistory(Routings route, object data, bool forward)
        {
            if (forward)
            {
                routeHistory.Push(new HistoryItem { Route = route, Data = data  });
            }
        }

        private Dictionary<Routings, Type> routes = new Dictionary<Routings, Type>();

        private core.view.IViewController<core.view.View> currentRoute;
        private Stack<HistoryItem> routeHistory = new Stack<HistoryItem>();

        class HistoryItem {
            public Routings Route;
            public object Data;
        }
    }
}
