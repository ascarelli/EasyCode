using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        public ObjectId _id { get; set; }
        public string NameSpace { get; set; }
        public int ObjectType { get; set; }
        public IList<ProjectClass> ProjectClasses { get; set; }
    }
}
