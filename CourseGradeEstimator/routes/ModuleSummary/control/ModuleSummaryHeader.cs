using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.ModuleSummary.control
{
    public partial class ModuleSummaryHeader : core.view.control.SummaryHeader
    {
        public ModuleSummaryHeader()
        {
            InitializeComponent();
        }


        public string YearValue { set => yearTextfield.Text = value; }

    }
}
