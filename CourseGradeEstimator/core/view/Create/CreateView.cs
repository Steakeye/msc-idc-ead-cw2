using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.Create
{
    public partial class CreateView : View
    {
        public CreateView() : base()
        {
            InitializeComponent();
            this.Text = $"{Properties.Resources.AppTitle} - Create";
            setupView();
        }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            header.Anchor = sides;
            childItems.Anchor = sides;
            bottomButtonBar.Anchor = sides;

            fixLayout();

            ResumeLayout(true);
        }

        protected void fixLayout()
        {
            tablePanel.RowStyles.Clear();
            for (int i = 0; i < tablePanel.RowCount; i++)
            {
                tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
    }
}
