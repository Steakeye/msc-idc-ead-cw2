using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CreateCourse
{
    public partial class CreateCourse : core.view.CreateComplex.CreateComplex
    {
        public CreateCourse(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateCourseHeader;
            this.Text = String.Format(Properties.Resources.ViewCreateViewHeader, Properties.Resources.AppTitle, headerTitle);
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsModules;
            header.BackColor = Color.Orange;
            childItems.BackColor = Color.Blue;

            bottomButtonBar.BackColor = Color.Green;
            childItems.Width = Width;
            tablePanel.BackColor = Color.LightBlue;
            BackColor = Color.HotPink;
        }
    }
}
