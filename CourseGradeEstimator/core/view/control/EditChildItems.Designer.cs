using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.control
{
    partial class EditChildItems
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
            this.itemTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(252, 100);
            this.flowPanel.TabIndex = 0;
            this.flowPanel.AutoScroll = true;
            this.flowPanel.FlowDirection = FlowDirection.TopDown;
            this.flowPanel.WrapContents = true;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(15, 50);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(0, 29);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.itemTablePanel.ColumnCount = 3;
            this.itemTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.itemTablePanel.Location = new System.Drawing.Point(8, 20);
            this.itemTablePanel.Name = "itemTablePanel";
            this.itemTablePanel.RowCount = 2;
            this.itemTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTablePanel.Size = new System.Drawing.Size(200, 100);
            this.itemTablePanel.TabIndex = 2;
            // 
            // EditChildItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.headerLabel);
            this.flowPanel.Controls.Add(this.itemTablePanel);
            this.Controls.Add(this.flowPanel);
            this.Name = "EditChildItems";
            this.Size = new System.Drawing.Size(211, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TableLayoutPanel itemTablePanel;
        private FlowLayoutPanel flowPanel;
        //private TextBox headerTextfield;

    }
}
