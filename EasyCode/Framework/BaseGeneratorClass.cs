using EasyCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Framework
{
    public class BaseGeneratorClass
    {
        protected string aNamespace;
        protected string aBoundedContext;
        protected string aNameEntity;
        protected string aSchema;
        protected List<ProjectAttribute> _Attrs;
        protected string aCodigo;

        public BaseGeneratorClass()
        {
            aNamespace = string.Empty;
            aBoundedContext = string.Empty;
            aNameEntity = string.Empty;
            aSchema = string.Empty;
            aCodigo = string.Empty;
        }
        protected void removeLast(string prstChar)
        {
            aCodigo = aCodigo.Substring(0, aCodigo.Length - 3);
        }
        protected void addLine(string prstLine)
        {
            aCodigo = aCodigo + prstLine + "\r\n";
        }
        protected void aplicarVariaveis()
        {
            aCodigo = aCodigo.Replace("[Namespace]", aNamespace);
            aCodigo = aCodigo.Replace("[BoundedContext]", aBoundedContext);
            aCodigo = aCodigo.Replace("[NameEntity]", aNameEntity);
            aCodigo = aCodigo.Replace("[NAMEENTITY]", aNameEntity.ToUpper());
            aCodigo = aCodigo.Replace("[nameentity]", aNameEntity.ToLower());
            aCodigo = aCodigo.Replace("[SCHEMA]", aSchema.ToUpper());
            aCodigo = aCodigo.Replace("[NAMEMODULE]", aNameEntity.ToUpper());
        }
        protected void gravarArquivo(string prLines, string prstPath, string prstNomeArquivo)
        {
            string lstDirectoryName = @"c:\plannerapps\gerador\DDD\" + prstPath;
            if (!System.IO.Directory.Exists(lstDirectoryName))
            {
                System.IO.Directory.CreateDirectory(lstDirectoryName);
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(lstDirectoryName + "\\" + prstNomeArquivo);
            file.WriteLine(prLines);
            file.Close();
        }
        protected string definirTipoDoAtributo(ProjectAttribute prAttr)
        {
            string lstTipoAtributo = "undefined";
            switch (prAttr.Type)
            {
                case (int)ProjectAttribute.KDType.String:
                    lstTipoAtributo = "string";
                    break;

                case (int)ProjectAttribute.KDType.Int:
                case (int)ProjectAttribute.KDType.Decimal:
                    lstTipoAtributo = "decimal" + (prAttr.Nullable == 1 ? "?" : "");
                    break;

                case (int)ProjectAttribute.KDType.DateTime:
                    lstTipoAtributo = "DateTime" + (prAttr.Nullable == 1 ? "?" : "");
                    break;
            }
            return lstTipoAtributo;
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
        //protected string definirDescricao(ProjectAttribute prAttr)
        //{
        //    return (prAttr.Type == (int)ProjectAttribute.KDType.DateTime ? "Description" : "");
        //}
        //protected double definirPorcentagem(int prQTD)
        //{
        //    return (90 / prQTD);
        //}
    }
}
