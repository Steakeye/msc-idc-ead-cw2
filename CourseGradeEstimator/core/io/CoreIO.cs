using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using CourseGradeEstimator.models;

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
        public abstract void SaveData(D data);
        public abstract void DeleteData();

        protected virtual string LoadRawData()
        {
            //TODO: load both and pick the newest
            string dbData = loadDataFromDB();
            return loadDataFromFile();
        }
        protected virtual void SaveRawData(string data)
        {
            saveDataToFile(data);
            saveDataToDB(data);
        }
        protected virtual void DeleteRawData()
        {
            deleteDataFromFile();
            deleteDataFromDB();
        }
        protected virtual string loadDataFromFile()
        {
            return fs.LoadData(resourceType + fsExt);
        }
        protected virtual string loadDataFromDB()
        {
            return db.LoadData(resourceType);
        }
        protected virtual void saveDataToFile(string data)
        {
            fs.SaveData(resourceType + fsExt, data);
        }
        protected virtual void saveDataToDB(string data)
        {
            db.SaveData(resourceType, data);
        }
        protected virtual void deleteDataFromFile()
        {
            fs.DeleteData(resourceType + fsExt);
        }
        protected virtual void deleteDataFromDB()
        {
            db.DeleteData(resourceType);
        }

        protected string resourceType;

        protected F fs;
        protected S db;

        private static string fsExt = ".json";
    }
}
