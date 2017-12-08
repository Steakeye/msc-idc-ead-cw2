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
    public partial class CreateView : core.view.View
    {
        public CreateView() : base()
        {
            InitializeComponent();
            this.Text = $"{Properties.Resources.AppTitle} - Create";
        }
    }
}
