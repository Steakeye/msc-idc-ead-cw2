﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResourceStrings = CourseGradeEstimator.Properties.Resources;

namespace CourseGradeEstimator.core.view.control
{
    public partial class EditChildItems : UserControl
    {
        public EditChildItems()
        {
            InitializeComponent();
            setupComponent();
            setupInternalComponents();
            Load += new EventHandler(EditChildItems_Load);
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }

        private void itemTablePanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditChildItems_Load(object sender, EventArgs e)
        {
            //this.Width = Parent.Width;
            //this.Width = this.Parent.Height;
            this.Dock = DockStyle.Fill;
        }

        private void setupComponent()
        {
        }
        private void setupInternalComponents()
        {
            setupDataGridView();
            setupAddButton();
        }
        private void setupDataGridView()
        {
            //table
            itemTablePanel.Size = new System.Drawing.Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            //columns
            // 
            // titleColumn
            // 
            this.titleColumn.HeaderText = ResourceStrings.StringsTitle;
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ToolTipText = ResourceStrings.StringsTitle;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = ResourceStrings.StringsDescription;
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = ResourceStrings.StringsEdit;
            this.editColumn.Name = "editColumn";
            // deleteColumn
            this.deleteColumn.HeaderText = ResourceStrings.StringsDelete;
            this.deleteColumn.Name = "deleteColumn";
            //rows
        }

        private void setupAddButton()
        {
            this.addBtn.Size = core.utils.View.GetButtonSize();
        }
    }
}
