using DGII.DataAccess.Repositories;
using DGII.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DGIIDataContext _context;

        public UnitOfWork(DGIIDataContext context)
        {
            _context = context;
            Comprobantes = new ComprobantesRepository(_context);
            Contribuyentes = new ContribuyenteRepository(_context);
        }

        public IComprobanteRepository Comprobantes { get; set; }

        public IContribuyenteRepository Contribuyentes { get; set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose(); 
        }
    }
}
