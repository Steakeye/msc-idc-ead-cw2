using System.Windows.Forms;
using System.Drawing;

namespace CourseGradeEstimator.routes.ModuleSummary.control
{
    partial class ModuleSummaryHeader : core.view.control.SummaryHeader
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerTextfield
            // 
            this.headerTextfield.Size = new System.Drawing.Size(490, 35);
            this.headerTextfield.TabIndex = 1;
            this.headerTextfield.ReadOnly = true;
            // 
            // codeLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(510, 15);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Text = Properties.Resources.StringsYear;
            this.yearLabel.Size = new System.Drawing.Size(0, 29);
            this.yearLabel.TabIndex = 2;
            // 
            // codeTextfield
            // 
            this.yearTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextfield.Location = new System.Drawing.Point(510, 45);
            this.yearTextfield.Name = "yearTextfield";
            this.yearTextfield.Size = new System.Drawing.Size(70, 35);
            this.yearTextfield.TabIndex = 3;
            this.yearTextfield.ReadOnly = true;
            // 
            // EditHeader
            // 
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTextfield);
            this.Name = "ModuleSummaryHeader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label yearLabel;
        protected TextBox yearTextfield;

    }
}
