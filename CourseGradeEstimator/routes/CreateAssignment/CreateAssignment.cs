using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CreateAssignment
{
    public partial class CreateAssignment : core.view.CreateSimple.CreateSimple
    {
        public CreateAssignment(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateAssignmentHeader;
            this.Text = $"{Properties.Resources.AppTitle} - Create {headerTitle}";
            this.header.Title = headerTitle;
            this.weightLabel.Text = Properties.Resources.StringsWeighting;
            //header.BackColor = Color.Orange;
            //childItems.BackColor = Color.Blue;

            //bottomButtonBar.BackColor = Color.Green;
            container.Width = Width;
            //tablePanel.BackColor = Color.LightBlue;
            //BackColor = Color.HotPink;
        }

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
