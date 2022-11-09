using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int EvaluacionId { get; set; }

        [Required]
        [Column(TypeName ="decimal")]
        public decimal Nota { get; set; }

        public int IdTipo { get; set; }
        public int IdDetalle { get; set; }
        public int IdEstudiante { get; set; }


        #region

        [ForeignKey("IdEstudiante")]
        public Estudiante Estudiante  { get; set; }

        [ForeignKey("IdDetalle")]
        public Detalle Detalle { get; set; }

        [ForeignKey("IdTipo")]
        public Tipo Tipo { get; set; }

        #endregion
    }
}
