using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLaboratorioExtra.Models
{
    [Table("Materia")]
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public int IdPlanilla { get; set; }
        #region
        [ForeignKey("IdPlanilla")]
        public List<Planilla> planillas { get; set; }
        #endregion

    }
}
