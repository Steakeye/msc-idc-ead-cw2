using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using MongoDB.Bson;

namespace CourseGradeEstimator.core.io
{
    public class DB
    {
        public DB() {
            //"mongodb://user:pass@host:port/db";
            string dbName = Properties.Resources.AppDBName;
            string uri = String.Format(Properties.Resources.AppDBConnectionString, Properties.Resources.AppDBUser, WebUtility.UrlEncode(Properties.Resources.AppDBPass));

            client = new MongoClient(uri + dbName);
            db = client.GetDatabase(dbName);
        }


        public string LoadData(string collection, string user)
        {
            string data = null;

            IMongoCollection<BsonDocument> dbCollection = db.GetCollection<BsonDocument>(collection.ToLower());
            /*string filePath = getPath(path);

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
            }*/

            //dbCollection.CountAsync<string>();
            BsonDocument course = new BsonDocument {
                { "title" , "test!" }
            };

            string jsonObj = "{ \"title\":\"test!\"}";

            dbCollection.InsertOne(course);

            db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

            return data;
        }

        public void saveData(string path, char[] data)
        {
            /*string filePath = getPath(path);

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("TestStore.txt", FileMode.CreateNew, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    //writer.Write("");
                    writer.WriteLine(data);
                    //Console.WriteLine("You have written to the file.");
                }
            }*/
        }
    
        private string getPath(string file)
        {
            return "path";
        }

        protected MongoClient client;
        protected IMongoDatabase db;
    }
}
