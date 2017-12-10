using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResourceStrings = CourseGradeEstimator.Properties.Resources;

namespace CourseGradeEstimator.core.view.control
{
    public partial class SummaryChildItems : UserControl
    {
        public SummaryChildItems()
        {
            InitializeComponent();
            setupComponent();
            setupInternalComponents();
            Load += new EventHandler(EditChildItems_Load);
        }

        public void Populate(string[][] data)
        {
            this.dataGrid.Rows.Clear();

            foreach (string [] d in data)
            {
                this.dataGrid.Rows.Add(d[0], d[1], Properties.Resources.StringsView);
            }

        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }
        //public Button AddButton => addBtn;

        private void itemTablePanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditChildItems_Load(object sender, EventArgs e)
        {
            //this.Width = Parent.Width;
            //this.Width = this.Parent.Height;
            //this.Dock = DockStyle.Fill;
        }

        private void setupComponent()
        {
        }
        private void setupInternalComponents()
        {
            layoutPanel.Size = new Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            setupDataGridView();
            //setupAddButton();
        }
        private void setupDataGridView()
        {
            //table
            dataGrid.Size = new Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            //dataGrid.Dock = DockStyle.Fill;
            //columns
            // 
            // titleColumn
            // 
            this.titleColumn.HeaderText = ResourceStrings.StringsTitle;
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ToolTipText = ResourceStrings.StringsTitle;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = ResourceStrings.StringsDescription;
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // viewColumn
            // 
            this.viewColumn.HeaderText = ResourceStrings.StringsView;
            this.viewColumn.Name = "viewColumn";
            this.viewColumn.Text = ResourceStrings.StringsView;
            this.viewColumn.UseColumnTextForButtonValue = true;
            //this.viewColumn.
            /*this.dataGrid.Text = "MyButton";
            this.dataGrid.UseColumnTextForButtonValue = true;*/
            //rows
            dataGrid.CellContentClick += new DataGridViewCellEventHandler(HandleViewButton);
        }

        private void HandleViewButton(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow targetRow = dataGrid.Rows[e.RowIndex];
            DataGridViewCell cell = targetRow.Cells[e.ColumnIndex];
            //DataGridView.
            if (cell is DataGridViewButtonCell)
            {
                /*Button btn = e.Control as Button;
                btn.Click -= new EventHandler(btn_Click);
                btn.Click += new EventHandler(btn_Click);*/
                /*if (cell.Value == ResourceStrings.StringsView)
                {

                }*/
            }
        }
        /*private void setupAddButton()
        {
            this.addBtn.Size = core.utils.View.GetButtonSize();
        }*/
    }
}
