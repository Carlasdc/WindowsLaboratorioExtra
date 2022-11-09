using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
        [Table("Localidad")]
        public class Localidad
        {

        [Required]

        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public int IdProfesor { get; set; }
        public int IdEstudiante { get; set; }

        #region
        //[ForeignKey("IdEstudiante")]
        public List<Estudiante> estudiantes { get; set; }

        //[ForeignKey("IdProfesor")]
        public List<Profesor> profesores { get; set; }
        #endregion


    }
}
