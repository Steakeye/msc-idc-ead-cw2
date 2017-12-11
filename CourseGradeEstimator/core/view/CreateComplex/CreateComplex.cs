using CourseGradeEstimator.core.view.Create;
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

namespace CourseGradeEstimator.core.view.CreateComplex
{

    public partial class CreateComplex: CreateView
    {
        public CreateComplex() : base()
        {
            InitializeComponent();
            setupView();
        }

        public void SetChildItems(string[][] data)
        {
            this.childItems.Populate(data);
        }

        public Hashtable ChildItemEventBindings => this.childItems.EventBindings;

        public override void BindDelegates()
        {
            base.BindDelegates();
            childItems.AddButton.Click += makeBinding(CreateViewBindings.Add);
        }

        protected void setupView()
        {
            AnchorStyles sides = AnchorStyles.Left | AnchorStyles.Right;
            AnchorStyles allSides = sides | AnchorStyles.Top | AnchorStyles.Bottom;
            childItems.Anchor = allSides;

            fixLayout();

            ResumeLayout(true);
        }

    }
}
