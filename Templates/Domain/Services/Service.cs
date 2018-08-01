using Prodesp.Core.Backend.Domain.Services;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Domain.Interfaces.Domain.Services;
using [NAMESPACE].Domain.Interfaces.Infra.Data.Repository;

namespace [NAMESPACE].Domain.Services
{
    public class [ENTITY]Service : 
        Service<[ENTITY], I[ENTITY]Repository>, I[ENTITY]Service
    {
        private readonly I[ENTITY]Repository _[ENTITY]Repository;

        public TipoCentroService(I[ENTITY]Repository pr[ENTITY]Repository) 
            : base(pr[ENTITY]Repository)
        {
            _[ENTITY]Repository = pr[ENTITY]Repository;
        }
    }
}