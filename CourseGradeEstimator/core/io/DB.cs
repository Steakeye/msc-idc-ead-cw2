﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using MongoDB.Bson;
using System.Text.RegularExpressions;

namespace CourseGradeEstimator.core.io
{
    public class DB
    {
        public DB() {
            string dbName = Properties.Resources.AppDBName;
            string uri = String.Format(Properties.Resources.AppDBConnectionString, Properties.Resources.AppDBUser, WebUtility.UrlEncode(Properties.Resources.AppDBPass));

            client = new MongoClient(uri + dbName);
            db = client.GetDatabase(dbName);
            user = getUserName();
        }


        public string LoadData(string resourceType)
        {
            string data = null;

            IMongoCollection<BsonDocument> dbCollection = getStore(resourceType);

            saveData(resourceType, user, null);
            
            return data;
        }

        public void saveData(string resourceType, string user, char[] data)
        {
            IMongoCollection<BsonDocument> dbCollection = getStore(resourceType);

            BsonDocument course = new BsonDocument {
                { "title" , "test!" }
            };

            string jsonObj = "{ \"title\":\"test!\"}";

            dbCollection.InsertOne(course);
        }

        private IMongoCollection<BsonDocument> getStore(string collection)
        {
            return db.GetCollection<BsonDocument>(collection.ToLower());
        }

        private string getPath(string file)
        {
            return "path";
        }

        protected MongoClient client;
        protected IMongoDatabase db;
        protected string user;

        protected string getUserName()
        {
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Match userMatch = Regex.Match(name, @"\w+\\(\w+)");

            return userMatch.Groups[1].Value;
        }
    }
}
