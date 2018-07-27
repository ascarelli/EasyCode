using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Entities
{
    public class ProjectClass
    {
        public ProjectClass()
        {
            this.Attributes = new List<ProjectAttribute>();
            this.ObjectType = (int)ObjectTypeEnum.Class;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ObjectType { get; set; }
        public List<ProjectAttribute> Attributes { get; set; }
    }
}
