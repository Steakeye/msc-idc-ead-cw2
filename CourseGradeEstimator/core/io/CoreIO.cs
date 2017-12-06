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

        protected virtual string LoadRawData()
        {
            string dbData = loadDataFromDB();
            return loadDataFromFile();
        }
        protected virtual string SaveRawData(string data)
        {
            //string dbData = loadDataFromDB();
            //return loadDataFromFile();
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
        protected virtual string saveDateToFile(string data)
        {
            return fs.SaveData(resourceType + fsExt);
        }
        protected virtual string saveDateToDB(string data)
        {
            return db.SaveData(resourceType);
        }

        protected string resourceType;

        protected F fs;
        protected S db;

        private static string fsExt = ".json";
    }
}
