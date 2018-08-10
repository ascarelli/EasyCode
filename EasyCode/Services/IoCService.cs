using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyCode.Services
{
    public class IoCService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateAppModule = @"IoC\Modules\ApplicationModule.cs";
        private const string _PathTemplateRepoModule = @"IoC\Modules\RepositoryModule.cs";
        private const string _PathTemplateServiceModule = @"IoC\Modules\ServiceModule.cs";
        private const string _PathTemplateUnitOfWorkModule = @"IoC\Modules\UnitOfWorkModule.cs";
        private const string _PathTemplatePackConfig = @"IoC\packages.config";
        private const string _PathTemplateAssembly = @"IoC\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"IoC\IoC.csproj";
        private const string _ProjSuffix = ".CrossCutting.IoC";

        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public IoCService()
        {

        }
        public IoCService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createIoC(Dictionary<string, string> prReferences)
        {
            var projectguid = createProject(prReferences);
            createAppModule();
            createServiceModule();
            createRepoModule();
            createUnitOfWorkModule();
            return projectguid;
        }

        private string createProject(Dictionary<string, string> prReferences)
        {
            return _GenerateCodeService.createProject(this.ProjectName, this.PathTemplateCsProj, this.PathTemplatePackConfig, this.PathTemplateAssembly, prReferences);
        }

        private void createAppModule()
        {
            this.createModule("Application", _PathTemplateAppModule, "AppService");
        }

        private void createServiceModule()
        {
            this.createModule("Service", _PathTemplateServiceModule, "Service");
        }

        private void createRepoModule()
        {
            this.createModule("Repository", _PathTemplateRepoModule, "Repository");
        }

        private void createUnitOfWorkModule()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateUnitOfWorkModule);
            text = base.replaceVariables(text);
            base.saveFile(_GenerateCode.PathSolution + ProjectName + @"\Implementations", $"\\UnitOfWork.cs", text);
        }

        private void createModule(string prModule,string prTemplate,string prSuffix)
        {
            StringBuilder sbBind = new StringBuilder();

            foreach (var projectClass in _Project.ProjectClasses)
                sbBind.AppendLine($"Bind<I{projectClass.Name}{prSuffix}>().To<{projectClass.Name}{prSuffix}>();");

            string text = File.ReadAllText(base.PathTemplates + prTemplate);
            text = text.Replace("[ENTITYNAME]", _Project.ProjectClasses[0].Name).Replace("[NAMESPACE]", _Project.NameSpace + _ProjSuffix + ".Modules");
            text = text.Replace("[ENTITIES]", sbBind.ToString());

            base.saveFile(_GenerateCode.PathSolution + ProjectName, $"{_Project.ProjectClasses[0].Name}{prModule}.cs", text);
        }

        #region old
        //private void gerarSpecificationExist()
        //{
        //    _Codigo = string.Empty;
        //    addLine("using [Namespace].Domain.Entities;");
        //    addLine("using [Namespace].Domain.Interfaces.Services;");
        //    addLine("using Validation.Domain.Interfaces.Validation;");
        //    addLine("using [Namespace].Domain.Services;");
        //    addLine(string.Empty);
        //    addLine("namespace [Namespace].Domain.Specification");
        //    addLine("{");
        //    addLine("    public class [NameEntity]Exists : ISpecification<[NameEntity]>");
        //    addLine("    {");
        //    addLine("        private I[NameEntity]Service _[NameEntity]Service;");
        //    addLine("        public [NameEntity]Exists(I[NameEntity]Service pr[NameEntity]Service)");
        //    addLine("        {");
        //    addLine("            _[NameEntity]Service = pr[NameEntity]Service;");
        //    addLine("        }");
        //    addLine(string.Empty);

        //    addLine("        public bool IsSatisfiedBy([NameEntity] pr[NameEntity])");
        //    addLine("        {");
        //    addLine("            bool lboIsSatisfied = true;");
        //    addLine(string.Empty);
        //    addLine("            [NameEntity] l[NameEntity] = _[NameEntity]Service.getByID(pr[NameEntity]." + _NameEntity.ToUpper() + "ID);");
        //    addLine(string.Empty);

        //    addLine("            if (l[NameEntity] == null)");
        //    addLine("            {");
        //    addLine("              lboIsSatisfied = false;");
        //    addLine("            }");
        //    addLine(string.Empty);

        //    addLine("            return lboIsSatisfied;");
        //    addLine("        }");
        //    addLine("    }");
        //    addLine("}");
        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain\\Validation\\Specifiction", _NameEntity + "Exists" + ".cs");
        //}
        //private void gerarSpecificationHasProperties()
        //{
        //    _Codigo = string.Empty;
        //    addLine("using [Namespace].Domain.Entities;");
        //    addLine("using Validation.Domain.Interfaces.Validation;");
        //    addLine(string.Empty);
        //    addLine("namespace [Namespace].Domain.Specification");
        //    addLine("{");
        //    addLine("    public class [NameEntity]HasValidProperties : ISpecification<[NameEntity]>");
        //    addLine("    {");
        //    addLine("        public [NameEntity]HasValidProperties()");
        //    addLine("        {");
        //    addLine("        }");
        //    addLine(string.Empty);

        //    addLine("        public bool IsSatisfiedBy([NameEntity] pr[NameEntity])");
        //    addLine("        {");
        //    addLine("            bool lboIsSatisfied = true;");
        //    addLine(string.Empty);

        //    foreach (var attr in _Attrs)
        //    {

        //        if (attr.Nullable == (int)KDLogical.No)
        //        {
        //            addLine("            if (" + definirComparacaoValidation(attr) + ")");
        //            addLine("            {");
        //            addLine("              lboIsSatisfied = false;");
        //            addLine("            }");
        //            addLine(string.Empty);
        //        }
        //    }

        //    addLine("            return lboIsSatisfied;");
        //    addLine("        }");
        //    addLine("    }");
        //    addLine("}");
        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain\\Validation\\Specifiction", _NameEntity + "HasValidProperties" + ".cs");
        //}
        //private void gerarRepository()
        //{
        //    //Repository
        //    _Codigo = string.Empty;
        //    addLine("using System;");
        //    addLine("using [Namespace].Domain.Entities;");
        //    addLine("using System.Collections.Generic;");

        //    addLine(string.Empty);
        //    addLine("namespace [Namespace].Domain.Interfaces.Repositories");
        //    addLine("{");
        //    addLine("    public interface I[NameEntity]Repository : IRepositoryBaseUoW<[NameEntity]>");
        //    addLine("    {");
        //    addLine("       List<[NameEntity]> getByFilter([NameEntity] pr[NameEntity], int? skipresult, int? takeresult);");
        //    addLine("       [NameEntity] getByIDAsNoTracking(decimal pr[NameEntity]ID);");
        //    addLine("    }");
        //    addLine("}");
        //    addLine(string.Empty);
        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain", "I" + _NameEntity + "Repository.cs");
        //}
        //private void gerarEntity()
        //{
        //    _Codigo = string.Empty;

        //    //Entities
        //    addLine("namespace [Namespace].Domain.Entities");
        //    addLine("{");
        //    addLine("    public class [NameEntity]");
        //    addLine("    {");
        //    addLine("        public [NameEntity]()");
        //    addLine("        {");
        //    addLine("        }");
        //    addLine(string.Empty);

        //    addLine("        public decimal " + _NameEntity.ToUpper() + "ID { get; set; }");

        //    foreach (var lAtributo in _Attrs)
        //    {
        //        addLine("        public " + definirTipoDoAtributo(lAtributo) + " " + lAtributo.Name.ToUpper() + " { get; set; }");
        //    }

        //    addLine("    }");
        //    addLine("}");
        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain", _NameEntity + ".cs");
        //}
        //private void gerarService()
        //{


        //    //concrete
        //    _Codigo = string.Empty;
        //    addLine("using [Namespace].Domain.Entities;");
        //    addLine("using [Namespace].Domain.Interfaces.Repositories;");
        //    addLine("using [Namespace].Domain.Interfaces.Services;");
        //    addLine("using [Namespace].Domain.Validation;");
        //    addLine("using Validation.Domain.Validation;");
        //    addLine("using System.Collections.Generic;");

        //    addLine(string.Empty);

        //    addLine("namespace [Namespace].Domain.Services");
        //    addLine("{");
        //    addLine("    public class [NameEntity]Service : ServiceBaseUoW<[NameEntity]>, I[NameEntity]Service");
        //    addLine("    {");
        //    addLine("        private readonly I[NameEntity]Repository _[NameEntity]Repository;");
        //    addLine(string.Empty);
        //    addLine("        public [NameEntity]Service(I[NameEntity]Repository pr[NameEntity]Repository)");
        //    addLine("            : base(pr[NameEntity]Repository)");
        //    addLine("        {");
        //    addLine("            _[NameEntity]Repository = pr[NameEntity]Repository;");

        //    addLine("        }");

        //    addLine(string.Empty);
        //    addLine("        public ValidationResult insert[NameEntity]([NameEntity] pr[NameEntity])");
        //    addLine("        {");
        //    addLine("            var lValidate = new [NameEntity]ValidToInsert();");
        //    addLine(string.Empty);
        //    addLine("            ValidationResult lValidationResult = lValidate.Validar(pr[NameEntity]);");
        //    addLine("            if (lValidationResult.IsValid)");
        //    addLine("            {");
        //    addLine("               _[NameEntity]Repository.Add(pr[NameEntity]);");
        //    addLine("            }");
        //    addLine(string.Empty);
        //    addLine("            return lValidationResult;");
        //    addLine("        }");

        //    addLine(string.Empty);
        //    addLine("        public ValidationResult update[NameEntity]([NameEntity] pr[NameEntity])");
        //    addLine("        {");
        //    addLine("            var lValidate = new [NameEntity]ValidToUpdate(this);");
        //    addLine(string.Empty);
        //    addLine("            ValidationResult lValidationResult = lValidate.Validar(pr[NameEntity]);");
        //    addLine("            if (lValidationResult.IsValid)");
        //    addLine("            {");
        //    addLine("               _[NameEntity]Repository.Update(pr[NameEntity]);");
        //    addLine("            }");
        //    addLine(string.Empty);
        //    addLine("            return lValidationResult;");
        //    addLine("        }");


        //    addLine(string.Empty);
        //    addLine("        public ValidationResult remove[NameEntity]([NameEntity] pr[NameEntity])");
        //    addLine("        {");
        //    addLine("            var lValidate = new [NameEntity]ValidToDelete(this);");
        //    addLine(string.Empty);
        //    addLine("            ValidationResult lValidationResult = lValidate.Validar(pr[NameEntity]);");
        //    addLine("            if (lValidationResult.IsValid)");
        //    addLine("            {");
        //    addLine("               _[NameEntity]Repository.Remove(pr[NameEntity]);");
        //    addLine("            }");
        //    addLine(string.Empty);
        //    addLine("            return lValidationResult;");
        //    addLine("        }");

        //    addLine(string.Empty);
        //    addLine("        public [NameEntity] getByID(decimal pr[NameEntity]ID)");
        //    addLine("        {");
        //    addLine("            return _[NameEntity]Repository.getByIDAsNoTracking(pr[NameEntity]ID);");
        //    addLine("        }");

        //    addLine(string.Empty);
        //    addLine("        public List<[NameEntity]> getByFilter([NameEntity] pr[NameEntity], int? skipresult, int? takeresult)");
        //    addLine("        {");
        //    addLine("            return _[NameEntity]Repository.getByFilter(pr[NameEntity], skipresult, takeresult);");
        //    addLine("        }");
        //    addLine(string.Empty);

        //    addLine("    }");
        //    addLine("}");
        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain", _NameEntity + "Service.cs");
        //}
        //private void gerarServiceInterface()
        //{
        //    //Service 
        //    //interface
        //    _Codigo = string.Empty;
        //    addLine("using [Namespace].Domain.Entities;");
        //    addLine("using Validation.Domain.Validation;");
        //    addLine("using System.Collections.Generic;");

        //    addLine(string.Empty);

        //    addLine("namespace [Namespace].Domain.Interfaces.Services");
        //    addLine("{");
        //    addLine("   public interface I[NameEntity]Service : IServiceBaseUoW<[NameEntity]>");
        //    addLine("   {");
        //    addLine("       ValidationResult insert[NameEntity]([NameEntity] pr[NameEntity]);");
        //    addLine("       ValidationResult update[NameEntity]([NameEntity] pr[NameEntity]);");
        //    addLine("       ValidationResult remove[NameEntity]([NameEntity] pr[NameEntity]);");
        //    addLine("       [NameEntity] getByID(decimal pr[NameEntity]ID);");
        //    addLine("       List<[NameEntity]> getByFilter([NameEntity] pr[NameEntity], int? skipresult, int? takeresult);");
        //    addLine("   }");
        //    addLine("}");

        //    aplicarVariaveis();
        //    gravarArquivo(_Codigo, "Domain", "I" + _NameEntity + "Service.cs");
        //}
        #endregion
    }
}
