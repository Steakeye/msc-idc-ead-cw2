using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public CoreIO(string user, F fsFacade) {
            userName = user;
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
            return fs.LoadData(resourceType);
        }
        public virtual void loadDataFromDB() { }

        protected string userName;
        protected string resourceType;

        protected F fs;
        protected S db;
    }
}
