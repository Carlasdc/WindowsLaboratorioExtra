using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Plan")]
    public class Plan
    {
        public int PlanId { get; set; }
        public string Nombre { get; set; }

        public int IdCarrera { get; set; }

        #region

        [ForeignKey("IdCarrera")]
        public Carrera Carrera { get; set; }

        #endregion

    }
}
