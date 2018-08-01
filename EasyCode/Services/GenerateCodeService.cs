using EasyCode.Entities;
using EasyCode.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCode.Services
{
    public class GenerateCodeService : BaseGeneratorClass
    {
        public GenerateCodeService()
        {

        }

        public void createSolutionAndProjects()
        {
            string nameSpace = _Project.NameSpace;
            string guidToFolder = "2150E333-8FDC-42A3-9474-1A3956D46DE8";
            string guidToProject = "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC";
            string pathSolution = _PathSolution;
            string textSLN = File.ReadAllText(pathSolution + nameSpace + ".sln");
            var indexEndProject = textSLN.LastIndexOf("EndProject");


            #region Solution's Projects
            //Presentation
            string solutionProject = $"{nameSpace}\\{nameSpace}.csproj";
            var indexSolutionProject = textSLN.IndexOf(solutionProject);
            var guidProjPres = textSLN.Substring(indexSolutionProject, (indexEndProject - indexSolutionProject)).Replace(solutionProject, "").Replace("\"", "").Replace(",", "").Replace("{", "").Replace("}", "").Replace("\\", "").Trim();

            var indexProject = textSLN.IndexOf("Project");
            var projectDeclaration = textSLN.Substring(indexProject, ((indexEndProject + "EndProject".Count()) - indexProject));
            var projectMyDeclaration = projectDeclaration;

            //Domain
            var projNameDomain = "Prodesp.Gsnet.Distribuidor.WebAPI.Domain";
            var guidProjDomain = createProject(projNameDomain, pathSolution);
            projectMyDeclaration += "\nProject(\"{" + guidToProject + "}\") = \"" + projNameDomain + "\",\"" + projNameDomain + "\\" + projNameDomain + ".csproj" + "\", " + "\"{" + guidProjDomain + "}\"" + "\nEndProject";


            //Application

            //Infra

            //EF

            //Repository

            //IoC

            //TO

            //PROXY

            //var guidProjApp = createProject("Prodesp.Gsnet.Centro.WebAPI.Application", pathSolution);
            //var guidProjInfraEF = createProject("Prodesp.Gsnet.Centro.WebAPI.Infra.EF", pathSolution);
            //var guidProjInfraRepo = createProject("Prodesp.Gsnet.Centro.WebAPI.Infra.Repository", pathSolution);
            //var guidProjCrosIOC = createProject("Prodesp.Gsnet.Centro.WebAPI.CrossCutting.IoC", pathSolution);
            //var guidProjTO = createProject("Prodesp.Gsnet.Centro.Application.WebApi.TO", pathSolution);
            //var guidProjProxy = createProject("Prodesp.Gsnet.Centro.WebAPI.Proxy", pathSolution);
            #endregion

            #region Solution's Folders
            //01 - Presentation
            var guidFolderPres = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"01 - Presentation\", \"01 - Presentation\", " + "\"{" + guidFolderPres + "}\"" + "\nEndProject";
            //02 - Application
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"02 - Application\", \"02 - Application\", " + "\"{" + Guid.NewGuid().ToString().ToUpper() + "}\"" + "\nEndProject";
            //03 - Domain
            var guidFolderDomain = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"03 - Domain\", \"03 - Domain\", " + "\"{" + guidFolderDomain + "}\"" + "\nEndProject";
            //04 - Infrastructure
            var guidFolderInfra = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"04 - Infrastructure\", \"04 - Infrastructure\", " + "\"{" + guidFolderInfra + "}\"" + "\nEndProject";
            var guidFolderData = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"4.1 - Data\", \"4.1 - Data\", " + "\"{" + guidFolderData + "}\"" + "\nEndProject";
            var guidFolderRepository = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"4.1.1 - Repository\", \"4.1.1 - Repository\", " + "\"{" + guidFolderRepository + "}\"" + "\nEndProject";
            var guidFolderEF = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"4.1.0 - EF\", \"4.1.0 - EF\", " + "\"{" + guidFolderEF + "}\"" + "\nEndProject";
            //05 -CrossCutting
            var guidFolderCross = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"05 - CrossCutting\", \"05 - CrossCutting\", " + "\"{" + guidFolderCross + "}\"" + "\nEndProject";
            var guidFolderIOC = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"5.1 - IoC\", \"5.1 - IoC\", " + "\"{" + guidFolderIOC + "}\"" + "\nEndProject";
            var guidFolderTO = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"5.2 - TO\", \"5.2 - TO\", " + "\"{" + guidFolderTO + "}\"" + "\nEndProject";
            //06 - Commom
            projectMyDeclaration += "\nProject(\"{" + guidToFolder + "}\") = \"06 - Commom\", \"06 - Commom\", " + "\"{" + Guid.NewGuid().ToString().ToUpper() + "}\"" + "\nEndProject";

            textSLN = textSLN.Replace(projectDeclaration, projectMyDeclaration);

            #endregion

            #region Add projects to the folders
            var indexGlobalSelection = textSLN.IndexOf("GlobalSection");
            var indexEndGlobalSelection = textSLN.LastIndexOf("EndGlobalSection");
            var globalSectionDeclaration = textSLN.Substring(indexGlobalSelection, ((indexEndGlobalSelection + "EndGlobalSection".Count()) - indexGlobalSelection));
            var globalSectionMyDeclaration = globalSectionDeclaration;

            globalSectionMyDeclaration += "\n	GlobalSection(NestedProjects) = preSolution\n";
            globalSectionMyDeclaration += "		{" + guidProjPres + "} = {" + guidFolderPres + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderData + "} = {" + guidFolderInfra + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderRepository + "} = {" + guidFolderInfra + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderEF + "} = {" + guidFolderData + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderIOC + "} = {" + guidFolderCross + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderTO + "} = {" + guidFolderCross + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjDomain + "} = {" + guidFolderDomain + "}\n";
            globalSectionMyDeclaration += "	EndGlobalSection \n";

            textSLN = textSLN.Replace(globalSectionDeclaration, globalSectionMyDeclaration);
            #endregion

            File.WriteAllText(pathSolution + "\\Prodesp.Gsnet.Distribuidor.WebAPIx.sln", textSLN);
        }

        public string createProject(string prProjectName, string prPathSLN)
        {
            var csProjGuid = Guid.NewGuid().ToString().ToUpper();

            var pathProject = prPathSLN + prProjectName;

            if (!Directory.Exists(pathProject))
                Directory.CreateDirectory(pathProject);

            string pathTemplate = "";
            if (prProjectName.Contains("Domain"))
                pathTemplate = @"C:\WorkSpace\meusProjetos\EasyCode\Templates\Domain\Domain.csproj";

            string textCsProj = File.ReadAllText(pathTemplate);
            textCsProj = textCsProj.Replace("[PROJECTGUID]", csProjGuid).Replace("[NAMESPACE]", prProjectName).Replace("[ENTITY]", "Distribuidor");

            File.WriteAllText(pathProject + $"\\{prProjectName}.csproj", textCsProj);
            createPackagesConfig(pathProject);
            createAssemblyInfo(prProjectName, csProjGuid, pathProject);

            return csProjGuid;
        }

        public void createPackagesConfig(string prPathCsProj)
        {
            File.Copy(@"C:\WorkSpace\meusProjetos\EasyCode\Templates\Domain\packages.config", prPathCsProj + "\\packages.config", true);
        }

        public void createAssemblyInfo(string prNameSpace, string prProjectGuid, string prPathCsProj)
        {
            var pathAssembly = prPathCsProj + "\\Properties";
            if (!Directory.Exists(pathAssembly))
                Directory.CreateDirectory(pathAssembly);

            string textAssembly = File.ReadAllText(@"C:\WorkSpace\meusProjetos\EasyCode\Templates\Domain\AssemblyInfo.cs");
            textAssembly = textAssembly.Replace("[PROJECTGUID]", prProjectGuid).Replace("[NAMESPACE]", prNameSpace);
            //File.Copy(@"C:\WorkSpace\meusProjetos\EasyCode\Templates\Domain\AssemblyInfo.cs", pathAssembly + "\\AssemblyInfo.cs", true);
            File.WriteAllText(pathAssembly + "\\AssemblyInfo.cs", textAssembly);
        }

        public void executeDDD(Project prProject, string prPathSolution)
        {
            _Project = prProject;
            _PathSolution = prPathSolution;

            createSolutionAndProjects();
            createClasses();

            //_Namespace = prstNamespace;
            //_BoundedContext = string.Empty;
            //_NameEntity = prstNomeClasse;
            //_Attrs = prcoAtributos;
            //_Schema = prstSchema;
        }

        public void createClasses()
        {
            DomainService domainService = new DomainService();
            domainService.createDomain();
        }
    }
}
