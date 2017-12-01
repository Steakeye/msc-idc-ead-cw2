using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseGradeEstimator.Start;
using System.Windows.Forms;

namespace CourseGradeEstimator
{
    enum Routings {
        Start
    }
    class Router : ApplicationContext
    {
        public Router() {
            registerRoutes();
            
            
        }

        public void navTo(Routings route) {
            /*if (Enum.IsDefined(typeof(Routings), (int)route)) {
            }*/
            if (currentRoute != null)
            {
                currentRoute.tearDown();
            }
            else
            {
            }

            currentRoute = (core.ViewController<core.View>)Activator.CreateInstance(routes[route]);
            Form view = currentRoute.View;
            MainForm = view;

            view.Show();


        }

        private void registerRoutes() {
            routes.Add(Routings.Start, typeof(StartController));
        }

        private Dictionary<Routings, Type> routes = new Dictionary<Routings, Type>();

        private core.ViewController<core.View> currentRoute;
        private Stack<core.ViewController<core.View>> routeHistory = new Stack<core.ViewController<core.View>>();

    }
}
