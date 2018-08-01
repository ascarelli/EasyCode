using Prodesp.Core.Backend.Domain.Interfaces;
using Prodesp.Core.Backend.Domain.Interfaces.Domain.Validations;
using Prodesp.Core.Backend.Domain.Validations;
using System;

namespace [NAMESPACE].Entities
{
    public class [ENTITY] : IEntityKey<string>, ISelfValidation
    {
        public TipoCentro()
        {
        }

	   [ATTRS]
        public bool IsValid
        {
            get
            {
                return this.ValidationResult.IsValid;
            }
        }
    }
}
