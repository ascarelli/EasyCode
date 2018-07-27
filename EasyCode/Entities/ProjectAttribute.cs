using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace EasyCode.Entities
{
    public class ProjectAttribute
    {
        public enum KDType
        {
            String = 0,
            Int = 1,
            Decimal = 2,
            Double = 3,
            DateTime = 4
        }

        public ProjectAttribute()
        {
            this.ObjectType = (int)KDObjectType.Attr;
        }

        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Nullable { get; set; }
        public string PrecisionScale { get; set; }
        public string EnumDescription { get; set; }
        public int ObjectType { get; set; }
    }
}
