using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseGradeEstimator.Start;
using System.Windows.Forms;
using CourseGradeEstimator.Create;
using System.Drawing;

namespace CourseGradeEstimator
{
    public enum Routings {
        Start,
        Create
    }
    public class Router : ApplicationContext
    {
        public Router() {
            registerRoutes();
            
            
        }

        public void navTo(Routings route) {
            core.View oldView = null;
            Point? pos = null;
            //core.View view;

            core.IViewController<core.View> nextRoute = (core.IViewController<core.View>)Activator.CreateInstance(routes[route], this);
            core.View view = nextRoute.View;

            if (currentRoute != null)
            {
                oldView = currentRoute.View;
                //view.Location = oldView.Location;
                //view.Location = new Point(oldView.Location.X, oldView.Location.Y);
                pos = new Point(oldView.Location.X, oldView.Location.Y); ;

                //pos.Value.X = oldView.Location.X;
                //pos.Y = oldView.Location.Y;
                currentRoute.tearDown();
            }
            else
            {
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
        }

        private Dictionary<Routings, Type> routes = new Dictionary<Routings, Type>();

        //private core.ViewController<core.View> currentRoute;
        private core.IViewController<core.View> currentRoute;
        private Stack<core.ViewController<core.View>> routeHistory = new Stack<core.ViewController<core.View>>();

    }
}
