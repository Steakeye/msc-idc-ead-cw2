﻿using System;
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
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateCourseHeader;
            this.Text = $"{Properties.Resources.AppTitle} - Create {headerTitle}";
            this.header.Title = headerTitle;
            //header.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //header.Dock = DockStyle.Fill;
            this.childItems.Title = Properties.Resources.StringsModules;
            header.BackColor = Color.Orange;
            childItems.BackColor = Color.Blue;
            //childItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //childItems.Dock = DockStyle.Fill;
            bottomButtonBar.BackColor = Color.Green;
            childItems.Width = Width;
            flowPanel.BackColor = Color.LightBlue;
            BackColor = Color.HotPink;
        }
    }
}
