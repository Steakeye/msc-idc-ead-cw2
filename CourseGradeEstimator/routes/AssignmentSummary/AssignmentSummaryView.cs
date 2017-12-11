using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.AssignmentSummary
{
    public partial class AssignmentSummaryView : core.view.SummarySimple.SummarySimple
    {
        public AssignmentSummaryView(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateAssignmentHeader;
            this.Text = $"{Properties.Resources.AppTitle} {headerTitle} Summary";
            this.header.Title = headerTitle;
            this.weightLabel.Text = Properties.Resources.StringsWeighting;
            //header.BackColor = Color.Orange;
            //childItems.BackColor = Color.Blue;

            //bottomButtonBar.BackColor = Color.Green;
            container.Width = Width;
            //tablePanel.BackColor = Color.LightBlue;
            //BackColor = Color.HotPink;
        }

        public string Weighting { get { return weightTextfield.Text; } set { weightTextfield.Text = value; } }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            container.Anchor = allSides;

            //fixLayout();

            //ResumeLayout(true);
        }
    }
}
