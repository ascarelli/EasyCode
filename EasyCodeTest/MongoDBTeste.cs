using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyCode.Entities;
using System.Collections.Generic;
using EasyCode.Framework;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EasyCodeTest
{
    [TestClass]
    public class MongoDBTeste
    {
        List<Project> _Projects = new List<Project>();
        private MongoDBCore _mDB;

        [TestMethod]
        public void insertProject_Class_Attribute()
        {
            _mDB = new MongoDBCore();
            mockTreeView();
            BsonDocument result = _mDB.add(_Projects[0]); 

            //foreach (var prj in _Projects)
            //{
            //    foreach (var cls in prj.ProjectClasses)
            //    {
            //        foreach (var attr in cls.Attributes)
            //            result = _mDB.add(attr);

            //        result = _mDB.add(cls);
            //    }

            //    result = _mDB.add(prj);
            //}

            Assert.AreEqual(true, result != null);
        }

        [TestMethod]
        public void updateProject_Class_Attribute()
        {
            _mDB = new MongoDBCore();
            var projets = _mDB.getAll<Project>();
            projets[0].NameSpace = "updated";
            var filter = Builders<Project>.Filter.Eq(s => s._id, projets[0]._id);
            var result = _mDB.update(filter, projets[0]);
            Assert.AreEqual(true, result != null);
        }

        [TestMethod]
        public void findProject_Class_Attribute()
        {
            _mDB = new MongoDBCore();
            mockTreeView();
            _Projects[0].ProjectClasses[0].ObjectType = 99;
            var filter = Builders<Project>.Filter.Eq(s => s.ProjectClasses, _Projects[0].ProjectClasses);
            var result = _mDB.find(filter);
            Assert.AreEqual(true, result != null);
        }

        [TestMethod]
        public void findClass()
        {
            _mDB = new MongoDBCore();
            mockTreeView();
            _Projects[0].ProjectClasses[0].ObjectType = 99;
            var filter = Builders<Project>.Filter.ElemMatch(x => x.ProjectClasses, x => x.ObjectType == _Projects[0].ProjectClasses[0].ObjectType);
            var result = _mDB.find(filter);
            Assert.AreEqual(true, result != null);
        }

        [TestMethod]
        public void addClassToProject()
        {
            _mDB = new MongoDBCore();
            var projets = _mDB.getAll<Project>();
            projets[0].ProjectClasses.Add(new ProjectClass { Name = "pussy" });
            var filter = Builders<Project>.Filter.Eq(s => s._id, projets[0]._id);
            var result = _mDB.update(filter, projets[0]);
            Assert.AreEqual(true, result != null);
        }

        private void mockTreeView()
        {
            for (int i = 0; i < 1; i++)
            {
                Project project = new Project();
                project.NameSpace = "Prodesp.Gsnet.Framework.Extensionxx " + i;

                ProjectClass projectClass = new ProjectClass();
                projectClass.Name = "ETL " + i;

                ProjectAttribute attribute = new ProjectAttribute { Name = "Version " + i };
                projectClass.Attributes.Add(attribute);

                attribute = new ProjectAttribute { Name = "Project " + i };
                projectClass.Attributes.Add(attribute);

                attribute = new ProjectAttribute { Name = "Catalog " + i };
                projectClass.Attributes.Add(attribute);

                project.ProjectClasses.Add(projectClass);
                _Projects.Add(project);
            }
        }
    }
}
