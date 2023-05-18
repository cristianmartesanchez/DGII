using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IComprobanteRepository Comprobantes { get; }
        IContribuyenteRepository Contribuyentes { get; }
        int Commit();
    }
}
