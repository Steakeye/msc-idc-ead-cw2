using CourseGradeEstimator.core.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view
{
    interface IViewController<out V> {
        void tearDown();
        V View { get; }
    }

    abstract public class ViewController<V>: IViewController<V>
    {

        protected ViewController(Router r) {
            router = r;
            data = Data.GetInstance(); ;
        }

        public void tearDown()
        {
        }

        public V View => view;

        /*
         * Privates
         */

        protected void navToBack()
        {
            System.Console.WriteLine("navToBack!!");
            router.navBack();
        }
        /*
         * Protected Members
         */
        protected Router router;
        protected Data data;
        protected V view;

    }
}
