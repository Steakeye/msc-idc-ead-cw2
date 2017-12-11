using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.control
{
    partial class SummaryChildItems
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            //this.addBtn = new Button();
            this.layoutPanel.SuspendLayout();
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
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleColumn,
            this.descriptionColumn,
            this.viewColumn});
            this.dataGrid.Location = new System.Drawing.Point(3, 32);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.TabIndex = 2;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ReadOnly = true;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemTablePanel_CellContentClick);
            // 
            // flowPanel
            // 
            this.layoutPanel.Controls.Add(this.headerLabel);
            this.layoutPanel.Controls.Add(this.dataGrid);
            //this.layoutPanel.Controls.Add(this.addBtn);
            this.layoutPanel.Location = new System.Drawing.Point(0, 15);
            this.layoutPanel.Name = "flowPanel";
            this.layoutPanel.Size = new System.Drawing.Size(252, 300);
            this.layoutPanel.TabIndex = 0;
            // 
            // EditChildItems
            //
            this.Controls.Add(this.layoutPanel);
            this.Name = "EditChildItems";
            this.Margin = Config.Dimensions.GetStandardSidePadding();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            //this.Size = new System.Drawing.Size(252, 350); NO! this fails!
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGrid;
        private TableLayoutPanel layoutPanel;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private DataGridViewButtonColumn viewColumn;
        //private Button addBtn;

    }
}
