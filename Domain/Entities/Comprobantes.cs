using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DGII.Domain.Entities
{
    public class Comprobantes
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

        [ForeignKey("RncCedula")]
        public Contribuyentes Contribuyente { get; set; }
    }
}
