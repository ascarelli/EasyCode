using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;

namespace EasyCode.Services
{
    public class ProxyService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateProxy = @"Proxy\Proxy.cs";
        private const string _PathTemplatePackConfig = @"Proxy\packages.config";
        private const string _PathTemplateAssembly = @"Proxy\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"Proxy\Proxy.csproj";
        private const string _ProjSuffix = ".Proxy";

        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public ProxyService()
        {

        }
        public ProxyService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createProxy(Dictionary<string, string> prReferences)
        {
            var projectguid = createProject(prReferences);
            createProxyEntity();
            return projectguid;
        }
        private string createProject(Dictionary<string, string> prReferences)
        {
            return _GenerateCodeService.createProject(this.ProjectName, this.PathTemplateCsProj, this.PathTemplatePackConfig, this.PathTemplateAssembly, prReferences);
        }

        private void createProxyEntity()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateProxy);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName, $"\\{projectClass.Name}Proxy.cs", text);
            }
        }
    }
}
