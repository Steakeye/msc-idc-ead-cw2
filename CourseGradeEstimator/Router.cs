using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseGradeEstimator.Start;

namespace CourseGradeEstimator
{
    enum Routings {
        Start
    }
    class Router
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

            currentRoute = (core.ViewController)Activator.CreateInstance(routes[route]);
            
        }

        private void registerRoutes() {
            routes.Add(Routings.Start, typeof(StartController));
        }

        private Dictionary<Routings, Type> routes = new Dictionary<Routings, Type>();

        private core.ViewController currentRoute;
        private Stack<core.ViewController> routeHistory = new Stack<core.ViewController>();

    }
}
