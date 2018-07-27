using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyCode.Entities;
using System.Collections.Generic;
using EasyCode.Framework;
using MongoDB.Bson;

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

        private void mockTreeView()
        {
            for (int i = 0; i < 1; i++)
            {
                Project project = new Project();
                project.NameSpace = "Prodesp.Gsnet.Framework.Extension " + i;

                ProjectClass projectClass = new ProjectClass();
                projectClass.Name = "ETL " + i;

                //ProjectAttribute attribute = new ProjectAttribute { Name = "Version " + i };
                //projectClass.Attributes.Add(attribute);

                //attribute = new ProjectAttribute { Name = "Project " + i };
                //projectClass.Attributes.Add(attribute);

                //attribute = new ProjectAttribute { Name = "Catalog " + i };
                //projectClass.Attributes.Add(attribute);

                project.ProjectClasses.Add(projectClass);
                _Projects.Add(project);
            }
        }
    }
}
