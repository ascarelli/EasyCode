using Ninject.Modules;
using Ninject.Web.Common;
using Prodesp.Core.Backend.Domain.Interfaces.Infra.Data;
using [NAMESPACE].Infra.Data.EF.Implementations;


namespace [NAMESPACE].CrossCutting.IoC.Modules
{
    public class UnitOfWorkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork<Infra.Data.EF.Contexto>>().To<UnitOfWork>().InRequestScope();
        }
    }
}
