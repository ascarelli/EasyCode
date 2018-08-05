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
        private const string _PathTemplateIoC = @"IoC\IoC.cs";
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
            createModule("Service", _PathTemplateServiceModule, "Service");
            createModule("Service", _PathTemplateServiceModule, "Service");
            createModule("Repository", _PathTemplateRepoModule, "Repository");
            createUnitOfWorkModule();
            createIoCModules();
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

        private void createUnitOfWorkModule()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateUnitOfWorkModule);
            text = base.replaceVariables(text);
            base.saveFile(_GenerateCode.PathSolution + ProjectName + @"\Modules", $"\\UnitOfWorkModule.cs", text);
        }

        private void createModule(string prModule,string prTemplate,string prSuffix)
        {
            StringBuilder sbBind = new StringBuilder();

            foreach (var projectClass in _Project.ProjectClasses)
                sbBind.AppendLine($"Bind<I{projectClass.Name}{prSuffix}>().To<{projectClass.Name}{prSuffix}>();");

            string text = File.ReadAllText(base.PathTemplates + prTemplate);
            text = replaceVariables(text);
            text = text.Replace("[ENTITIES]", sbBind.ToString());

            base.saveFile(_GenerateCode.PathSolution + ProjectName + "\\Modules", $"Api{_Project.ProjectClasses[0].Name}{prModule}Module.cs", text);
        }

        private void createIoCModules()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateIoC);
            text = base.replaceVariables(text);
            base.saveFile(_GenerateCode.PathSolution + ProjectName, "IoC.cs", text);
        }
    }
}
