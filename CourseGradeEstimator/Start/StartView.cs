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

    //public partial class StartView : core.View<StartViewBindings>
    public partial class StartView : core.View
    {
        public StartView()
        {
            InitializeComponent();

            setupBindings();
        }

        private void setupBindings() {
           // eventEnum = StartViewBindings;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Action<object> callBack = eventBindings[StartViewBindings.Create];
            if ()
            {
                
            }*/

        }
    }
}
