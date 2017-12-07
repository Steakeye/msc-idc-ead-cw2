
using System.Text.RegularExpressions;

namespace CourseGradeEstimator.core.utils
{
    public enum ButtonSize {
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

            return new System.Drawing.Size(w, h); ;
        }

        private static string userName;
    }
}
