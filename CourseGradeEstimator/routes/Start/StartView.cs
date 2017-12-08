
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
        public StartView(): base()
        {
            InitializeComponent();
            customLayout();
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

        private void customLayout()
        {
            initViewAdjustment();

            setupButton(startBtn);

            endViewAdjustment();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
