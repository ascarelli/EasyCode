using EasyCode.Entities;
using EasyCode.Framework;

namespace EasyCode.Services
{
    public class PresentationService : BaseGeneratorClass
    {
        private readonly GenerateCodeService _GenerateCodeService;
        
        private const string _PathTemplatePackConfig = @"App\packages.config";
        private const string _PathTemplateGlobalAsax = @"App\Global.asax.cs";
        private const string _PathTemplateController = @"App\Controllers\Controller.cs";

        public string PathTemplatePackConfig { get { return base.PathTemplates + _PathTemplatePackConfig; } }
        public string PathTemplateGlobalAsax { get { return base.PathTemplates + _PathTemplateGlobalAsax; } }
        public string PathTemplateController { get { return base.PathTemplates + _PathTemplateController; } }

        public PresentationService()
        {

        }
        public PresentationService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GenerateCodeService = new GenerateCodeService(prProject, prGenerateCode);
        }

        public  void copyConfigurations()
        {
            _GenerateCodeService.createPackagesConfig(_GenerateCode.PathSolution + _Project.NameSpace, PathTemplatePackConfig);
        }

        private void createController()
        {

        }

        private void createRouteConfig()
        {


            
        }

        private void createFilterConfig()
        {


            
        }

        private void createglobalAsax()
        {



        }

        private void createWebConfig()
        {



        }
    }
}
