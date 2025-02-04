﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeEstimator.core
{
    public static class Config
    {
        public static class Dimensions {

            public static Point GetStandardStartLocation()
            {
                return new Point(PaddingStd, PaddingMed);
            }
            public static Padding GetStandardSidePadding()
            {
                return new Padding(PaddingStd, 0, PaddingStd, 0);
            }

            public static int PaddingStd = 10;
            public static int PaddingMed = 15;
            public static int PaddingLrg = 25;

            public static int InputHeightStd = 30;
            public static int InputTextWidthStd = 300;
        }
    }
}
