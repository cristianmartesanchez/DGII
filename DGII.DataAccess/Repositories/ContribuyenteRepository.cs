using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using DGII.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.DataAccess.Repositories
{
    public class ContribuyenteRepository : GenericRepository<Contribuyentes>, IContribuyenteRepository
    {
        public ContribuyenteRepository(DGIIDataContext context) : base(context)
        {
        }


        public ContribuyentesDto? GetContribuyente(string RncCedula)
        {
            var contribuyente = _context.Contribuyentes.Include(a => a.Tipo).Select(contribuyente => new ContribuyentesDto
            {
                Nombre = contribuyente.Nombre,
                RncCedula = contribuyente.RncCedula,
                TipoId = contribuyente.TipoId,
                status = contribuyente.status,
                Tipos = new TiposDto
                {
                    Id = contribuyente.TipoId,
                    Descripcion = contribuyente.Tipo.Descripcion
                }

            }).FirstOrDefault(a => a.RncCedula == RncCedula);

            return contribuyente;
        }

        public IEnumerable<ContribuyentesDto> GetContribuyentes()
        {
            var contribuyentes = _context.Contribuyentes.Include(a => a.Tipo).Select(contribuyente => new ContribuyentesDto
            {
                Nombre = contribuyente.Nombre,
                RncCedula = contribuyente.RncCedula,
                TipoId = contribuyente.TipoId,
                status = contribuyente.status,
                Tipos = new TiposDto
                {
                    Id = contribuyente.TipoId,
                    Descripcion = contribuyente.Tipo.Descripcion
                }

            }).ToList();

            return contribuyentes;
        }
    }
}
