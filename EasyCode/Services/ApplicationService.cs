using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;

namespace EasyCode.Services
{
    public class ApplicationService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateIApp = @"App\Interfaces\IAppService.cs";
        private const string _PathTemplateApp= @"App\Implementations\AppService.cs";
        private const string _PathTemplatePackConfig = @"App\packages.config";
        private const string _PathTemplateAssembly = @"App\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"App\App.csproj";

        public string ProjectName { get { return _Project.NameSpace + ".Application"; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public ApplicationService()
        {

        }
        public ApplicationService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createApp(Dictionary<string, string> prReferences)
        {
            var projectguid = createProject(prReferences);
            createInterface();
            createImplementation();
            return projectguid;
        }

        private string createProject(Dictionary<string, string> prReferences)
        {
            return _GenerateCodeService.createProject(this.ProjectName,
                                                      this.PathTemplateCsProj,
                                                      this.PathTemplatePackConfig,
                                                      this.PathTemplateAssembly,
                                                      prReferences);
        }

        private void createInterface()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateIApp);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + @"\Interfaces", $"\\I{projectClass.Name}AppService.cs", text);
            }
        }

        private void createImplementation()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateApp);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = text.Replace("[ENTITY]", projectClass.Name).Replace("[NAMESPACE]", _Project.NameSpace);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + @"\Implementations", $"\\{projectClass.Name}AppService.cs", text);
            }
        }
    }
}
