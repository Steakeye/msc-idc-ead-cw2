using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.Start
{
    public enum StartViewBindings {
        Create
    }

    public partial class StartView : core.View
    {
        public StartView()
        {
            InitializeComponent();
        }

        public override void BindDelegates() {
            button1.Click += makeBinding(StartViewBindings.Create);
        }
    }
}
