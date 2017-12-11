using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CreateModule
{
    public partial class CreateModule : core.view.CreateComplex.CreateComplex
    {
        public CreateModule(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateModuleHeader;
            this.Text = $"{Properties.Resources.AppTitle} - Create {headerTitle}";
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsAssessments;
            //header.BackColor = Color.Orange;
            //childItems.BackColor = Color.Blue;

            //bottomButtonBar.BackColor = Color.Green;
            childItems.Width = Width;
            //tablePanel.BackColor = Color.LightBlue;
            //BackColor = Color.HotPink;
        }
        public string ItemTitle { get { return header.TitleValue; } set { header.TitleValue = value; } }
        public string ItemYear { get { return header.YearValue; } set { header.YearValue = value; } }
        public string ItemCode { get { return header.CodeValue; } set { header.CodeValue = value; } }
        public string ItemDescription { get { return header.DescriptionValue; } set { header.DescriptionValue = value; } }
    }
}
