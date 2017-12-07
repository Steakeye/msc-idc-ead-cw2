using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.Create
{
    public partial class CreateCourse : CreateView
    {
        public CreateCourse(): base()
        {
            base.InitializeComponent();
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateCourseHeader;
            this.Text = $"{Properties.Resources.AppTitle} - Create {headerTitle}";
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsModules;
        }
    }
}
