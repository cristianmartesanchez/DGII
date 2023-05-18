using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DGII.Domain.Entities
{
    public class Contribuyentes
    {

        [Key]
        public string RncCedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int TipoId { get; set; }
        public bool status { get; set; } = false;

        public ICollection<Comprobantes>? Comprobantes { get; set; }
        [ForeignKey("TipoId")]
        public Tipos? Tipo { get; set; }
    }
}
