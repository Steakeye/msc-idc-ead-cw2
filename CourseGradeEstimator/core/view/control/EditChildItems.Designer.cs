﻿using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.control
{
    partial class EditChildItems
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn(); 
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.addBtn = new Button();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(0, 29);
            this.headerLabel.TabIndex = 1;
            // 
            // itemTablePanel
            // 
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleColumn,
            this.descriptionColumn,
            this.editColumn,
            this.deleteColumn});
            this.dataGrid.Location = new System.Drawing.Point(3, 32);
            this.dataGrid.Name = "itemTablePanel";
            //this.itemTablePanel.Size = new System.Drawing.Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemTablePanel_CellContentClick);
            // 
            // addBtn
            //
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            //this.addBtn.Location = new System.Drawing.Point(140, 210);
            this.addBtn.Name = "addBtn";
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = global::CourseGradeEstimator.Properties.Resources.StringsAdd;
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // flowPanel
            // 
            this.layoutPanel.Controls.Add(this.headerLabel);
            this.layoutPanel.Controls.Add(this.dataGrid);
            this.layoutPanel.Controls.Add(this.addBtn);
            //this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "flowPanel";
            this.layoutPanel.Size = new System.Drawing.Size(252, 300);
            this.layoutPanel.TabIndex = 0;
            //this.layoutPanel.WrapContents = false;
            // 
            // EditChildItems
            //
            this.Controls.Add(this.layoutPanel);
            this.Name = "EditChildItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            //this.Size = new System.Drawing.Size(252, 350); NO! this fails!
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGrid;
        //private FlowLayoutPanel flowPanel;
        private TableLayoutPanel layoutPanel;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private DataGridViewButtonColumn editColumn;
        private DataGridViewButtonColumn deleteColumn;
        private Button addBtn;

    }
}
