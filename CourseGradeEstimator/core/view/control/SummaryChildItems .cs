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
using System.Collections;
using CourseGradeEstimator.core.view.Summary;

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
            DataGridViewRowCollection rows = this.dataGrid.Rows;

            rows.Clear();

            foreach (string [] d in data)
            {
                rows.Add(d[0], d[1]);
                int idx = rows.GetLastRow(DataGridViewElementStates.None);
                rows[idx].Cells[2].Tag = d[2];
            }

        }

        public virtual void BindDelegates() { }

        public Hashtable EventBindings => eventBindings;

        public string Title { get { return headerLabel.Text; } set { headerLabel.Text = value; } }

        protected void FindFuncAndCall<A>(A eventKey, string code)
        {
            VoidDelegateWithArgs<string> cb = (VoidDelegateWithArgs<string>)eventBindings[eventKey];
            if (cb != null)
            {
                string[] args = new[] { code };
                Invoke(cb, args);
            }
        }

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
            //rows
            dataGrid.CellClick += new DataGridViewCellEventHandler(HandleViewButton);
        }

        private void HandleViewButton(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow targetRow = dataGrid.Rows[e.RowIndex];
            DataGridViewCell cell = targetRow.Cells[e.ColumnIndex];

            if (cell is DataGridViewButtonCell)
            {
                Console.WriteLine($"{cell.Value} {cell.Tag}");

                //SummaryViewBindings key = SummaryViewBindings.View;
                SummaryViewBindings key = (SummaryViewBindings)System.Enum.Parse(typeof(SummaryViewBindings), cell.Value as string);

                FindFuncAndCall(key, cell.Tag as string);
            }
        }

        protected Hashtable eventBindings = new Hashtable();

    }
}
