using MongoDB.Bson;
using System.Collections.Generic;

namespace EasyCode.Entities
{
    public enum KDObjectType
    {
        ProjectHeader = 0,
        Project = 1,
        Class = 2,
        Attr = 3
    }

    public class Project
    {
        public Project()
        {
            this.ProjectClasses = new List<ProjectClass>();
            this.ObjectType =(int)KDObjectType.Project;
        }
        public ObjectId _id { get; set; }
        public string NameSpace { get; set; }
        public int ObjectType { get; set; }
        public IList<ProjectClass> ProjectClasses { get; set; }
    }
}
