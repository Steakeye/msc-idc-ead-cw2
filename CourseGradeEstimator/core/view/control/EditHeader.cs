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
    public partial class EditHeader : UserControl
    {
        public EditHeader()
        {
            InitializeComponent();
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }
        public string TitleValue { get { return headerTextfield.Text; } set { headerTextfield.Text = value; } }

        public string CodeValue { get { return codeTextfield.Text; } set { codeTextfield.Text = value; } }

        public string DescriptionValue { get { return descriptionTextfield.Text; } set { descriptionTextfield.Text = value; } }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
