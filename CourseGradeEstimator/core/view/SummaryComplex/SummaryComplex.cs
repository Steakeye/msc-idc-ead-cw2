using CourseGradeEstimator.core.view.Summary;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.SummaryComplex
{

    public partial class SummaryComplex : SummaryView
    {
        public SummaryComplex() : base()
        {
            InitializeComponent();
            setupView();
        }

        public override void BindDelegates()
        {
            base.BindDelegates();
            //childItems.AddButton.Click += makeBinding(SummaryViewBindings.View);
        }

        public void SetChildItems(string[][] data)
        {
            //setChildItems.setChildItems()
            this.childItems.Populate(data);
        }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            childItems.Anchor = allSides;

            fixLayout();

            ResumeLayout(true);
        }

    }
}
