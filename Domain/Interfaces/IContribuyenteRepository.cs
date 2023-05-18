using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.Domain.Interfaces
{
    public interface IContribuyenteRepository : IGenericRepository<Contribuyentes>
    {
        IEnumerable<ContribuyentesDto> GetContribuyentes();
        ContribuyentesDto? GetContribuyente(string RncCedula);
    }
}
