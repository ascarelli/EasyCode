using [NAMESPACE].Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace [NAMESPACE].Infra.Data.EF.Configurations
{
    public class [ENTITY]Configuration : EntityTypeConfiguration<[ENTITY]>
    {
        public [ENTITY]Configuration()
        {
            HasKey(x => x.Id[ENTITY]);

            [ATTRS]

            Ignore(x => x.ValidationResult);
            Ignore(x => x.IsValid);
            Ignore(x => x.Id);
            ToTable("[TABLE]");
        }
    }
}
