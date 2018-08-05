using Prodesp.Core.Backend.Application.WebApi.Controllers;
using Prodesp.Core.Backend.Domain.Interfaces.Infra.Data;
using [NAMESPACE].TO.Response;
using [NAMESPACE].Application.Interfaces;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Infra.Data.EF;
using Prodesp.Gsnet.Core.TO.Validation;
using Prodesp.Gsnet.Framework.Log;
using System;
using System.Net;
using System.Web.Http;

namespace [NAMESPACE].Controllers
{
    [RoutePrefix("api/[ENTITY]")]
    public class [ENTITY]Controller : BaseController<[ENTITY], I[ENTITY]AppService, Contexto>
    {
        public [ENTITY]Controller(I[ENTITY]AppService service, IUnitOfWork<Contexto> unitOfWork)
            : base(service, unitOfWork)
        {
        }

    }
}
