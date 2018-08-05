using Prodesp.Core.Backend.Domain.Interfaces;
using Prodesp.Core.Backend.Domain.Interfaces.Domain.Validations;
using Prodesp.Core.Backend.Domain.Validations;

namespace [NAMESPACE].Domain.Entities
{
    public class [ENTITY] : IEntityKey<string>, ISelfValidation
    {
        public [ENTITY]()
        {
        }

		public string Id { get; set; }
		[ATTRS]
		public ValidationResult ValidationResult { get; set; }
		
        public bool IsValid
        {
            get
            {
                return this.ValidationResult.IsValid;
            }
        }
    }
}
