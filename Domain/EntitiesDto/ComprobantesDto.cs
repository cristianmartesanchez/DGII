using DGII.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DGII.Domain.EntitiesDto
{
    public class ComprobantesDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RncCedula { get; set; }
        [Required]
        public string NCF { get; set; }
        [Required]
        public decimal Monto { get; set; }
        [Required]
        public decimal itbis { get; set; }

        ContribuyentesDto ContribuyentesDto { get; set; }
    }
}
