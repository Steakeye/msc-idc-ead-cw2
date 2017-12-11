using System;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.AssignmentSummary
{
    partial class AssignmentSummaryView : core.view.SummarySimple.SummarySimple
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.container = new System.Windows.Forms.UserControl();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextfield = new System.Windows.Forms.TextBox();

            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(10, 15);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(0, 29);
            this.weightLabel.TabIndex = 0;
            // 
            // weightTextfield
            // 
            this.weightTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextfield.Location = new System.Drawing.Point(10, 45);
            this.weightTextfield.Name = "weightTextfield";
            this.weightTextfield.Size = new System.Drawing.Size(70, 35);
            this.weightTextfield.TabIndex = 1;
            this.weightTextfield.ReadOnly = true;
            this.weightTextfield.KeyPress += new KeyPressEventHandler(weightTextfield_KeyPress);
            // 
            // container
            // 
            this.container.Controls.Add(this.weightLabel);
            this.container.Controls.Add(this.weightTextfield);
            // 
            // CreateAssignment
            // 
            //flowPanel
            tablePanel.Controls.Add(this.container, 0, 1);
            this.Name = "CreateAssignment";
            this.ResumeLayout(true);
        }

        #endregion
        private UserControl container;
        private Label weightLabel;
        private TextBox weightTextfield;

        private void weightTextfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}

