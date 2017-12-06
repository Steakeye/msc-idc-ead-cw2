﻿using System;
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
        where S : DB
    {
        public CoreIO(F fsFacade, S storeFacade) {
            fs = fsFacade;
            db = storeFacade;
        }

        public abstract D LoadData();

        protected virtual string LoadRawData() {
            string dbData = loadDataFromDB();
            return loadDataFromFile();
        }
        public virtual string loadDataFromFile() {
            return fs.LoadData(resourceType + fsExt);
        }
        public virtual string loadDataFromDB() {
            return db.LoadData(resourceType);
        }

        protected string resourceType;

        protected F fs;
        protected S db;

        private static string fsExt = ".json";
    }
}
