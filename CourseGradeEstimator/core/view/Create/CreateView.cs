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
    public enum CreateViewBindings
    {
        Edit,
        Delete,
        Add,
        Save,
        Cancel
    }
    public partial class CreateView : View
    {
        public CreateView() : base()
        {
            InitializeComponent();
            this.Text = $"{Properties.Resources.AppTitle} - Create";
            setupView();
        }

        public override void BindDelegates()
        {
            childItems.AddButton.Click += makeBinding(CreateViewBindings.Add);
            cancelButton.Click += makeBinding(CreateViewBindings.Cancel);
            saveButton.Click += makeBinding(CreateViewBindings.Save);
        }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            header.Anchor = sides;
            childItems.Anchor = allSides;
            bottomButtonBar.Anchor = allSides;

            fixLayout();

            ResumeLayout(true);
        }

        protected void fixLayout()
        {
            tablePanel.RowStyles.Clear();
            //for (int i = 0; i < tablePanel.RowCount; i++)
            for (int i = 0; i < tablePanel.Controls.Count; i++)
            {
                RowStyle style;
                if (i == 1) //target the middle!
                {
                    //style = new RowStyle(SizeType.AutoSize, 300);
                    //style = new RowStyle(SizeType.AutoSize, 300);
                    style = new RowStyle(SizeType.Absolute, 250);
                }
                else
                {
                    style = new RowStyle(SizeType.AutoSize);
                }
                tablePanel.RowStyles.Add(style);
            }
        }
    }
}
