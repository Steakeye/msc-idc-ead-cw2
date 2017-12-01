using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core
{
    abstract public class ViewController<V>
//        where V : core.View<Enum>
    {

        public void tearDown()
        {
        }

        public V View => view;

        /*
         * Privates
         */
        /*
         * Private Members
         */
        protected V view;
    }
}
