using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EasyCode.Entities.Project;

namespace EasyCode.Entities
{
    public class ProjectAttribute
    {
        public ProjectAttribute()
        {
            this.ObjectType = (int)ObjectTypeEnum.Attr;
        }
        public string Name { get; set; }
        public int ObjectType { get; set; }
    }
}
