using Prodesp.Core.EntityFramework;
using [NAMESPACE].Domain.Entities;
using [NAMESPACE].Infra.Data.EF.Configurations;
using System.Configuration;
using System.Data.Entity;

namespace [NAMESPACE].Infra.Data.EF
{
    public class Contexto : EncryptedDbContext
    {
        public Contexto(string conn) : base(ConfigurationManager.ConnectionStrings[conn].ConnectionString, 
                                            ConfigurationManager.AppSettings["API.[ENTITYNAME].SCHEMA"])
        {
            
        }

        public override void ApplyConfiguration(DbModelBuilder modelBuilder)
        {
			[ENTITIESCONFIGURATION]
        }

		[ENTITIES]
    }
}
