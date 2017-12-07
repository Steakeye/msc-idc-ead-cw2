using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.utils
{
    static class Utils
    {
        public static string GetUserName()
        {
            if (userName == null)
            {
                string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                Match userMatch = Regex.Match(name, @"\w+\\(\w+)");

                userName = userMatch.Groups[1].Value;

            }

            return userName;
        }

        private static string userName;
    }
}
