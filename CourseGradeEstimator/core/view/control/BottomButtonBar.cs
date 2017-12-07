using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core.view.control
{
    public partial class BottomButtonBar : UserControl
    {
        public BottomButtonBar()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color back = BackColor;
            Color dark = Color.FromArgb(back.R >> 1, back.G >> 1, back.B >> 1);
            int y = 30;
            using (var pen = new Pen(dark))
            {
                e.Graphics.DrawLine(pen, 30, y, ClientSize.Width - 30, y);
            }
            e.Graphics.DrawLine(Pens.White, 30, y + 1, ClientSize.Width - 30, y + 1);
        }
    }
}
