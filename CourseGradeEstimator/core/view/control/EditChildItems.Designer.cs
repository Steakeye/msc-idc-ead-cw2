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
            this.itemTablePanel = new System.Windows.Forms.DataGridView();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn(); 
             ((System.ComponentModel.ISupportInitialize)(this.itemTablePanel)).BeginInit();
            this.addBtn = new Button();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(0, 29);
            this.headerLabel.TabIndex = 1;
            // 
            // itemTablePanel
            // 
            this.itemTablePanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleColumn,
            this.descriptionColumn,
            this.editColumn,
            this.deleteColumn});
            this.itemTablePanel.Location = new System.Drawing.Point(3, 32);
            this.itemTablePanel.Name = "itemTablePanel";
            //this.itemTablePanel.Size = new System.Drawing.Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            this.itemTablePanel.TabIndex = 2;
            this.itemTablePanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemTablePanel_CellContentClick);
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.headerLabel);
            this.flowPanel.Controls.Add(this.itemTablePanel);
            this.flowPanel.Controls.Add(this.addBtn);
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(252, 100);
            this.flowPanel.TabIndex = 0;
            this.flowPanel.WrapContents = false;
            // 
            // EditChildItems
            //
            this.Controls.Add(this.flowPanel);
            this.Name = "EditChildItems";
            ((System.ComponentModel.ISupportInitialize)(this.itemTablePanel)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label headerLabel;
        private DataGridView itemTablePanel;
        private FlowLayoutPanel flowPanel;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private DataGridViewButtonColumn editColumn;
        private DataGridViewButtonColumn deleteColumn;
        private Button addBtn;

    }
}
