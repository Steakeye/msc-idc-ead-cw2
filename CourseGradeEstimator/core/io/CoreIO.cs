using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.io
{
    public interface IConcreteIO<D>
    {
        D LoadData();
    }

    abstract public class CoreIO<D, F, S>
        where F : FS
    {
        public CoreIO(F fsFacade) {
            fs = fsFacade;
        }

        public CoreIO()
        {
        }

        public abstract D LoadData();

        protected virtual string LoadRawData() {
            return loadDataFromFile();
        }
        public virtual string loadDataFromFile() {
            return fs.LoadData(resourceType + fsExt);
        }
        public virtual void loadDataFromDB() { }


        protected string getUserName()
        {
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Match userMatch = Regex.Match(name, @"\w+\\(\w+)");

            return userMatch.Groups[1].Value;
        }

        protected string userName;
        protected string resourceType;

        protected F fs;
        protected S db;

        private static string fsExt = ".json";
    }
}
