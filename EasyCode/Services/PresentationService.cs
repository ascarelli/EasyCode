using EasyCode.Entities;
using EasyCode.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace EasyCode.Services
{
    public class PresentationService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        
        private const string _PathTemplatePackConfig = @"Presentation\packages.config";
        private const string _PathTemplateGlobalAsax = @"Presentation\Global.asax.cs";
        private const string _PathTemplateController = @"Presentation\Controllers\Controller.cs";

        private const string _PathTemplateFilterConfig = @"Presentation\App_Start\FilterConfig.cs";
        private const string _PathTemplateSwaggerConfig = @"Presentation\App_Start\SwaggerConfig.cs";
        private const string _PathTemplateRouteConfig = @"Presentation\App_Start\RouteConfig.cs";
        private const string _PathTemplateWebConfig = @"Presentation\Web.config";

        public string ProjectName { get { return $"{_Project.NameSpace}.csproj"; } }
        public string ProjectPath { get { return $"{_GenerateCode.PathSolution}\\{_Project.NameSpace}\\"; } }

        public PresentationService()
        {
            
        }
        public PresentationService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public  void createPresentation(Dictionary<string, string> prReferences)
        {
            addReference(prReferences);
            createController();
            createConfig(_PathTemplateSwaggerConfig, "SwaggerConfig.cs");
            createConfig(_PathTemplateRouteConfig, "RouteConfig.cs");
            createConfig(_PathTemplateFilterConfig, "FilterConfig.cs");
            createglobalAsax();
            createWebConfig();
            _GenerateCodeService.createPackagesConfig(ProjectPath, base.PathTemplates + _PathTemplatePackConfig);
        }

        private void addReference(Dictionary<string, string> prReferences)
        {
            var textCsProj = File.ReadAllText(ProjectPath + ProjectName);
            var indexItemGroupProject = textCsProj.IndexOf("<ItemGroup>");
            var indexEndItemGroupProject = textCsProj.LastIndexOf("</ItemGroup>");
            var projDeclaration = textCsProj.Substring(indexItemGroupProject, ((indexEndItemGroupProject + "</ItemGroup>".Count()) - indexItemGroupProject));
            var slnMyDeclaration = projDeclaration;

            slnMyDeclaration += "\n <ItemGroup>" + "\n      [REFERENCES]" + "\n</ItemGroup>";
            slnMyDeclaration += "\n <ItemGroup>";
            slnMyDeclaration += "\n   <Compile Include=\"App_Start\\FilterConfig.cs\" />";
            slnMyDeclaration += "\n   <Compile Include=\"App_Start\\RouteConfig.cs\" />";
            slnMyDeclaration += "\n   <Compile Include=\"App_Start\\SwaggerConfig.cs\" />";
            slnMyDeclaration += $"\n   <Compile Include=\"Controllers\\{_Project.ProjectClasses[0].Name}Controller.cs\" />";
            slnMyDeclaration += "\n </ItemGroup>";
            slnMyDeclaration = _GenerateCodeService.createReferences(prReferences, slnMyDeclaration);

            var text = textCsProj.Replace(projDeclaration, slnMyDeclaration).Replace("<Compile Include=\"App_Start\\WebApiConfig.cs\" />", "");
            base.saveFile(ProjectPath, ProjectName, text);
        }

        private void createController()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateController);
            foreach (var projectClass in _Project.ProjectClasses)
            {
                text = base.replaceVariables(text);
                base.saveFile(ProjectPath + "\\Controllers", $"\\{projectClass.Name}Controller.cs", text);
            }   
        }
        private void createConfig(string prTemplate,string prConfigFile)
        {
            string text = File.ReadAllText(base.PathTemplates + prTemplate);
            text = base.replaceVariables(text);
            base.saveFile(ProjectPath + "\\App_Start", $"\\{prConfigFile}", text);
            base.deleteFile(ProjectPath + "\\App_Start\\WebApiConfig.cs");
        }
        private void createglobalAsax()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateGlobalAsax);
            text = base.replaceVariables(text);
            base.saveFile(ProjectPath, "\\Global.asax.cs", text);
        }

        private void createWebConfig()
        {
            string text = File.ReadAllText(base.PathTemplates + _PathTemplateWebConfig);
            text = base.replaceVariables(text);
            base.saveFile(ProjectPath, "\\Web.config", text);
        }
    }
}
