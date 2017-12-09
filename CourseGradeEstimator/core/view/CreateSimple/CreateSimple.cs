using CourseGradeEstimator.core.view.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.CreateSimple
{
    public enum CreateViewBindings
    {
        Edit,
        Delete,
        Add,
        Save,
        Cancel
    }
    public partial class CreateSimple : CreateView
    {
        public CreateSimple() : base()
        {
            InitializeComponent();
            setupView();
        }

        public override void BindDelegates()
        {
            cancelButton.Click += makeBinding(CreateViewBindings.Cancel);
            saveButton.Click += makeBinding(CreateViewBindings.Save);
        }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            header.Anchor = sides;
            //childItems.Anchor = allSides;
            bottomButtonBar.Anchor = allSides;

            addBottomButtons();

            fixLayout();

            ResumeLayout(true);
        }
    }
}
