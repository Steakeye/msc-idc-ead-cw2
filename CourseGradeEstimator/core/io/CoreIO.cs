using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.io
{
    public class CoreIO<D, F, S>
    {
        public CoreIO(string user) { }

        public virtual void loadData() {
            loadDataFromFile();
        }
        public virtual void loadDataFromFile() {

        }
        public virtual void loadDataFromDB() { }

        protected string userName;

        protected F fs;
        protected S db;
    }
}
