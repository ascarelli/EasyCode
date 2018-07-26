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
            this.Attributes = new List<Attribute>();
            this.ObjectType = (int)ObjectTypeEnum.Class;
        }
        public string Name { get; set; }
        public int ObjectType { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
