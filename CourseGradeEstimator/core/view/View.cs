﻿using System;
using System.Collections;
using System.Windows.Forms;

using ViewUtils = CourseGradeEstimator.core.utils.View;

using System.Windows.Forms;

namespace CourseGradeEstimator.core.view
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

        protected EventHandler makeBinding<A>(A eventKey) {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];

            return new EventHandler((object sender, EventArgs e) => Invoke(cb));
        }
        protected void FindFuncAndCall<A>(A eventKey)
        {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];
            Invoke(cb);
        }

        protected Hashtable eventBindings = new Hashtable();

        protected void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // View
            // 
            ClientSize = new System.Drawing.Size(584, 361);
            MinimumSize = new System.Drawing.Size(600, 400);
            Name = "View";
            //MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);

        }

        protected void setupButton(Button btn) {
            btn.Size = ViewUtils.GetButtonSize();
        }
    }
}