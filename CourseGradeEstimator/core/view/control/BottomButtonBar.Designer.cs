using System.Windows.Forms;
using System.Drawing;

namespace CourseGradeEstimator.core.view.control
{
    partial class BottomButtonBar
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
            this.layoutPanel = new FlowLayoutPanel();

            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.FlowDirection = FlowDirection.LeftToRight;
            //layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            layoutPanel.Size = new System.Drawing.Size(0, 50);
            //layoutPanel.MaximumSize = Size;
            layoutPanel.MinimumSize = Size;
            layoutPanel.Location = System.Drawing.Point.Add(Config.Dimensions.GetStandardStartLocation(), new Size(0, 10)); //new System.Drawing.Point(30,30); //Config.Dimensions.GetStandardStartLocation();
            //layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.BackColor = System.Drawing.Color.BlueViolet;
            layoutPanel.Margin = Config.Dimensions.GetStandardSidePadding();

            //layoutPanel.Margin = new Padding(30);
            //layoutPanel.Padding = new Padding(30);

            //layoutPanel.Margin.Top = 50;
            // 
            // BottomButtonBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Size = new System.Drawing.Size(0, 100);
            this.MaximumSize = Size;
            this.MinimumSize = Size;
            this.Controls.Add(layoutPanel);
            this.Name = "BottomButtonBar";
            this.ResumeLayout(false);

        }

        #endregion
        //If in doubt change over to the TableLayoutPanel
        //private TableLayoutPanel layoutPanel;
        private FlowLayoutPanel layoutPanel;
        private int topMargin = 15;
    }
}
