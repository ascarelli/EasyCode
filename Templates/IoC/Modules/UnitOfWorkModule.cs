using Ninject.Modules;
using Ninject.Web.Common;
using Prodesp.Core.Backend.Domain.Interfaces.Infra.Data;
using [NAMESPACE].Infra.EF.Implementations;


namespace [NAMESPACE].CrossCutting.IoC.Modules
{
    public class UnitOfWorkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork<Infra.EF.Contexto>>().To<UnitOfWork>().InRequestScope();
        }
    }
}
