using System;
using System.Collections;
using System.Windows.Forms;

using ViewUtils = CourseGradeEstimator.core.utils.View;

using System.Windows.Forms;
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
            setupLayoutPanel();
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

        protected static void setupButton(Button btn)
        {
            btn.Size = ViewUtils.GetButtonSize();
        }
        protected static void setupButton(Button btn, ButtonSize size)
        {
                /*btn.Margin = new Padding(50);
                btn.Padding = new Padding(50);*/
            btn.Size = ViewUtils.GetButtonSize(size);
        }

        protected void setupLayoutPanel()
        {
            // 
            // flowPanel
            // 
            flowPanel = new FlowLayoutPanel();
            flowPanel.Location = new System.Drawing.Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);
            flowPanel.ClientSize = flowPanel.Size;
            flowPanel.TabIndex = 0;
            //this.flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;

            Controls.Add(flowPanel);
        }
    }
}