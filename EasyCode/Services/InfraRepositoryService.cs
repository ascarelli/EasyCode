using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;

namespace EasyCode.Services
{
    public class InfraRepositoryService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateRepository = @"Repository\Repositories\Repository.cs";
        private const string _PathTemplatePackConfig = @"Repository\packages.config";
        private const string _PathTemplateAssembly = @"Repository\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"Repository\Repository.csproj";
        private const string _PathRepository = @"\Repositories";
        private const string _ProjSuffix = ".Infra.Data.Repository";

        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public InfraRepositoryService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createRepository(Dictionary<string, string> prReferences)
        {
            var projectguid = createProject(prReferences);
            createRepositories();
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

        private void createRepositories()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateRepository);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathRepository, $"\\{projectClass.Name}Repository.cs", text);
            }
        }
    }
}
