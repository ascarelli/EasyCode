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
        protected string _Namespace;
        protected string _BoundedContext;
        protected string _NameEntity;
        protected string _Schema;
        protected List<ProjectAttribute> _Attrs;
        protected string _Codigo;

        public BaseGeneratorClass()
        {
            _Namespace = string.Empty;
            _BoundedContext = string.Empty;
            _NameEntity = string.Empty;
            _Schema = string.Empty;
            _Codigo = string.Empty;
        }
        protected void removeLast(string prstChar)
        {
            _Codigo = _Codigo.Substring(0, _Codigo.Length - 3);
        }
        protected void addLine(string prstLine)
        {
            _Codigo = _Codigo + prstLine + "\r\n";
        }
        protected void aplicarVariaveis()
        {
            _Codigo = _Codigo.Replace("[Namespace]", _Namespace);
            _Codigo = _Codigo.Replace("[BoundedContext]", _BoundedContext);
            _Codigo = _Codigo.Replace("[NameEntity]", _NameEntity);
            _Codigo = _Codigo.Replace("[NAMEENTITY]", _NameEntity.ToUpper());
            _Codigo = _Codigo.Replace("[nameentity]", _NameEntity.ToLower());
            _Codigo = _Codigo.Replace("[SCHEMA]", _Schema.ToUpper());
            _Codigo = _Codigo.Replace("[NAMEMODULE]", _NameEntity.ToUpper());
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
