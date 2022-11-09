using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Telefono{ get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Calle { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Numero { get; set; }
        public int IdLocalidad { get; set; }
        

        #region
        [ForeignKey("IdLocalidad")]
        public Localidad Localidad { get; set; }

        
        List<Evaluacion> Evaluaciones { get; set; }   


        #endregion


    }
}
