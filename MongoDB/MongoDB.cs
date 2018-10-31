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
        private IMongoDatabase MongoDBConnect()
        {
            var client = new MongoClient(_ConnectionString);
            var db = client.GetDatabase(_DatabaseName);
            
            return db;
        }

        /// <summary>
        /// InsertOneAsync call.
        /// </summary>
        public async void InsertOneAsync()
        {
            
            var coll = _db.GetCollection<BsonDocument>("customers");
            var doc = new BsonDocument
            {
                {"first_name", "alex"},
                {"Ladt_name", "Koll"},
            };

            await coll.InsertOneAsync(doc);
        }
    }
}
