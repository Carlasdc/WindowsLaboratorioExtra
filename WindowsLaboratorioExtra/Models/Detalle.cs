using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int IdEstado { get; set; }
        public int IdPlanilla { get; set; }


        #region
        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }


        [ForeignKey("IdPlanilla")]
        public Planilla Planilla { get; set; }

        #endregion
    }
}
