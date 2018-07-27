using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;

namespace EasyCode.Entities
{
    public class ProjectClass
    {

        public ProjectClass()
        {
            //this.Attributes = new List<ProjectAttribute>();
            this.ObjectType = (int)KDObjectType.Class;
        }

     
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public int ObjectType { get; set; }
        //public List<ProjectAttribute> Attributes { get; set; }
    }
}
