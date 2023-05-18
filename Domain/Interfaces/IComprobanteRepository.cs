using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.Domain.Interfaces
{
    public interface IComprobanteRepository : IGenericRepository<Comprobantes>
    {
        IEnumerable<ComprobantesDto> GetComprobantes();
        IEnumerable<ComprobantesDto> GetComprobantes(string RncCedula);
        ComprobantesDto? GetComprobante(string NCF);
        ComprobantesDto? GetComprobante(string NCF, string RncCedula);
    }
}
