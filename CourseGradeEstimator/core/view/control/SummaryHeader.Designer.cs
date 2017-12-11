using System.Windows.Forms;
using System.Drawing;

namespace CourseGradeEstimator.core.view.control
{
    partial class SummaryHeader
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
            this.headerTextfield = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextfield = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(10, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(0, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // headerTextfield
            // 
            this.headerTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextfield.Location = new System.Drawing.Point(10, 45);
            this.headerTextfield.Name = "headerTextfield";
            this.headerTextfield.Size = new System.Drawing.Size(580, 35);
            this.headerTextfield.TabIndex = 1;
            this.headerTextfield.ReadOnly = true;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(600, 15);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Text = Properties.Resources.StringsCode;
            this.codeLabel.Size = new System.Drawing.Size(0, 29);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // codeTextfield
            // 
            this.codeTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextfield.Location = new System.Drawing.Point(600, 45);
            this.codeTextfield.Name = "codeTextfield";
            this.codeTextfield.Size = new System.Drawing.Size(70, 35);
            this.codeTextfield.TabIndex = 3;
            this.codeTextfield.ReadOnly = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(10, 85);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Text = Properties.Resources.StringsDescription;
            this.descriptionLabel.Size = new System.Drawing.Size(0, 29);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionTextfield
            // 
            this.descriptionTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextfield.Location = new System.Drawing.Point(10, 115);
            this.descriptionTextfield.Name = "descriptionTextfield";
            this.descriptionTextfield.Size = new System.Drawing.Size(660, 70);
            this.descriptionTextfield.TabIndex = 5;
            this.descriptionTextfield.Multiline = true;
            this.descriptionTextfield.AcceptsReturn = true;
            this.descriptionTextfield.AcceptsTab = true;
            this.descriptionTextfield.WordWrap = true;
            this.descriptionTextfield.ReadOnly = true;
            // 
            // EditHeader
            // 
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.headerTextfield);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextfield);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextfield);
            this.Name = "SummaryHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        protected TextBox headerTextfield;
        private Label codeLabel;
        protected TextBox codeTextfield;
        private Label descriptionLabel;
        protected TextBox descriptionTextfield;

    }
}
