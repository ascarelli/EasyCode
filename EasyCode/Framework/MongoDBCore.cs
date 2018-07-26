using EasyCode.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace EasyCode.Framework
{
    public class MongoDBCore
    {
        private IMongoDatabase _MongoDatabase;
        public MongoDBCore()
        {
            _MongoDatabase = new MongoClient("mongodb://localhost").GetDatabase("local");
        }

        //public class MyContext
        //{
        //    public const string COLLECTION_NAME = "Project";

        //    private static readonly IMongoClient _client;
        //    private static readonly IMongoDatabase _database;

        //    static MyContext()
        //    {
        //        var connectionString = "mongodb://localhost";//ConfigurationManager.AppSettings["MongoDBConectionString"];
        //        _client = new MongoClient(connectionString);
        //        var databaseName = "local";//ConfigurationManager.AppSettings["MongoDBDatabaseName"];
        //        _database = _client.GetDatabase(databaseName);
        //    }

        //    public IMongoClient Client
        //    {
        //        get { return _client; }
        //    }

        //    public IMongoCollection<Projectx> DocumentType => _database.GetCollection<Projectx>(COLLECTION_NAME);
        //}

        public List<T> getAll<T>()
        {
            var collectionName = typeof(T).Name;
            IMongoCollection<T> collection = _MongoDatabase.GetCollection<T>(collectionName);
            List<T> documents = collection.Find(new BsonDocument()).ToList();
            return documents;
        }

        public MongoCollection<BsonDocument> create<T>(T prDocument)
        {
            var collectionName = typeof(T).Name;
            IMongoCollection<BsonDocument> mCollection = _MongoDatabase.GetCollection<BsonDocument>(collectionName);
            BsonDocument doc = prDocument.ToBsonDocument();

            Project teste = new Project { NameSpace = "x", ObjectType = 0 };
            mCollection.InsertOne(teste.ToBsonDocument());
            return null;
        }

    }
}
