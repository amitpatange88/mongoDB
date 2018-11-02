using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    /// <summary>
    /// MongoDB runs on Native driver portNo 27017.
    /// </summary>
    public class MongoDB
    {
        private const string _ConnectionString = "mongodb://localhost:27017";
        private const string _DatabaseName = "mycustomers";
        private IMongoDatabase _db;

        public MongoDB()
        {
            _db = this.MongoDBConnect();
        }

        ~MongoDB()
        {
            //close the connection if required.
        }

        /// <summary>
        /// Create connection for database.
        /// </summary>
        /// <returns></returns>
        internal IMongoDatabase MongoDBConnect()
        {
            var client = new MongoClient(_ConnectionString);
            var db = client.GetDatabase(_DatabaseName);
            
            return db;
        }

        /// <summary>
        /// InsertOneAsync call.
        /// </summary>
        public async void InsertInCollection(string collectionName)
        {
            
            var coll = _db.GetCollection<BsonDocument>(collectionName);

            //remove this hard coded data in future.
            var doc = new BsonDocument
            {
                {"First_name", "John"},
                {"Last_name", "Keive"},
                {"Gender", "Male" }
            };

            await coll.InsertOneAsync(doc);
        }


        /// <summary>
        /// create a mongodb collection here.
        /// </summary>
        /// <param name="collectionName"></param>
        public void CreateCollectionOnMongo(string collectionName)
        {
            _db.CreateCollection(collectionName);
        }   
    }
}
