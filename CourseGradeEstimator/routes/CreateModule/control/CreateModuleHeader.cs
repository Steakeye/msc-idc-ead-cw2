using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.routes.CreateModule.control
{
    public partial class CreateModuleHeader : ModuleSummary.control.ModuleSummaryHeader
    {
        public CreateModuleHeader() : base()
        {
            InitializeComponent();
        }
        
        public string YearValue { get { return yearTextfield.Text; } set => yearTextfield.Text = value; }
        public string TitleValue { get { return headerTextfield.Text; } set => headerTextfield.Text = value; }
        public string CodeValue { get { return codeTextfield.Text; } set => codeTextfield.Text = value; }
        public string DescriptionValue { get { return descriptionTextfield.Text; } set => descriptionTextfield.Text = value; }
    }
}
