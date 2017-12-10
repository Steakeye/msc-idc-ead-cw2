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

namespace CourseGradeEstimator.core.view.interfaces
{

    public interface IHeader
    {
    }
    public interface IBottomButtonBar
    {
    }
    public interface Simple<H, B>
    {
        H header { get; set; }
        B bottomButtonBar { get; set; }
    }
    public interface Complex<H, B, C> : Simple<H, B>
    {

        string ItemTitle { get; set; }
        string ItemCode { get; set; }
        string ItemDescription { get; set; }
        C childItems{ get; set; }
        void SetChildItems(string[][] data);
    }
}
