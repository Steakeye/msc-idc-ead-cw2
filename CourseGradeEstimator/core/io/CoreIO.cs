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

        /*public static string SerializeData<D>(D data)
            where D : Item
        {
            return Item.GetJsonFromInstance(data);
            //return "";
        }*/

        public abstract D LoadData();
        public abstract void SaveData(D data);

        protected virtual string LoadRawData()
        {
            string dbData = loadDataFromDB();
            return loadDataFromFile();
        }
        protected virtual void SaveRawData(string data)
        {
            saveDateToFile(data);
            saveDateToDB(data);
        }
        protected virtual string loadDataFromFile()
        {
            return fs.LoadData(resourceType + fsExt);
        }
        protected virtual string loadDataFromDB()
        {
            return db.LoadData(resourceType);
        }
        protected virtual void saveDateToFile(string data)
        {
            fs.SaveData(resourceType + fsExt, data);
        }
        protected virtual void saveDateToDB(string data)
        {
            db.SaveData(resourceType, data);
        }

        protected string resourceType;

        protected F fs;
        protected S db;

        private static string fsExt = ".json";
    }
}
