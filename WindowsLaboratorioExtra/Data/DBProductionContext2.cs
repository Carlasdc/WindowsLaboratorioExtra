using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsLaboratorioExtra.Models;

namespace WindowsLaboratorioExtra.Data
{
    public class DBProductionContext2:DbContext
    {
        public DBProductionContext2() : base("keyDBEscuela") { }

        DbSet<Carrera> Carreras { get; set; }
        DbSet<Curso> Cursos { get; set; }
        DbSet<Detalle> Detalles { get; set; }
        DbSet<Estado> Estados { get; set; }
        DbSet<Estudiante> Estudiantes { get; set; }
        DbSet<Evaluacion> Evaluacion { get; set; }
        DbSet<Localidad> Localidades { get; set; }
        DbSet<Materia> Materias { get; set; }
        DbSet<Plan> Planes { get; set; }
        DbSet<Planilla> Planillas { get; set; }

        DbSet<Profesor> Profesores { get; set; }
        DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
