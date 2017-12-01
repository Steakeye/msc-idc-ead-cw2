using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseGradeEstimator.core
{
    public interface IEnumLike : IComparable, IFormattable, IConvertible {}

    //    public abstract class View<A> : Form
    public abstract class View : Form
            //where A : struct, IEnumLike
    {
        protected View() {
            //eventEnum = actions;
        }

        public Dictionary<IEnumLike, Action<object>> EventBindings => eventBindings;

        protected void FindFuncAndCall<A>(A eventKey)
        {
            if (!typeof(A).IsEnum)
                throw new ArgumentException("Not an enum");
            int ID = Convert.ToInt32(eventKey);
            //Action<object> callBack = eventBindings[ID];

        }

        //protected A eventEnum;
        protected Dictionary<IEnumLike, Action<object>> eventBindings = new Dictionary<IEnumLike, Action<object>>();

    }
}