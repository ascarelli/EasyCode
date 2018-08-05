using Ninject.Modules;
using [NAMESPACE].Domain.Interfaces.Domain.Services;
using [NAMESPACE].Domain.Services;

namespace [NAMESPACE].CrossCutting.IoC.Modules
{
    public class Api[ENTITY]ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<I[ENTITY]Service>().To<[ENTITY]Service>();
        }
    }
}
