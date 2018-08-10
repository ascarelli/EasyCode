using Prodesp.Core.Backend.Domain.Interfaces.Infra.Data;
using Prodesp.Core.Backend.Infrastructure.Data.EF.Implementations;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Domain.Interfaces.Infra.Data.Repository;

namespace [NAMESPACE].Infra.Repository.Repositories
{
    public class [ENTITY]Repository :
      Repository<[ENTITY], EF.Contexto>, I[ENTITY]Repository
    {
        public [ENTITY]Repository(IUnitOfWork<EF.Contexto> uow) :
            base(uow)
        {

        }
    }
}
