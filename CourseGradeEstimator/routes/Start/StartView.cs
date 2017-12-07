
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
            //ViewUtils.GetButtonSize(startBtn);
        }

        public override void BindDelegates() {
            startBtn.Click += makeBinding(StartViewBindings.Create);
        }
    }
}
