using EasyCode.Entities;
using System.IO;
using System.Text;

namespace EasyCode.Framework
{
    public class BaseGeneratorClass
    {
        //protected string _Namespace;
        //protected string _BoundedContext;
        //protected string _NameEntity;
        //protected string _Schema;
        //protected List<ProjectAttribute> _Attrs;
        //protected string _Codigo;

        protected Project _Project;
        protected GenerateCode _GenerateCode;


        //TODO:
        //public const string _PathTemplates = @"C:\WorkSpace\meusProjetos\EasyCode\Templates\";
        public const string _PathTemplates = @"C:\WorkSpace\meusProjetos\Easy Code\Templates\";

        public string PathTemplates { get { return _PathTemplates; } }

        public BaseGeneratorClass()
        {
          
        }

        protected void createPath(string prPath)
        {
            if (!Directory.Exists(prPath))
                Directory.CreateDirectory(prPath);
        }

        protected string replaceVariables(string prText)
        {
            prText = prText.Replace("[NAMESPACE]", string.IsNullOrWhiteSpace(_Project.NameSpace) ? "" : _Project.NameSpace);
            prText = prText.Replace("[ENTITY]", string.IsNullOrWhiteSpace(_GenerateCode.Entity) ? "" : _GenerateCode.Entity);
            prText = prText.Replace("[ENTITYUPPER]", string.IsNullOrWhiteSpace(_GenerateCode.Entity) ? "" : _GenerateCode.Entity.ToUpper());
            prText = prText.Replace("[entity]", string.IsNullOrWhiteSpace(_GenerateCode.Entity) ? "" : _GenerateCode.Entity.ToLower());

            //prText = prText.Replace("[BoundedContext]", _BoundedContext);
            //prText = prText.Replace("[SCHEMA]", string.IsNullOrWhiteSpace(_GenerateCode.PathSolution) ? "" : _GenerateCode.PathSolution);
            //prText = prText.Replace("[NAMEMODULE]", string.IsNullOrWhiteSpace(_GenerateCode.PathSolution) ? "" : _GenerateCode.PathSolution);
            //prText = prText.Replace("[DATABASE]", string.IsNullOrWhiteSpace(_GenerateCode.PathSolution) ? "" : _GenerateCode.PathSolution);
            //prText = prText.Replace("[CONNNAME]", string.IsNullOrWhiteSpace(_GenerateCode.PathSolution) ? "" : _GenerateCode.PathSolution);

            return prText;
        }
        protected void saveFile(string prPathFileFolder, string prFile, string prText)
        {
            createPath(prPathFileFolder);
            File.WriteAllText(prPathFileFolder + $"\\{prFile}", prText);
        }

        protected void deleteFile(string prPath)
        {
            if (File.Exists(prPath))
                File.Delete(prPath);
        }
        protected string definirComparacaoValidation(ProjectAttribute prAttr)
        {
            string lComparacao = "undefined";
            switch (prAttr.Type)
            {
                case (int)ProjectAttribute.KDType.String:
                    lComparacao = "string.IsNullOrWhiteSpace(pr[NameEntity]." + prAttr.Name.ToUpper() + ")";
                    break;

                case (int)ProjectAttribute.KDType.Int:
                case (int)ProjectAttribute.KDType.Decimal:
                    lComparacao = "pr[NameEntity]." + prAttr.Name.ToUpper() + " < 0";
                    break;

                case (int)ProjectAttribute.KDType.DateTime:
                    lComparacao = "pr[NameEntity]." + prAttr.Name.ToUpper() + "== null";
                    break;
            }
            return lComparacao;
        }
        public string getAttrs(ProjectClass prProjectClass)
        {
            StringBuilder attrs = new StringBuilder();
            foreach (var attr in prProjectClass.Attributes)
            {
                var attrType = this.getAttr(attr);
                attrs.AppendLine($"public {attrType} {attr.Name} " + "{ get; set; }");
            }

            return attrs.ToString();
        }
        protected string getAttr(ProjectAttribute prAttr)
        {
            string lstTipoAtributo = "undefined";
            switch (prAttr.Type)
            {
                case (int)ProjectAttribute.KDType.String:
                    lstTipoAtributo = "string";
                    break;
                case (int)ProjectAttribute.KDType.Int:
                    lstTipoAtributo = "int" + (prAttr.Nullable == 1 ? "?" : "");
                    break;
                case (int)ProjectAttribute.KDType.Decimal:
                    lstTipoAtributo = "decimal" + (prAttr.Nullable == 1 ? "?" : "");
                    break;
                case (int)ProjectAttribute.KDType.DateTime:
                    lstTipoAtributo = "DateTime" + (prAttr.Nullable == 1 ? "?" : "");
                    break;
            }
            return lstTipoAtributo;
        }
    }
}
