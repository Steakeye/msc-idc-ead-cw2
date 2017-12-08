using System;
using System.Collections;
using System.Windows.Forms;

using ViewUtils = CourseGradeEstimator.core.utils.View;

using System.Windows.Forms;
using CourseGradeEstimator.core.utils;

namespace CourseGradeEstimator.core.view
{

    //should be `public abstract class View : Form, IView` but VS forms preview fails if this is applied
    partial class View : Form, IView
    {
        protected void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // View
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            Size = new System.Drawing.Size(800, 400);
            //            ClientSize = new System.Drawing.Size(584, 361);
            MinimumSize = new System.Drawing.Size(600, 400);
            Name = "View";
            //MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

            /*// lock form
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            **/

            ResumeLayout(false);

        }

        protected FlowLayoutPanel flowPanel;
    }
}