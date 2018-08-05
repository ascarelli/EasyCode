using Prodesp.Core.Backend.Domain.Interfaces.Infra.Data;
using Prodesp.Core.Backend.Infrastructure.Data.EF.Implementations;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Domain.Interfaces.Infra.Data.Repository;
using System.Linq;

namespace [NAMESPACE].Infra.Data.Repository.Repositories
{
    public class [ENTITY]Repository :
      Repository<[ENTITY], Data.EF.Contexto>, I[ENTITY]Repository
    {
        public [ENTITY]Repository(IUnitOfWork<Data.EF.Contexto> uow) :
            base(uow)
        {

        }
    }
}
