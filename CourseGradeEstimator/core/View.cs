using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseGradeEstimator.core
{
    public delegate void VoidDelegate();
    public interface IEnumLike : IComparable, IFormattable, IConvertible { }
    public interface IView {
    }

    //should be `public abstract class View : Form, IView` but VS forms preview fails if this is applied
    public class View : Form, IView 
    {
        protected View() {
        }

        public virtual void BindDelegates() { }

        public Hashtable EventBindings => eventBindings;

        protected System.EventHandler makeBinding<A>(A eventKey) {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];

            return new System.EventHandler((object sender, EventArgs e) => Invoke(cb));
        }
        protected void FindFuncAndCall<A>(A eventKey)
        {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];
            Invoke(cb);
        }

        protected Hashtable eventBindings = new Hashtable();

    }
}