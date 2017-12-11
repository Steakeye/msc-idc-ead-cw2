using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CourseSummary
{
    partial class CourseSummaryView : core.view.SummaryComplex.SummaryComplex
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
        private void InitializeComponent()
        {
            this.deleteButton = new Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 29);
            this.messageLabel.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = global::CourseGradeEstimator.Properties.Resources.StringsDelete;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // CourseSummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 516);
            this.Name = "CourseSummaryView";
            this.Text = "Course Summary";
            this.ResumeLayout(false);

        }

        #endregion
        private Button deleteButton;
        private Label messageLabel = new Label();

    }
}

