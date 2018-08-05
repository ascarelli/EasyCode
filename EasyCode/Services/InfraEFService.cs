using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyCode.Services
{
    public class InfraEFService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateConfig = @"EF\Configurations\Configuration.cs";
        private const string _PathTemplateUnitOfWork = @"EF\Implementations\UnitOfWork.cs";
        private const string _PathTemplateContexto = @"EF\Contexto.cs";
        private const string _PathTemplatePackConfig = @"EF\packages.config";
        private const string _PathTemplateAssembly = @"EF\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"EF\EF.csproj";
        private const string _PathConfig = @"\Configurations";
        private const string _PathUnitOfWork = @"\Implementations";
         
        private const string _ProjSuffix = ".Infra.Data.EF";
        
        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public InfraEFService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createEF(Dictionary<string, string> prReferences)
        {
            var projectguid = createProject(prReferences);
            createConfigurations();
            createImplementations();
            createContext();
            return projectguid;
        }

        private string createProject(Dictionary<string, string> prReferences)
        {
            return _GenerateCodeService.createProject(this.ProjectName, this.PathTemplateCsProj, this.PathTemplatePackConfig, this.PathTemplateAssembly, prReferences);
        }

        private void createContext()
        {
            StringBuilder sbConfig = new StringBuilder();
            StringBuilder sbDbset = new StringBuilder();

            foreach (var projectClass in _Project.ProjectClasses)
            {
                sbConfig.AppendLine($"modelBuilder.Configurations.Add(new {projectClass.Name}Configuration());");
                sbDbset.AppendLine($"public virtual DbSet<{projectClass.Name}> {projectClass.Name}" + "{ get; set; }");
            }

            string text = File.ReadAllText(base.PathTemplates + _PathTemplateContexto);
            //TODO: TEM QUE TER NO NOME DA ENTITYNAME DEFAULT
            text = this.replaceVariables(text);
            text = text.Replace("[ENTITIESCONFIGURATION]", sbConfig.ToString());
            text = text.Replace("[ENTITIES]", sbDbset.ToString());

            base.saveFile(_GenerateCode.PathSolution + ProjectName, "Contexto.cs", text);
        }

        private void createConfigurations()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateConfig);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                StringBuilder sbAttrs = new StringBuilder();
                foreach (var item in projectClass.Attributes)
                    sbAttrs.AppendLine($"Property(x => x.{item.Name}).HasColumnName(\"{ projectClass.Name}\");");

                text = this.replaceVariables(text);
                text = text.Replace("[ATTRS]", sbAttrs.ToString());
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathConfig, $"\\{projectClass.Name}Configuration.cs", text);
            }
        }

        private void createImplementations()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateUnitOfWork);
            text = base.replaceVariables(text);
            base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathUnitOfWork, "\\UnitOfWork.cs", text);
        }
    }
}
