using EasyCode.Entities;
using EasyCode.Framework;
using System.IO;
using System.Text;

namespace EasyCode.Services
{
    public class TOService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        private const string _PathTemplateResponse = @"TO\Response\Response.cs";
        private const string _PathTemplateResponseData = @"TO\Response\ResponseData.cs";

        private const string _PathTemplateRequest = @"TO\Request\Request.cs";
        private const string _PathTemplateRequestData = @"TO\Request\RequestData.cs";

        private const string _PathTemplatePackConfig = @"TO\packages.config";
        private const string _PathTemplateAssembly = @"TO\AssemblyInfo.cs";
        private const string _PathTemplateCsProj = @"TO\TO.csproj";
        private const string _PathResponse = @"\Response";
        private const string _PathRequest = @"\Request";
        private const string _ProjSuffix = ".TO";

        public string ProjectName { get { return _Project.NameSpace + _ProjSuffix; } }
        public string PathTemplateCsProj { get { return base.PathTemplates + _PathTemplateCsProj; } }
        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateAssembly { get { return base.PathTemplates + _PathTemplateAssembly; } }

        public TOService()
        {

        }
        public TOService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public string createTO()
        {
            var projectguid = createProject();
            createRequest();
            createRequestData();
            createReponse();
            createReponseData();

            return projectguid;
        }
        private string createProject()
        {
            return _GenerateCodeService.createProject(this.ProjectName, this.PathTemplateCsProj, this.PathTemplatePackConfig, this.PathTemplateAssembly);
        }

        private void createRequest()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateRequest);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathRequest, $"\\{projectClass.Name}Request.cs", text);
            }
        }
        private void createRequestData()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateRequestData);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = this.replaceVariables(text);
                var attrs = getAttrsTO(projectClass);
                text = text.Replace("[ATTRS]", attrs);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathRequest, $"\\{projectClass.Name}RequestData.cs", text);
            }
        }

        private void createReponse()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateResponse);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathResponse, $"\\{projectClass.Name}Response.cs", text);
            }
        }

        private void createReponseData()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateResponseData);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = this.replaceVariables(text);
                var attrs = getAttrsTO(projectClass);
                text = text.Replace("[ATTRS]", attrs);
                base.saveFile(_GenerateCode.PathSolution + ProjectName + _PathResponse, $"\\{projectClass.Name}ResponseData.cs", text);
            }
        }

        private string getAttrsTO(ProjectClass prProjectClass)
        {
            StringBuilder attrs = new StringBuilder();
            foreach (var attr in prProjectClass.Attributes)
            {
                string attrType = this.getAttr(attr);
                if (attr.Type == (int)ProjectAttribute.KDType.DateTime)
                    attrType = "string";
                    
                attrs.AppendLine($"public {attrType} {attr.Name} " + "{ get; set; }");
            }

            return attrs.ToString();
        }
    }
}
