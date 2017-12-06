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
                }
            }

            return data;
        }

        public void saveData(string path, char[] data)
        {
            IsolatedStorageFile isoStore = getStore();

            string filePath = getPath(path);
            //using (var stream = new FileStream(path, FileMode.Truncate))
            //{
            //	using (var writer = new StreamWriter(stream))
            //	{
            //		writer.Write("data");
            //	}
            //}
            //            if (!isoStore.FileExists(filePath))
            //            {
            //using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(filePath, FileMode.CreateNew, isoStore))
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(filePath, FileMode.Create, isoStore))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        //writer.Write("");
                        writer.WriteLine(data);
                        //Console.WriteLine("You have written to the file.");
                    }
                }
//            }
        }

        private IsolatedStorageFile getStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        }
        private string getPath(string file)
        {
            return CourseGradeEstimator.Properties.Resources.AppName + "/" + file;
        }
    }
}
