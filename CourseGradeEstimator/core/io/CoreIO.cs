using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.io
{
    public class CoreIO<D, F, S>
        where D : new()
        where F : FS<D>
    {
        public CoreIO(string user, F fsFacade) {
            userName = user;
            fs = fsFacade;
        }

        public CoreIO()
        {
        }

        public virtual D LoadData() {
            return loadDataFromFile();
        }
        public virtual D loadDataFromFile() {
            //return new D();
            return fs.LoadData(userName);
        }
        public virtual void loadDataFromDB() { }

        protected string userName;

        protected F fs;
        protected S db;
    }
}
