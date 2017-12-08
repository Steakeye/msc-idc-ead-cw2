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

        public void AddButton(Button button)
        {
            this.layoutPanel.Controls.Add(button);
        }
        public void RemoveButton(Button button)
        {
            this.layoutPanel.Controls.Remove(button);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            layoutPanel.MaximumSize = new Size(ClientSize.Width - (Config.Dimensions.PaddingStd * 2), 50);

            drawLine(e);
        }

        private void drawLine(PaintEventArgs e)
        {
            Color back = BackColor;
            Color dark = Color.FromArgb(back.R >> 1, back.G >> 1, back.B >> 1);
            int y = topMargin;
            int sideMargin = topMargin;
            using (var pen = new Pen(dark))
            {
                e.Graphics.DrawLine(pen, sideMargin, y, ClientSize.Width - sideMargin, y);
            }
            e.Graphics.DrawLine(Pens.White, sideMargin, y + 1, ClientSize.Width - sideMargin, y + 1);
        }
    }
}
