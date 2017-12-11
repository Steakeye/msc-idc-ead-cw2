using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.Summary
{
    public enum SummaryViewBindings
    {
        Edit,
        Delete,
        View,
        Back,
        Grade
    }
    public partial class SummaryView : View
    {
        public SummaryView() : base()
        {
            InitializeComponent();
            this.Text = $"{Properties.Resources.AppTitle} - Summary";
            setupView();
        }

        public override void BindDelegates()
        {
            backButton.Click += makeBinding(SummaryViewBindings.Back);
            //saveButton.Click += makeBinding(CreateViewBindings.Save);
        }

        public string ItemTitle { set { header.TitleValue = value; } }
        public string ItemCode { set { header.CodeValue = value; } }
        public string ItemDescription { set { header.DescriptionValue = value; } }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            header.Anchor = sides;
            bottomButtonBar.Anchor = allSides;

            addBottomButtons();

            fixLayout();

            ResumeLayout(true);
        }

        protected void fixLayout()
        {
            tablePanel.RowStyles.Clear();
            for (int i = 0; i < tablePanel.Controls.Count; i++)
            {
                RowStyle style;
                if (i == 1) //target the middle!
                {
                    style = new RowStyle(SizeType.Absolute, 250);
                }
                else
                {
                    style = new RowStyle(SizeType.AutoSize);
                }
                tablePanel.RowStyles.Add(style);
            }
        }

        protected void addBottomButtons()
        {
            //bottomButtonBar.AddButton(this.saveButton);
            bottomButtonBar.AddButton(this.backButton);
        }
    }
}
