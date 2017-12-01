using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseGradeEstimator.core
{
    public interface IEnumLike : IComparable, IFormattable, IConvertible { }
    public interface IView {
    }

    //    public abstract class View<A> : Form
    public abstract class View : Form, IView
    //where A : struct, IEnumLike
    {
        protected View() {
            //eventEnum = actions;
        }

        public Hashtable EventBindings => eventBindings;
        //public Dictionary<IEnumLike, Action<object>> EventBindings => eventBindings;
        //public Dictionary<T, Action<object>> EventBindings<T> => new Dictionary<T, Action<object>>();
        //public Dictionary<T, Action<object>> EventBindings<T> { get { new Dictionary<T, Action<object>>(); } }
        /*public Dictionary<T, Action<object>> EventBindings<T>()
            where T : Type
        {
            //return new Dictionary<T, Action<object>>();
            Dictionary <T, Action < object >> dic = new Dictionary<T, Action<object>>();
            //eventBindings = (Dictionary<Type, Action<object>>)dic;
            eventBindings = dic;

            return dic;
        }*/

        protected void FindFuncAndCall<A>(A eventKey)
        {
            /*if (!typeof(A).IsEnum)
                throw new ArgumentException("Not an enum");
            int ID = Convert.ToInt32(eventKey);
            //Action<object> callBack = eventBindings[ID];
            */
        }

        //protected A eventEnum;
        //protected Dictionary<IEnumLike, Action<object>> eventBindings = new Dictionary<IEnumLike, Action<object>>();
        //protected Dictionary<Type, Action<object>> eventBindings;
        protected Hashtable eventBindings = new Hashtable();

    }
}