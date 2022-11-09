using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public int IdPlanilla { get; set; }
        public int IdLocalidad { get; set; }

        #region
        //[ForeignKey("IdPlanilla")]
        public List<Planilla> planillas { get; set; }

        [ForeignKey("IdLocalidad")]
        public Localidad localidad { get; set; }
        #endregion

    }
}
