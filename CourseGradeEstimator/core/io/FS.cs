using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.core.io
{
    public class FS
    {
        public string LoadData(string path)
        {
            string data = null;

            IsolatedStorageFile isoStore = getStore();

            string filePath = getPath(path);

            if (isoStore.FileExists(filePath))
            {
                Console.WriteLine("File exists!");
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(filePath, FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        Console.WriteLine("Reading contents:");
                        data = reader.ReadToEnd();
                    }
                    isoStream.Close();
                }
            }

            return data;
        }

        public void SaveData(string path, string data)
        {
            IsolatedStorageFile isoStore = getStore();

            string filePath = getPath(path);

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(filePath, FileMode.Create, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    Console.WriteLine("Saving file to disk");
                    writer.WriteLine(data);
                }
                isoStream.Close();
            }
        }
        public void DeleteData(string path, string data)
        {
            IsolatedStorageFile isoStore = getStore();

            string filePath = getPath(path);

            if (isoStore.FileExists(path))
            {

                isoStore.DeleteFile(path);
            }
        }

        private IsolatedStorageFile getStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        }
        private string getPath(string file)
        {
            return Properties.Resources.AppName + "/" + file;
        }
    }
}
