
using System.Drawing;
using System.Windows.Forms;

//using ViewUtils = CourseGradeEstimator.core.utils.View;

namespace CourseGradeEstimator.routes.Start
{
    public enum StartViewBindings {
        Create
    }

    public partial class StartView : core.view.View
    {
        public StartView()
        {
            base.InitializeComponent();
            InitializeComponent();
            setupButton(startBtn);
            //startBtn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
           // startBtn.Location = new Point(350, 350);
            //ViewUtils.GetButtonSize(startBtn);
        }

        public override void BindDelegates() {
            startBtn.Click += makeBinding(StartViewBindings.Create);
        }

        protected void initViewAdjustment()
        {
            SuspendLayout();
        }
        protected void endViewAdjustment()
        {
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
