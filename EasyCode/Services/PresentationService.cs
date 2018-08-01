using EasyCode.Entities;
using EasyCode.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCode.Services
{
    public class PresentationService : BaseGeneratorClass
    {
        public PresentationService()
        {
        }

        private void gerarPresentation()
        {
            GerarController();
            gerarJavaScript();
            gerarHtml();
        }

        private void GerarController()
    {
        _Codigo = string.Empty;

        addLine("using System");
        addLine("using System.Linq;");
        addLine("using System.Reflection;");
        addLine("using System.Collections.Generic;");
        addLine("using System.Web.Mvc;");
        addLine("using System.Web.Script.Serialization;");
        addLine("using Newtonsoft.Json;");
        addLine("using aCallao.Controllers;");
        addLine("using [Namespace].Application.Interface;");
        addLine("using [Namespace].Application.ViewModels;");
        addLine("using [Namespace].Messages;");
        addLine("using [Namespace].CrossCutting;");
        addLine("using TSA.CohesiveMechanism;");
        addLine("using Core.CohesiveMechanism;");
        addLine("using Core.Abstract;");

        addLine(string.Empty);
        addLine("namespace mCallao.Controllers");
        addLine("{");
        addLine("        [TsaAuthorizeSessionAttribute()]");
        addLine("        public class [NameEntity]Controller : BASEController");
        addLine("        {");
        addLine(string.Empty);

        //objects Service
        addLine("            I[NameEntity]AppService _[NameEntity]AppService;");
        addLine(string.Empty);

        //construtor - injection dependancy
        addLine("            public [NameEntity]Controller(I[NameEntity]AppService pr[NameEntity]AppService)");
        addLine("            {");
        addLine("                _[NameEntity]AppService = pr[NameEntity]AppService;");
        addLine("            }");
        addLine(string.Empty);

        //view
        addLine("            public ActionResult [NameEntity]View()");
        addLine("            {");
        addLine("                return PartialView(\"~/Views/COLOQUESEUCAMINHO/[NameEntity]/[NameEntity].cshtml\");");
        addLine("            }");
        addLine(string.Empty);

        //Insert
        addLine("            public JsonResult new[NameEntity](string pr[NameEntity]ViewModel)");
        addLine("            {");
        addLine("               JsonResult lJsonResult = null;");
        addLine("               try");
        addLine("               {");
        addLine("                   JavaScriptSerializer jsSerializer = new JavaScriptSerializer();");
        addLine("                   [NameEntity]ViewModel l[NameEntity]ViewModel = jsSerializer.Deserialize<[NameEntity]ViewModel>(pr[NameEntity]ViewModel);");

        addLine("                   l[NameEntity]ViewModel = _[NameEntity]AppService.insert[NameEntity](l[NameEntity]ViewModel);");
        addLine("                   if (l[NameEntity]ViewModel.ValidationAppResult.IsValid)");
        addLine("                   {");
        addLine("                       lJsonResult = Json(l[NameEntity]ViewModel);");
        addLine("                   }");
        addLine("                   else");
        addLine("                   {");
        addLine("                       var lError = l[NameEntity]ViewModel.ValidationAppResult.Erros.FirstOrDefault();");
        addLine("                       lJsonResult = Json(new Message { astMessage = lError.Message, astType = Message.KDType.kdError });");
        addLine("                   }");
        addLine("               }");
        addLine("               catch (Exception ex)");
        addLine("               {");
        addLine("                   var lError = \"No podemos procesar su solicitud.Por favor intentarlo de nuevo en unos minutos.\";");
        addLine("                   aCoContextExecution.CoLog(\" * *Error new[NameEntity]: detalle: \" + ex.Message, MethodBase.GetCurrentMethod(), CoContextExecution.KDLogType.kdError);");
        addLine("                   lJsonResult = Json(new Message { astMessage = lError, astType = Message.KDType.kdError });");
        addLine("               }");

        addLine("                return lJsonResult;");
        addLine("            }");
        addLine(string.Empty);

        //update
        addLine("            public JsonResult update[NameEntity](string pr[NameEntity]ViewModel)");
        addLine("            {");
        addLine("               JsonResult lJsonResult = null;");
        addLine("               try");
        addLine("               {");
        addLine("                   JavaScriptSerializer jsSerializer = new JavaScriptSerializer();");
        addLine("                   [NameEntity]ViewModel l[NameEntity]ViewModel = jsSerializer.Deserialize<[NameEntity]ViewModel>(pr[NameEntity]ViewModel);");

        addLine("                   l[NameEntity]ViewModel = _[NameEntity]AppService.update[NameEntity](l[NameEntity]ViewModel);");
        addLine("                   if (l[NameEntity]ViewModel.ValidationAppResult.IsValid)");
        addLine("                   {");
        addLine("                       lJsonResult = Json(l[NameEntity]ViewModel);");
        addLine("                   }");
        addLine("                   else");
        addLine("                   {");
        addLine("                       var lError = l[NameEntity]ViewModel.ValidationAppResult.Erros.FirstOrDefault();");
        addLine("                       lJsonResult = Json(new Message { astMessage = lError.Message, astType = Message.KDType.kdError });");
        addLine("                   }");
        addLine("               }");
        addLine("               catch (Exception ex)");
        addLine("               {");
        addLine("                   var lError = \"No podemos procesar su solicitud.Por favor intentarlo de nuevo en unos minutos.\";");
        addLine("                   aCoContextExecution.CoLog(\" * *Error update[NameEntity]: detalle: \" + ex.Message, MethodBase.GetCurrentMethod(), CoContextExecution.KDLogType.kdError);");
        addLine("                   lJsonResult = Json(new Message { astMessage = lError, astType = Message.KDType.kdError });");
        addLine("               }");

        addLine("                return lJsonResult;");
        addLine("            }");
        addLine(string.Empty);

        //delete
        addLine("            public JsonResult delete[NameEntity](string pr[NameEntity]ViewModel)");
        addLine("            {");
        addLine("               JsonResult lJsonResult = null;");
        addLine("               try");
        addLine("               {");
        addLine("                    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();");
        addLine("                    [NameEntity]ViewModel l[NameEntity]ViewModel = jsSerializer.Deserialize<[NameEntity]ViewModel>(pr[NameEntity]ViewModel);");

        addLine("                    l[NameEntity]ViewModel = _[NameEntity]AppService.remove[NameEntity](l[NameEntity]ViewModel);");
        addLine("                    if (l[NameEntity]ViewModel.ValidationAppResult.IsValid)");
        addLine("                    {");
        addLine("                        lJsonResult = Json(l[NameEntity]ViewModel);");
        addLine("                    }");
        addLine("                    else");
        addLine("                    {");
        addLine("                        var lError = l[NameEntity]ViewModel.ValidationAppResult.Erros.FirstOrDefault();");
        addLine("                        lJsonResult = Json(new Message { astMessage = lError.Message, astType = Message.KDType.kdError });");
        addLine("                    }");
        addLine("                }");
        addLine("                catch (Exception ex)");
        addLine("                {");
        addLine("                    var lError = \"No podemos procesar su solicitud.Por favor intentarlo de nuevo en unos minutos.\";");
        addLine("                    aCoContextExecution.CoLog(\" * *Error delete[NameEntity]: detalle: \" + ex.Message, MethodBase.GetCurrentMethod(), CoContextExecution.KDLogType.kdError);");
        addLine("                    lJsonResult = Json(new Message { astMessage = lError, astType = Message.KDType.kdError });");
        addLine("                }");

        addLine("                return lJsonResult;");
        addLine("            }");
        addLine(string.Empty);

        //search
        addLine("            public JsonResult search[NameEntity](string pr[NameEntity]ViewModel, int skipresult = 0, int takeresult = 0)");
        addLine("            {");
        addLine("               JsonResult lJsonResult = null;");
        addLine("               try");
        addLine("               {");
        addLine("                   JavaScriptSerializer jsSerializer = new JavaScriptSerializer();");
        addLine("                   [NameEntity]ViewModel l[NameEntity]ViewModel = jsSerializer.Deserialize<[NameEntity]ViewModel>(pr[NameEntity]ViewModel);");
        addLine("                   List<[NameEntity]ViewModel> l[NameEntity]ViewModelCollection = _[NameEntity]AppService.getByFilter(l[NameEntity]ViewModel, skipresult, takeresult);");
        addLine("                   lJsonResult = Json(l[NameEntity]ViewModelCollection);");
        addLine("               }");
        addLine("               catch (Exception ex)");
        addLine("               {");
        addLine("                   var lError = \"No podemos procesar su solicitud.Por favor intentarlo de nuevo en unos minutos.\";");
        addLine("                   aCoContextExecution.CoLog(\" * *Error search[NameEntity]: detalle: \" + ex.Message, MethodBase.GetCurrentMethod(), CoContextExecution.KDLogType.kdError);");
        addLine("                   lJsonResult = Json(new Message { astMessage = lError, astType = Message.KDType.kdError });");
        addLine("               }");

        addLine("               return lJsonResult;");
        addLine("            }");
        addLine(string.Empty);

        //get
        addLine("            public JsonResult get[NameEntity](decimal pr[NameEntity]ID)");
        addLine("            {");
        addLine("               JsonResult lJsonResult = null;");
        addLine("               try");
        addLine("               {");
        addLine("                   [NameEntity]ViewModel l[NameEntity]ViewModel = a[NameEntity]AppService.getByID(pr[NameEntity]ID);");
        addLine("                   lJsonResult = Json(l[NameEntity]ViewModel);");
        addLine("               }");
        addLine("               catch (Exception ex)");
        addLine("               {");
        addLine("                   var lError = \"No podemos procesar su solicitud.Por favor intentarlo de nuevo en unos minutos.\";");
        addLine("                   aCoContextExecution.CoLog(\" * *Error get[NameEntity]: detalle: \" + ex.Message, MethodBase.GetCurrentMethod(), CoContextExecution.KDLogType.kdError);");
        addLine("                   lJsonResult = Json(new Message { astMessage = lError, astType = Message.KDType.kdError });");
        addLine("               }");

        addLine("               return lJsonResult;");
        addLine("            }");
        addLine("      }");
        addLine("}");
        addLine(string.Empty);

        aplicarVariaveis();
        gravarArquivo(_Codigo, "Presentation", _NameEntity + "Controller.cs");
    }

    private void gerarJavaScript()
    {
      
    }

    private void gerarHtml()
    {
        
    }

    public void execute(string prstNamespace, string prstEntityName, List<ProjectAttribute> prAttr)
    {
        _Namespace = prstNamespace;
        _NameEntity = prstEntityName;
        _Attrs = prAttr;
        gerarPresentation();
    }
}
}