using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using DGII.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.DataAccess.Repositories
{
    public class ComprobantesRepository : GenericRepository<Comprobantes>, IComprobanteRepository
    {
        public ComprobantesRepository(DGIIDataContext context) : base(context)
        {
        }

        public ComprobantesDto? GetComprobante(string NCF)
        {
            return _context.Comprobantes.Select(a => new ComprobantesDto
            {
                Id = a.Id,
                itbis = a.itbis,
                NCF = a.NCF,
                RncCedula = a.RncCedula,
                Monto = a.Monto
            }).FirstOrDefault(c => c.NCF == NCF);
             
        }

        public ComprobantesDto? GetComprobante(int id)
        {
            return _context.Comprobantes.Select(a => new ComprobantesDto
            {
                Id = a.Id,
                itbis = a.itbis,
                NCF = a.NCF,
                RncCedula = a.RncCedula,
                Monto = a.Monto
            }).FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<ComprobantesDto> GetComprobantes()
        {
            return _context.Comprobantes.Select(a => new ComprobantesDto
            {
                Id = a.Id,
                itbis = a.itbis,
                NCF = a.NCF,
                RncCedula = a.RncCedula,
                Monto = a.Monto
            }).ToList();
        }

        public IEnumerable<ComprobantesDto> GetComprobantes(string RncCedula)
        {
            return _context.Comprobantes.Select(a => new ComprobantesDto
            {
                Id = a.Id,
                itbis = a.itbis,
                NCF = a.NCF,
                RncCedula = a.RncCedula,
                Monto = a.Monto
            }).Where(a => a.RncCedula == RncCedula).ToList();
        }

        public ComprobantesDto? GetComprobante(string NCF, string RncCedula)
        {
            return _context.Comprobantes.Select(a => new ComprobantesDto
            {
                Id = a.Id,
                itbis = a.itbis,
                NCF = a.NCF,
                RncCedula = a.RncCedula,
                Monto = a.Monto
            }).FirstOrDefault(a => a.NCF == NCF && a.RncCedula == RncCedula);
        }
    }
}
