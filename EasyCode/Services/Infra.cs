using EasyCode.Entities;
using EasyCode.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Services
{
    public class Infra : BaseGeneratorClass
    {

        public Infra()
        {
        }

        private void gerarInfra()
        {
            _Codigo = string.Empty;
            addLine("using System.Data.Entity.ModelConfiguration;");
            addLine("using [Namespace].Domain.Entities;");
            addLine("using System.ComponentModel.DataAnnotations;");
            addLine(string.Empty);
            addLine("namespace [Namespace].Infra.Data.EntityConfig");
            addLine("{");
            addLine("    public class [NameEntity]Configuration : EntityTypeConfiguration<[NameEntity]>");
            addLine("    {");
            addLine("        public [NameEntity]Configuration()");
            addLine("        {");
            addLine("            ToTable(\"[NAMEENTITY]\", \"[SCHEMA]\");");
            addLine("            HasKey(c => c.[NAMEENTITY]ID);");
            addLine("            Property(c => c.[NAMEENTITY]ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);");
            addLine("        }");
            addLine("    }");
            addLine("}");

            aplicarVariaveis();
            gravarArquivo(_Codigo, "Infra\\EntityConfig", _NameEntity + "Configuration.cs");

            _Codigo = string.Empty;
            addLine("using System;");
            addLine("using System.Collections.Generic;");
            addLine("using System.Linq;");
            addLine("using System.Text;");
            addLine("using [Namespace].Domain.Interfaces.Repositories;");
            addLine("using [Namespace].Domain.Entities;");
            addLine(string.Empty);
            addLine("namespace [Namespace].Infra.Data.Repositories");
            addLine("{");
            addLine("    public class [NameEntity]Repository : RepositoryBaseUoW<[NameEntity]>, I[NameEntity]Repository");
            addLine("    {");
            addLine(string.Empty);
            addLine("       public List<[NameEntity]> getByFilter([NameEntity] pr[NameEntity], int? skipresult, int? takeresult)");
            addLine("       {");
            addLine("           var linq = from linqEnt in Db.Set<[NameEntity]>()");
            addLine("                      select linqEnt;");
            addLine("                      //your filter here");
            addLine(string.Empty);
            addLine("           return new List<[NameEntity]>(linq.OrderBy(x => x.[NAMEENTITY]ID).Skip((int)skipresult).Take((int)takeresult).ToList());");
            addLine("       }");

            addLine(string.Empty);
            addLine("       public [NameEntity] getByIDAsNoTracking(decimal pr[NameEntity]ID)");
            addLine("       {");
            addLine("           var linq = Db.Set<[NameEntity]>()");
            addLine("                      .AsNoTracking()");
            addLine("                      .Select(x => x)");
            addLine("                      .Where(x => x.[NAMEENTITY]ID == pr[NameEntity]ID);");
            addLine(string.Empty);
            addLine("           return linq.FirstOrDefault();");
            addLine("       }");
            addLine("    }");
            addLine("}");
            aplicarVariaveis();
            gravarArquivo(_Codigo, "Infra\\Repositories", _NameEntity + "Repository.cs");
        }

        public void execute(string prstNamespace, string prstEntityName, List<ProjectAttribute> prAttrs, string prSchema)
        {
            _Namespace = prstNamespace;
            _NameEntity = prstEntityName;
            _Attrs = prAttrs;
            _Schema = prSchema;

            gerarInfra();
        }
    }
}
