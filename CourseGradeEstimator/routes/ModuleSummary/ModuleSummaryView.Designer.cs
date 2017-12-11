namespace CourseGradeEstimator.routes.ModuleSummary
{
    partial class ModuleSummaryView : core.view.SummaryComplex.SummaryComplex
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
            header = new control.ModuleSummaryHeader();
            this.SuspendLayout();

            //
            //header
            //
            this.header.AutoSize = true;
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(0, 0);
            this.header.TabIndex = 0;
            //flowPanel
            tablePanel.Controls.RemoveAt(0);
            tablePanel.Controls.Add(this.header, 0, 0);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "ModuleSummaryView";
            this.ResumeLayout(false);

        }

        #endregion
        protected new control.ModuleSummaryHeader header;

    }
}

