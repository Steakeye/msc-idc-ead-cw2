using CourseGradeEstimator.core.view;
using CourseGradeEstimator.core.view.Summary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.ModuleSummary
{
    public partial class ModuleSummaryView : core.view.SummaryComplex.SummaryComplex
    {
        public ModuleSummaryView(): base()
        {
            InitializeComponent();
            string headerTitle = Properties.Resources.ViewCreateModuleHeader;
            this.Text = $"{Properties.Resources.AppTitle} {headerTitle} Summary";
            this.header.Title = headerTitle;
            this.childItems.Title = Properties.Resources.StringsAssessments;

            augmentGrid();
            //header.BackColor = Color.Orange;
            //childItems.BackColor = Color.Blue;

            //bottomButtonBar.BackColor = Color.Green;
            childItems.Width = Width;
            //tablePanel.BackColor = Color.LightBlue;
            //BackColor = Color.HotPink;
        }

        public string ItemTitle { set { header.TitleValue = value; } }
        public string ItemYear { set { header.YearValue = value; } }
        public string ItemCode { set { header.CodeValue = value; } }
        public string ItemDescription { set { header.DescriptionValue = value; } }

        private void augmentGrid()
        {
            DataGridView grid = this.childItems.Grid;

            grid.ReadOnly = false;

            DataGridViewColumnCollection cols = grid.Columns;

            IEnumerator colEnumer = cols.GetEnumerator();

            DataGridViewColumn col;

            while (colEnumer.MoveNext())
            {
                col = (DataGridViewColumn)colEnumer.Current;
                col.ReadOnly = true;
            }

            cols.Add(Properties.Resources.StringsGrade, Properties.Resources.StringsGrade);

            grid.CellLeave += new DataGridViewCellEventHandler(HandleGradeUpdate);
            grid.KeyUp += new KeyEventHandler(HandleGradeUpdateByKey);
        }

        private void HandleGradeUpdateByKey(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Enter!");
            DataGridView grid = this.childItems.Grid;
            DataGridViewCell currentCell = grid.CurrentCell;

            if (e.KeyCode == Keys.Enter && currentCell.OwningColumn.Name == Properties.Resources.StringsGrade) {
                Console.WriteLine("Enter and save!!");
                saveNewGrade(currentCell, currentCell.OwningRow.Cells[currentCell.ColumnIndex -1].Tag);
            }
        }
        private void HandleGradeUpdate(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = this.childItems.Grid;
            int cIdx = e.ColumnIndex;
            DataGridViewColumn targetColumn = grid.Columns[cIdx];

            Console.WriteLine("Time to update grade data!");

            if (targetColumn.Name == Properties.Resources.StringsGrade)
            {
                DataGridViewRow targetRow = grid.Rows[e.RowIndex];
                DataGridViewCell cell = targetRow.Cells[cIdx];
                DataGridViewCell cellWithCode = targetRow.Cells[cIdx -1];

                saveNewGrade(cell, cellWithCode.Tag);
            }
        }

        private void saveNewGrade(DataGridViewCell cell, object code)
        {
            Console.WriteLine($"value:{cell.EditedFormattedValue}, gradeCode: {code}");

            SummaryViewBindings key = (SummaryViewBindings)System.Enum.Parse(typeof(SummaryViewBindings), cell.OwningColumn.Name as string);

            FindFuncAndCall(key, code as string, cell.Value as string);
        }

        protected void FindFuncAndCall<A>(A eventKey, string code, string value)
        {
            VoidDelegateWithArgs<string[]> cb = (VoidDelegateWithArgs<string[]>)eventBindings[eventKey];
            if (cb != null)
            {
                string[] args = new[] { code, value };
                Invoke(cb, new[] { args });
            }
        }

    }
}
