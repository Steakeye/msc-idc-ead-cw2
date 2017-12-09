using CourseGradeEstimator.core.view.Create;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.CreateComplex
{
    partial class CreateComplex : CreateView
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
            this.childItems = new CourseGradeEstimator.core.view.control.EditChildItems();

            this.SuspendLayout();


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
            // CreateComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //flowPanel
            tablePanel.Controls.Add(this.childItems, 0, 1);
            this.Name = "CreateComplex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected core.view.control.EditChildItems childItems;
    }
}

