using DGII.Domain.EntitiesDto;
using System.ComponentModel.DataAnnotations;

namespace DGII.Domain.EntitiesDto
{
    public class ContribuyentesDto
    {
        [Required]
        public string RncCedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int TipoId { get; set; }
        public bool status { get; set; } = false;

        public ICollection<ComprobantesDto>? ComprobantesDtos { get; set; }
        public TiposDto? Tipos { get; set; }
    }
}
