﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using MongoDB.Bson;
using CourseGradeEstimator.core.utils;

namespace CourseGradeEstimator.core.io
{
    public class DB
    {
        public DB() {
            string dbName = Properties.Resources.AppDBName;
            string uri = String.Format(Properties.Resources.AppDBConnectionString, Properties.Resources.AppDBUser, WebUtility.UrlEncode(Properties.Resources.AppDBPass));

            client = new MongoClient(uri + dbName);
            db = client.GetDatabase(dbName);
            user = User.GetUserName();
        }


        public string LoadData(string resourceType)
        {
            string data = null;
            IMongoCollection<BsonDocument> dbCollection = getStore(resourceType);
            FilterDefinition<BsonDocument> userExists = getFilterForExistance();
            IFindFluent<BsonDocument, BsonDocument> existingData = dbCollection.Find(userExists);
            List<BsonDocument> dataFromDB = existingData.ToList();

            if (dataFromDB.Count > 0)
            {
                data = dataFromDB[0].ToJson();
            }

            return data;
        }

        public void SaveData(string resourceType, string data)
        {
            IMongoCollection<BsonDocument> dbCollection = getStore(resourceType);
            BsonDocument document = BsonDocument.Parse(data);

            dbCollection.ReplaceOne(getFilterForExistance(), document, new UpdateOptions { IsUpsert = true });
        }

        public void DeleteData(string resourceType)
        {
            IMongoCollection<BsonDocument> dbCollection = getStore(resourceType);
            //BsonDocument document = BsonDocument.Parse(data);

            dbCollection.DeleteOne(getFilterForExistance());
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

        protected FilterDefinition<BsonDocument>  getFilterForExistance() {
            return new BsonDocument("user", user);
        }
    }
}
