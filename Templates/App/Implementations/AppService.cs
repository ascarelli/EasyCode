using Prodesp.Core.Backend.Application.Implementations;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Domain.Interfaces.Domain.Services;
using [NAMESPACE].Application.Interfaces;
using [NAMESPACE]TO.Response;
using System;
using System.Linq;
using System.Collections.Generic;
using Prodesp.Core.Backend.Domain.Validations;

namespace [NAMESPACE].Application.Implementations
{
    public class [ENTITY]AppService : AppService<[ENTITY], I[ENTITY]Service>, I[ENTITY]AppService
    {
        public [ENTITY]AppService(I[ENTITY]Service service)
            : base(service)
        {
            
        }

        #region Validate
        public override ValidationResult ValidateDelete([ENTITY] entity)
        {
            throw new NotImplementedException();
        }

        public override ValidationResult ValidateInsert([ENTITY] entity)
        {
            throw new NotImplementedException();
        }

        public override ValidationResult ValidateUpdate([ENTITY] entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
