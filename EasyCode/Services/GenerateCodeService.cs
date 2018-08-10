using EasyCode.Entities;
using EasyCode.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EasyCode.Services
{
    public class GenerateCodeService : BaseGeneratorClass
    {
        private readonly string _GuidToFolder;
        private readonly string _GuidToProject;
        private string _TextSL;
        private readonly int _IndexEndProject;
      

        public GenerateCodeService(Project prProject, GenerateCode prGenerateCode)
        {
            _Project = prProject;
            _GenerateCode = prGenerateCode;
            _GuidToFolder = "2150E333-8FDC-42A3-9474-1A3956D46DE8";
            _GuidToProject = "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC";
            _TextSL = File.ReadAllText(_GenerateCode.PathSolution + _Project.NameSpace + ".sln");
            _IndexEndProject = _TextSL.LastIndexOf("EndProject");
        }

        public void executeDDD()
        {
            #region Solution's Projects
            //Presentation
            string solutionProject = $"{_Project.NameSpace}\\{_Project.NameSpace}.csproj";
            var indexSolutionProject = _TextSL.IndexOf(solutionProject);
            var guidProjPres = _TextSL.Substring(indexSolutionProject, (_IndexEndProject - indexSolutionProject)).Replace(solutionProject, "").Replace("\"", "").Replace(",", "").Replace("{", "").Replace("}", "").Replace("\\", "").Trim();

            var indexProject = _TextSL.IndexOf("Project");
            var projectDeclaration = _TextSL.Substring(indexProject, ((_IndexEndProject + "EndProject".Count()) - indexProject));
            var projectMyDeclaration = projectDeclaration;

            PresentationService presentationService = new PresentationService(_Project,_GenerateCode);
            presentationService.createPresentation();

            //Domain
            DomainService domainService = new DomainService(_Project, _GenerateCode);
            var guidProjDomain = domainService.createDomain();
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + domainService.ProjectName + "\", \"" +
                                                      domainService.ProjectName + "\\" + domainService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjDomain + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //EF
            InfraEFService infraEFService = new InfraEFService(_Project, _GenerateCode);
            Dictionary<string, string> _References = new Dictionary<string, string>();
            _References.Add(guidProjDomain, domainService.ProjectName);
            var guidProjInfraEF = infraEFService.createEF(_References);
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + infraEFService.ProjectName + "\", \"" +
                                                      infraEFService.ProjectName + "\\" + infraEFService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjInfraEF + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //Repository
            InfraRepositoryService infraRepositoryService = new InfraRepositoryService(_Project, _GenerateCode);
            _References = new Dictionary<string, string>();
            _References.Add(guidProjDomain, domainService.ProjectName);
            _References.Add(guidProjInfraEF, infraEFService.ProjectName);
            var guidProjInfraRepo = infraRepositoryService.createRepository(_References);
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + infraRepositoryService.ProjectName + "\", \"" +
                                                      infraRepositoryService.ProjectName + "\\" + infraRepositoryService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjInfraRepo + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //TO
            TOService toService = new TOService(_Project, _GenerateCode);
            var guidProjTO = toService.createTO();
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + toService.ProjectName + "\", \"" +
                                                      toService.ProjectName + "\\" + toService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjTO + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //PROXY
            ProxyService proxyService = new ProxyService(_Project, _GenerateCode);
            _References = new Dictionary<string, string>();
            _References.Add(guidProjTO, toService.ProjectName);
            var guidProjProxy = proxyService.createProxy(_References);
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + proxyService.ProjectName + "\", \"" +
                                                      proxyService.ProjectName + "\\" + proxyService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjProxy + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //Application
            ApplicationService appService = new ApplicationService(_Project, _GenerateCode);
            _References = new Dictionary<string, string>();
            _References.Add(guidProjTO, toService.ProjectName);
            _References.Add(guidProjDomain, domainService.ProjectName);
            var guidProjApp = appService.createApp(_References);
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + appService.ProjectName + "\", \"" +
                                                      appService.ProjectName + "\\" + appService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjApp + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            //IoC
            IoCService iocService = new IoCService(_Project, _GenerateCode);
            _References = new Dictionary<string, string>();
            _References.Add(guidProjDomain, domainService.ProjectName);
            _References.Add(guidProjApp, appService.ProjectName);
            _References.Add(guidProjInfraEF, infraEFService.ProjectName);
            _References.Add(guidProjInfraRepo, infraRepositoryService.ProjectName);
            var guidProjCrosIOC = iocService.createIoC(_References);
            projectMyDeclaration += "\nProject(\"{" + _GuidToProject + "}\") = \"" + iocService.ProjectName + "\", \"" +
                                                      iocService.ProjectName + "\\" + iocService.ProjectName + ".csproj" + "\", " + "\"{" +
                                                      guidProjCrosIOC + "}\"" + "\nEndProject";  //TODO: USAR TEMPLATE TXT

            #endregion

            #region Solution's Folders
            //01 - Presentation
            var guidFolderPres = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"01 - Presentation\", \"01 - Presentation\", " + "\"{" + guidFolderPres + "}\"" + "\nEndProject";
            //02 - Application
            var guidFolderApp = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"02 - Application\", \"02 - Application\", " + "\"{" + guidFolderApp + "}\"" + "\nEndProject";
            //03 - Domain
            var guidFolderDomain = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"03 - Domain\", \"03 - Domain\", " + "\"{" + guidFolderDomain + "}\"" + "\nEndProject";
            //04 - Infrastructure
            var guidFolderInfra = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"04 - Infrastructure\", \"04 - Infrastructure\", " + "\"{" + guidFolderInfra + "}\"" + "\nEndProject";
            var guidFolderData = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"4.1 - Data\", \"4.1 - Data\", " + "\"{" + guidFolderData + "}\"" + "\nEndProject";
            var guidFolderRepository = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"4.1.1 - Repository\", \"4.1.1 - Repository\", " + "\"{" + guidFolderRepository + "}\"" + "\nEndProject";
            var guidFolderEF = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"4.1.0 - EF\", \"4.1.0 - EF\", " + "\"{" + guidFolderEF + "}\"" + "\nEndProject";
            //05 -CrossCutting
            var guidFolderCross = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"05 - CrossCutting\", \"05 - CrossCutting\", " + "\"{" + guidFolderCross + "}\"" + "\nEndProject";
            var guidFolderIOC = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"5.1 - IoC\", \"5.1 - IoC\", " + "\"{" + guidFolderIOC + "}\"" + "\nEndProject";
            var guidFolderTO = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"5.2 - TO\", \"5.2 - TO\", " + "\"{" + guidFolderTO + "}\"" + "\nEndProject";
            //06 - Commom
            var guidFolderProxy = Guid.NewGuid().ToString().ToUpper();
            projectMyDeclaration += "\nProject(\"{" + _GuidToFolder + "}\") = \"06 - Commom\", \"06 - Commom\", " + "\"{" + guidFolderProxy + "}\"" + "\nEndProject";

            _TextSL = _TextSL.Replace(projectDeclaration, projectMyDeclaration);

            #endregion

            #region Add projects to the folders
            var indexGlobalSelection = _TextSL.IndexOf("GlobalSection");
            var indexEndGlobalSelection = _TextSL.LastIndexOf("EndGlobalSection");
            var globalSectionDeclaration = _TextSL.Substring(indexGlobalSelection, ((indexEndGlobalSelection + "EndGlobalSection".Count()) - indexGlobalSelection));
            var globalSectionMyDeclaration = globalSectionDeclaration;

            globalSectionMyDeclaration += "\n	GlobalSection(NestedProjects) = preSolution\n";
            globalSectionMyDeclaration += "		{" + guidProjPres + "} = {" + guidFolderPres + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderData + "} = {" + guidFolderInfra + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderRepository + "} = {" + guidFolderInfra + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderEF + "} = {" + guidFolderData + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderIOC + "} = {" + guidFolderCross + "}\n";
            globalSectionMyDeclaration += "		{" + guidFolderTO + "} = {" + guidFolderCross + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjDomain + "} = {" + guidFolderDomain + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjInfraEF + "} = {" + guidFolderEF + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjInfraRepo + "} = {" + guidFolderRepository + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjTO + "} = {" + guidFolderTO + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjProxy + "} = {" + guidFolderProxy + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjApp + "} = {" + guidFolderApp + "}\n";
            globalSectionMyDeclaration += "		{" + guidProjCrosIOC + "} = {" + guidFolderIOC + "}\n";

            _TextSL = _TextSL.Replace(globalSectionDeclaration, globalSectionMyDeclaration);
            #endregion

            base.saveFile(_GenerateCode.PathSolution, $"\\{_Project.NameSpace}x.sln", _TextSL);
        }

        public string createProject(string prPathProjectName,
                                    string prPathProjectTemplate, 
                                    string prPathTemplatePackConfig, 
                                    string prPathTemplateAssembly, 
                                    Dictionary<string, string> prProjectReferences = null)
        {
            var csProjGuid = Guid.NewGuid().ToString().ToUpper();

            string textCsProj = File.ReadAllText(prPathProjectTemplate);
            textCsProj = textCsProj.Replace("[PROJECTGUID]", csProjGuid);
            textCsProj = base.replaceVariables(textCsProj);
            if (prProjectReferences != null)
                textCsProj = createReferences(prProjectReferences, textCsProj);

            var pathProjectFolder = _GenerateCode.PathSolution + prPathProjectName;
            base.saveFile(pathProjectFolder, $"\\{prPathProjectName}.csproj", textCsProj);

            createPackagesConfig(pathProjectFolder, prPathTemplatePackConfig);
            createAssemblyInfo(csProjGuid, pathProjectFolder, prPathTemplateAssembly);

            return csProjGuid;
        }

        private string createReferences(Dictionary<string, string> prReferencesProject, string prTextCsProj)
        {
            StringBuilder sbReference = new StringBuilder();
            foreach (var item in prReferencesProject)
            {
                //TODO: FAZER UMA TEMPLATE
                sbReference.AppendLine($"<ProjectReference Include=\"..\\{item.Value}\\{item.Value}.csproj\">");
                sbReference.AppendLine("    <Project>{" + item.Key + "}</Project>");
                sbReference.AppendLine($"    <Name>{item.Value}</Name>");
                sbReference.AppendLine("</ProjectReference>");
            }

            return prTextCsProj.Replace("[REFERENCES]", sbReference.ToString());
        }

        public void createPackagesConfig(string prPathProjectFolder, string prPathTemplatePackConfig)
        {
            File.Copy(prPathTemplatePackConfig, prPathProjectFolder + "\\packages.config", true);
        }

        public void createAssemblyInfo(string prProjectGuid, string prPathProjectFolder, string prPathTemplateAssembly)
        {
            var pathAssembly = prPathProjectFolder + "\\Properties";
            string textAssembly = File.ReadAllText(prPathTemplateAssembly);
            textAssembly = textAssembly.Replace("[PROJECTGUID]", prProjectGuid).Replace("[NAMESPACE]", _Project.NameSpace);
            base.saveFile(pathAssembly, "AssemblyInfo.cs", textAssembly);
        }
    }
}
