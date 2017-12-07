using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.control
{
    public partial class EditChildItems : UserControl
    {
        public EditChildItems()
        {
            InitializeComponent();
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }

    }
}
