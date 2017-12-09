using System;
using System.Collections;
using System.Windows.Forms;

using ViewUtils = CourseGradeEstimator.core.utils.View;

using CourseGradeEstimator.core.utils;

namespace CourseGradeEstimator.core.view
{
    public delegate void VoidDelegate();
    public interface IEnumLike : IComparable, IFormattable, IConvertible { }
    public interface IView {
    }

    //should be `public abstract class View : Form, IView` but VS forms preview fails if this is applied
    public partial class View : Form, IView 
    {
        protected View() {
            InitializeComponent();
            //InitializeComponent2();
            setupView();
            setupLayoutPanel();
        }

        public virtual void BindDelegates() { }

        public Hashtable EventBindings => eventBindings;

        protected EventHandler makeBinding<A>(A eventKey) {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];

            EventHandler handler = null;

            if (cb != null)
            {
                handler = new EventHandler((object sender, EventArgs e) => Invoke(cb));
            }

            return handler;
        }
        protected void FindFuncAndCall<A>(A eventKey)
        {
            VoidDelegate cb = (VoidDelegate)eventBindings[eventKey];
            Invoke(cb);
        }

        protected Hashtable eventBindings = new Hashtable();

        protected static void setupButton(Button btn)
        {
            btn.Size = ViewUtils.GetButtonSize();
        }
        protected static void setupButton(Button btn, ButtonSize size)
        {
            btn.Size = ViewUtils.GetButtonSize(size);
        }

        protected void setupView()
        {
            /*this.ClientSize = new System.Drawing.Size(920, 425);
            Size = new System.Drawing.Size(920, 425);*/
        }

        protected void setupLayoutPanel()
        {
            // 
            // flowPanel
            // 
            tablePanel = new TableLayoutPanel();
            tablePanel.Location = new System.Drawing.Point(0, 0);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);
            tablePanel.ClientSize = tablePanel.Size;
            tablePanel.TabIndex = 0;

            Controls.Add(tablePanel);
        }
    }
}