using System.Windows.Forms;
using System.Drawing;

namespace CourseGradeEstimator.routes.CreateModule.control
{
    public partial class CreateModuleHeader : ModuleSummary.control.ModuleSummaryHeader
    {
        public void InitializeComponent()
        {
            headerTextfield.ReadOnly = false;
            codeTextfield.ReadOnly = false;
            descriptionTextfield.ReadOnly = false;
            yearTextfield.ReadOnly = false;
        }
    }
}
