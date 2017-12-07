
using System.Text.RegularExpressions;

namespace CourseGradeEstimator.core.utils
{
    static class User
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
