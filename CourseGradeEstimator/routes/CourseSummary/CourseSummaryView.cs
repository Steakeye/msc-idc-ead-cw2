using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CourseSummary
{
    partial class CourseSummaryView : core.view.SummaryComplex.SummaryComplex
    {
        public CourseSummaryView()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateCourseHeader;
            this.Text = String.Format(Properties.Resources.ViewSummaryViewHeader, Properties.Resources.AppTitle, headerTitle);
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsModules;
        }
    }
}
