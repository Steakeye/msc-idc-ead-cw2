﻿
using System.Text.RegularExpressions;

namespace CourseGradeEstimator.core.utils
{
    enum ButtonSize {
        Standard
    }
    static class View
    {
        public static System.Drawing.Size GetButtonSize(ButtonSize size = ButtonSize.Standard)
        {
            int w = 0, h = 0;

            switch(size) {
                case ButtonSize.Standard:
                    {
                        w = 124;
                        h = 32;
                    }
                    break;
            }
            if (userName == null)
            {
                string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                Match userMatch = Regex.Match(name, @"\w+\\(\w+)");

                userName = userMatch.Groups[1].Value;

            }

            return new System.Drawing.Size(w, h); ;
        }

        private static string userName;
    }
}
