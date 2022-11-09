using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int EstadoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        public List<Detalle> Detalles { get; set; }

    }
}
