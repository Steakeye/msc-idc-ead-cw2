﻿using System;
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
    public partial class SummaryHeader : UserControl
    {
        public SummaryHeader()
        {
            InitializeComponent();
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }
        //public string HeaderValue { get { return headerTextfield.Text; } set { headerTextfield.Text = value; } }

        public string TitleValue { set => headerTextfield.Text = value; }

        public string CodeValue { set => codeTextfield.Text = value; }

        public string DescriptionValue { set => descriptionTextfield.Text = value; }


        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
