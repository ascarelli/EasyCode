using EasyCode.Entities;
using EasyCode.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Services
{
    public class Application : BaseGeneratorClass
    {
        public Application()
        {
        }

        public void execute(string prstNamespace, string prstNomeClasse, List<ProjectAttribute> prAttrs)
        {
            _Namespace = prstNamespace;
            _Attrs = prAttrs;
            _NameEntity = prstNomeClasse;

            gerarApplication();
            
        }

        private void gerarApplication()
        {
            _Codigo = string.Empty;
            addLine("using [Namespace].Application.ViewModels;");
            addLine("using System.Collections.Generic;");
            addLine(string.Empty);
            addLine("namespace [Namespace].Application.Interface");
            addLine("{");
            addLine("    public interface I[NameEntity]AppService : IAppServiceBaseUoW");
            addLine("    {");
            addLine("       [NameEntity]ViewModel insert[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel);");
            addLine("       [NameEntity]ViewModel update[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel);");
            addLine("       [NameEntity]ViewModel remove[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel);");
            addLine("       [NameEntity]ViewModel getByID(decimal pr[NameEntity]ID);");
            addLine("       List<[NameEntity]ViewModel> getByFilter([NameEntity]ViewModel pr[NameEntity]ViewModel, int? skipresult, int? takeresult);");
            addLine("    }");
            addLine("}");
            aplicarVariaveis();
            gravarArquivo(_Codigo, "Application\\" + _NameEntity, "I" + _NameEntity + "AppService.cs");

            _Codigo = string.Empty;
            addLine("using [Namespace].Application.Interface;");
            addLine("using [Namespace].Domain.Entities;");
            addLine("using [Namespace].Domain.Interfaces.Services;");
            addLine("using [Namespace].Application.Services;");
            addLine("using [Namespace].Application.ViewModels;");
            addLine("using Validation.Domain.Validation;");
            addLine("using [Namespace].Domain.Validation;");
            addLine("using AutoMapper;");
            addLine("using System.Collections.Generic;");

            addLine(string.Empty);
            addLine("namespace [Namespace].Application");
            addLine("{");
            addLine("    public class [NameEntity]AppService : AppServiceBaseUoW, I[NameEntity]AppService");
            addLine("    {");
            addLine("        private readonly I[NameEntity]Service _[NameEntity]Service;");
            addLine(string.Empty);
            addLine("        public [NameEntity]AppService(I[NameEntity]Service prI[NameEntity]Service)");
            addLine("            : base()");
            addLine("        {");
            addLine("            _[NameEntity]Service = prI[NameEntity]Service;");
            addLine("        }");

            addLine(string.Empty);
            addLine("        public [NameEntity]ViewModel insert[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel)");
            addLine("        {");
            addLine("            [NameEntity] l[NameEntity] = Mapper.Map<[NameEntity]ViewModel, [NameEntity]>(pr[NameEntity]ViewModel);");
            addLine("            BeginTransaction();");
            addLine("            ValidationResult lValidationResult = _[NameEntity]Service.insert[NameEntity](l[NameEntity]);");
            addLine("            if (lValidationResult.IsValid)");
            addLine("            {");
            addLine("               Commit();");
            addLine("               pr[NameEntity]ViewModel." + _NameEntity.ToUpper() + "ID" + "= l[NameEntity]." + _NameEntity.ToUpper() + "ID;");
            addLine("            }");
            addLine(string.Empty);
            addLine("            pr[NameEntity]ViewModel.ValidationAppResult = DomainToApplicationResult(lValidationResult);");
            addLine(string.Empty);
            addLine("            return pr[NameEntity]ViewModel;");
            addLine("        }");


            addLine(string.Empty);
            addLine("        public [NameEntity]ViewModel update[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel)");
            addLine("        {");
            addLine("            [NameEntity] l[NameEntity] = Mapper.Map<[NameEntity]ViewModel, [NameEntity]>(pr[NameEntity]ViewModel);");
            addLine("            BeginTransaction();");
            addLine("            ValidationResult lValidationResult = _[NameEntity]Service.update[NameEntity](l[NameEntity]);");
            addLine("            if (lValidationResult.IsValid)");
            addLine("            {");
            addLine("               Commit();");
            addLine("            }");
            addLine(string.Empty);
            addLine("            pr[NameEntity]ViewModel.ValidationAppResult = DomainToApplicationResult(lValidationResult);");
            addLine(string.Empty);
            addLine("            return pr[NameEntity]ViewModel;");
            addLine("        }");


            addLine(string.Empty);
            addLine("        public [NameEntity]ViewModel remove[NameEntity]([NameEntity]ViewModel pr[NameEntity]ViewModel)");
            addLine("        {");
            addLine("            [NameEntity] l[NameEntity] = Mapper.Map<[NameEntity]ViewModel, [NameEntity]>(pr[NameEntity]ViewModel);");
            addLine("            BeginTransaction();");
            addLine("            ValidationResult lValidationResult = _[NameEntity]Service.remove[NameEntity](l[NameEntity]);");
            addLine("            if (lValidationResult.IsValid)");
            addLine("            {");
            addLine("               Commit();");
            addLine("            }");
            addLine(string.Empty);
            addLine("            pr[NameEntity]ViewModel.ValidationAppResult = DomainToApplicationResult(lValidationResult);");
            addLine(string.Empty);
            addLine("            return pr[NameEntity]ViewModel;");
            addLine("        }");

            addLine(string.Empty);

            addLine("        public [NameEntity]ViewModel getByID(decimal pr[NameEntity]ID)");
            addLine("        {");
            addLine("            [NameEntity] l[NameEntity] = _[NameEntity]Service.getByID(pr[NameEntity]ID);");
            addLine("            [NameEntity]ViewModel l[NameEntity]ViewModel = Mapper.Map<[NameEntity], [NameEntity]ViewModel>(l[NameEntity]);");
            addLine("            return l[NameEntity]ViewModel;");
            addLine("        }");

            addLine(string.Empty);
            addLine("        public List<[NameEntity]ViewModel> getByFilter([NameEntity]ViewModel pr[NameEntity]ViewModel, int? skipresult, int? takeresult)");
            addLine("        {");
            addLine("            [NameEntity] l[NameEntity] = Mapper.Map<[NameEntity]ViewModel, [NameEntity]>(pr[NameEntity]ViewModel);");
            addLine("            List<[NameEntity]> l[NameEntity]Collection = _[NameEntity]Service.getByFilter(l[NameEntity], skipresult, takeresult);");
            addLine("            List<[NameEntity]ViewModel> l[NameEntity]ViewModelCollection = l[NameEntity]Collection.ConvertAll(x => Mapper.Map<[NameEntity], [NameEntity]ViewModel>(x));");
            addLine(string.Empty);
            addLine("            return l[NameEntity]ViewModelCollection;");
            addLine("        }");

            addLine("    }");
            addLine("}");
            aplicarVariaveis();
            gravarArquivo(_Codigo, "Application\\" + _NameEntity, _NameEntity + "AppService.cs");
        }

      
    }
}
