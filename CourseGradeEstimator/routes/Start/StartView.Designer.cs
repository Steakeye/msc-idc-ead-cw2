namespace CourseGradeEstimator.routes.Start
{
    partial class StartView
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
        private new void InitializeComponent()
        {
            //base.InitializeComponent();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.startBtn.Location = new System.Drawing.Point(108, 190);
            this.startBtn.Name = "startBtn";
            //this.startBtn.Size = core.utils.View.GetButtonSize();
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = global::CourseGradeEstimator.Properties.Resources.ViewStartStartButtonText;
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.startBtn);
            this.Name = "StartView";
            this.Text = Properties.Resources.AppTitle;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
    }
}

