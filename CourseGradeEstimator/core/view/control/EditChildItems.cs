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
    public partial class EditChildItems : UserControl
    {
        public EditChildItems()
        {
            InitializeComponent();
            setupComponent();
            setupInternalComponents();
            Load += new EventHandler(EditChildItems_Load);
        }

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }
        public Button AddButton => addBtn;

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
            //layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Size = new Size(Config.Dimensions.InputTextWidthStd * 2, Config.Dimensions.InputHeightStd * 5);
            layoutPanel.BackColor = Color.MediumPurple;
            //layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            layoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            setupDataGridView();
            setupAddButton();
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
            // editColumn
            // 
            this.editColumn.HeaderText = ResourceStrings.StringsEdit;
            this.editColumn.Name = "editColumn";
            // deleteColumn
            this.deleteColumn.HeaderText = ResourceStrings.StringsDelete;
            this.deleteColumn.Name = "deleteColumn";
            //rows
        }

        private void setupAddButton()
        {
            this.addBtn.Size = core.utils.View.GetButtonSize();
        }
    }
}
