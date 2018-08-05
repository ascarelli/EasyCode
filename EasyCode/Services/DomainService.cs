using EasyCode.Entities;
using EasyCode.Framework;
using System.IO;

namespace EasyCode.Services
{
    public class DomainService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateEntity = @"Domain\Entities\Entity.cs";
        private const string _PathTemplateService = @"Domain\Services\Service.cs";
        private const string _PathTemplatePackConfig = @"Domain\packages.config";
        private const string _PathTemplateAssembly = @"Domain\AssemblyInfo.cs";
        private const string _PathTemplateIService = @"Domain\Interfaces\Domain\Services\IService.cs";
        private const string _PathTemplateIRepository= @"Domain\Interfaces\Infra\Data\Repository\IRepository.cs";
        private const string _PathTemplateIInteraction = @"Domain\Interfaces\Domain\Interactions\IInteraction.cs";
        private const string _PathTemplateCsProj = @"Domain\Domain.csproj";

        private const string _PathIInteraction = @"\Interfaces\Domain\Interactions\";
        private const string _PathIRepository = @"\Interfaces\Infra\Data\Repository\";
        private const string _PathIServices = @"\Interfaces\Domain\Services\";
        private const string _PathServices = @"\Services\";
        private const string _PathEntities = @"\Entities";
        

        private const string _ProjSuffix = ".Domain";

        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public DomainService()
        {

        }
        public DomainService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createDomain()
        {
            var projectguid = createDomainProject();
            createEntity();
            createService();
            createIService();
            createIRepository();
            createIInteraction();

            return projectguid;
        }
        private string createDomainProject()
        {
            return _GenerateCodeService.createProject(this.ProjectName,this.PathTemplateCsProj, this.PathTemplatePackConfig, this.PathTemplateAssembly);
        }

        private void createEntity()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateEntity);            
            foreach (var projectClass in _Project.ProjectClasses)
            {
                var textEntity = base.replaceVariables(text);
                var attrs = getAttrs(projectClass);
                textEntity = textEntity.Replace("[ATTRS]", attrs);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathEntities, $"\\{projectClass.Name}.cs", textEntity);
            }
        }

        private void createService()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateService);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathServices, $"{projectClass.Name}Service.cs", text);
            }
        }

        private void createIService()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateIService);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathIServices, $"I{projectClass.Name}Service.cs", text);
            }
        }

        private void createIRepository()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateIRepository);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathIRepository, $"I{projectClass.Name}Repository.cs", text);
            }
        }

        private void createIInteraction()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateIInteraction);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathIInteraction, $"I{projectClass.Name}Interaction.cs", text);
            }
        }
    }
}
