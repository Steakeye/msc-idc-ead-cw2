﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.ModuleSummary
{
    public partial class ModuleSummaryView : core.view.SummaryComplex.SummaryComplex
    {
        public ModuleSummaryView(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateModuleHeader;
            this.Text = $"{Properties.Resources.AppTitle} {headerTitle} Summary";
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsAssessments;

            augmentGrid();
            //header.BackColor = Color.Orange;
            //childItems.BackColor = Color.Blue;

            //bottomButtonBar.BackColor = Color.Green;
            childItems.Width = Width;
            //tablePanel.BackColor = Color.LightBlue;
            //BackColor = Color.HotPink;
        }

        public string ItemTitle { set { header.TitleValue = value; } }
        public string ItemYear { set { header.YearValue = value; } }
        public string ItemCode { set { header.CodeValue = value; } }
        public string ItemDescription { set { header.DescriptionValue = value; } }

        private void augmentGrid()
        {
            DataGridView grid = this.childItems.Grid;

            grid.ReadOnly = false;

            DataGridViewColumnCollection cols = grid.Columns;

            IEnumerator colEnumer = cols.GetEnumerator();

            DataGridViewColumn col;

            while (colEnumer.MoveNext())
            {
                col = (DataGridViewColumn)colEnumer.Current;
                col.ReadOnly = true;
                //colEnumer.MoveNext();
            }

            //string columnName, string headerText
            cols.Add(Properties.Resources.StringsGrade, Properties.Resources.StringsGrade);
        }
    }
}
