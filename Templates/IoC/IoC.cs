using Ninject.Modules;
using [NAMESPACE].CrossCutting.IoC.Modules;
using System.Linq;

namespace [NAMESPACE].CrossCutting.IoC
{
    public class IoC : Prodesp.Core.Backend.CrossCutting.IoC.IoC
    {
        public IoC() : base()
        {

        }

        public override INinjectModule[] Modules()
        {
            var list = base.Modules().ToList();

            list.Add(new Api[ENTITY]ApplicationModule());
            list.Add(new Api[ENTITY]ServiceModule());
            list.Add(new Api[ENTITY]RepositoryModule());
            list.Add(new UnitOfWorkModule());

            return list.ToArray();
        }
    }
}
