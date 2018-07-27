using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Entities
{
    public enum ObjectTypeEnum
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
            this.ObjectType =(int)ObjectTypeEnum.Project;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NameSpace { get; set; }
        public int ObjectType { get; set; }
        public List<ProjectClass> ProjectClasses { get; set; }
    }
}
