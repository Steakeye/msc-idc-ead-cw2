namespace CourseGradeEstimator.routes.Create
{
    partial class CreateView
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
            this.header = new CourseGradeEstimator.core.view.control.EditHeader();
            this.childItems = new CourseGradeEstimator.core.view.control.EditChildItems();
            this.bottomButtonBar = new CourseGradeEstimator.core.view.control.BottomButtonBar();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(0, 0);
            this.header.TabIndex = 0;

            // 
            // childItems
            // 
            this.childItems.AutoSize = true;
            this.childItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.childItems.Location = new System.Drawing.Point(0, 250);
            this.childItems.Name = "childItems";
            this.childItems.Size = new System.Drawing.Size(100, 100);
            this.childItems.TabIndex = 1;

            // 
            // bottomButtonBar1
            // 
            this.bottomButtonBar.AutoSize = true;
            this.bottomButtonBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomButtonBar.Location = new System.Drawing.Point(0, 168);
            this.bottomButtonBar.Name = "bottomButtonBar1";
            this.bottomButtonBar.Size = new System.Drawing.Size(200, 50);
            this.bottomButtonBar.TabIndex = 2;

            // 
            // CreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            /*this.Controls.Add(this.header);
            this.Controls.Add(this.childItems);
            this.Controls.Add(this.bottomButtonBar);*/
            //flowPanel
            flowPanel.Controls.Add(this.header);
            flowPanel.Controls.Add(this.childItems);
            flowPanel.Controls.Add(this.bottomButtonBar);
            this.Name = "CreateView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected core.view.control.EditHeader header;
        protected core.view.control.EditChildItems childItems;
        protected core.view.control.BottomButtonBar bottomButtonBar;
    }
}

