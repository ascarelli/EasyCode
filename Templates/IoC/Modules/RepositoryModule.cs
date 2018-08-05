using Ninject.Modules;
using [NAMESPACE].Domain.Interfaces.Infra.Data.Repository;
using [NAMESPACE].Infra.Data.Repository.Repositories;

namespace [NAMESPACE].CrossCutting.IoC.Modules
{
    public class Api[ENTITY]RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<I[ENTITY]Repository>().To<[ENTITY]Repository>();
        }
    }
}