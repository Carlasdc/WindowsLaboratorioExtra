using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        public int PlanillaId { get; set; }

        public DateTime Fecha { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public int IdCurso { get; set; }

        public int IdDetalles { get; set; } // o es una lista de id de detalles??



        #region
        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        [ForeignKey("IdMateria")]
        public Materia Materia { get; set; }

        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }
        [ForeignKey("IdDetalle")]
        public List<Detalle> detalles { get; set; }
        #endregion

    }
}
