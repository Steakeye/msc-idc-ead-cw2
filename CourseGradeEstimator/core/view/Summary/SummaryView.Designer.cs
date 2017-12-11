﻿using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.Summary
{
    partial class SummaryView : View
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
            this.header = new CourseGradeEstimator.core.view.control.SummaryHeader();
            this.bottomButtonBar = new CourseGradeEstimator.core.view.control.BottomButtonBar();
            //this.saveButton = new Button();
            this.backButton = new Button();
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
            // bottomButtonBar
            // 
            this.bottomButtonBar.AutoSize = true;
            this.bottomButtonBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomButtonBar.Location = new System.Drawing.Point(0, 168);
            this.bottomButtonBar.Name = "bottomButtonBar";
            this.bottomButtonBar.Size = new System.Drawing.Size(200, 50);
            this.bottomButtonBar.TabIndex = 2;

            // 
            // saveButton
            //
            //this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            /*this.saveButton.Name = "saveButton";
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = global::CourseGradeEstimator.Properties.Resources.StringsSave;
            this.saveButton.UseVisualStyleBackColor = true;*/

            // 
            // backButton
            //
            //this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Name = "backButton";
            this.backButton.TabIndex = 3;
            this.backButton.Text = global::CourseGradeEstimator.Properties.Resources.StringsBack;
            this.backButton.UseVisualStyleBackColor = true;

            // 
            // SummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //flowPanel
            tablePanel.Controls.Add(this.header);
            tablePanel.Controls.Add(this.bottomButtonBar);
            this.Name = "SummaryView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected core.view.control.SummaryHeader header;
        protected core.view.control.BottomButtonBar bottomButtonBar;
        //protected Button saveButton;
        protected Button backButton;
    }
}

