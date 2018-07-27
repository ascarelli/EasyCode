using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;

namespace EasyCode.Entities
{
    public enum KDObjectType
    {
        Project = 0,
        Class = 1,
        Attr = 2,
        ProjectHeader = 3
    }

    public class Project
    {
        public Project()
        {
            this.ProjectClasses = new List<ProjectClass>();
            this.ObjectType =(int)KDObjectType.Project;
        }


        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string NameSpace { get; set; }
        public int ObjectType { get; set; }

        [BsonElement("ProjectClass")]
        public IList<ProjectClass> ProjectClasses { get; set; }
    }
}
