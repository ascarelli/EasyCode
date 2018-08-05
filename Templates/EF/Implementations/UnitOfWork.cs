using Prodesp.Core.Backend.Infrastructure.Data.EF.Implementations;
using Prodesp.Gsnet.Framework;

namespace [NAMESPACE].Infra.Data.EF.Implementations
{
    public class UnitOfWork : BaseUnitOfWork<Contexto>
    {
        public UnitOfWork()
            : base(HelperSettings.ReadString("ConnectionString.[YOURDATABASE]"))
        {

        }
    }
}
