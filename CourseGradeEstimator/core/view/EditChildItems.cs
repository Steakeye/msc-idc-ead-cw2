using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view
{
    public partial class EditChildItems : UserControl
    {
        public EditChildItems()
        {
            InitializeComponent();
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }
        //public string HeaderValue { get { return headerTextfield.Text; } set { headerTextfield.Text = value; } }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
