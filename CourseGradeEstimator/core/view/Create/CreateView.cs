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
            ////childItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            /*header.Dock = DockStyle.Fill;
            childItems.Dock = DockStyle.Fill;
            bottomButtonBar.Dock = DockStyle.Fill;*/
            header.Anchor = sides;
            childItems.Anchor = sides;
            bottomButtonBar.Anchor = sides;
            ResumeLayout(true);
        }
    }
}
