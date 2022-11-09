namespace WindowsLaboratorioExtra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseDatosEsc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CarreraId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        DetalleId = c.Int(nullable: false, identity: true),
                        IdEstado = c.Int(nullable: false),
                        IdPlanilla = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleId)
                .ForeignKey("dbo.Estado", t => t.IdEstado)
                .ForeignKey("dbo.Planilla", t => t.IdPlanilla)
                .Index(t => t.IdEstado)
                .Index(t => t.IdPlanilla);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Planilla",
                c => new
                    {
                        PlanillaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        IdCarrera = c.Int(nullable: false),
                        IdMateria = c.Int(nullable: false),
                        IdProfesor = c.Int(nullable: false),
                        IdCurso = c.Int(nullable: false),
                        IdDetalles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanillaId)
                .ForeignKey("dbo.Carrera", t => t.IdCarrera)
                .ForeignKey("dbo.Curso", t => t.IdCurso)
                .ForeignKey("dbo.Materia", t => t.IdMateria)
                .ForeignKey("dbo.Profesor", t => t.IdProfesor)
                .Index(t => t.IdCarrera)
                .Index(t => t.IdMateria)
                .Index(t => t.IdProfesor)
                .Index(t => t.IdCurso);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdPlanilla = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MateriaId);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        IdPlanilla = c.Int(nullable: false),
                        IdLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfesorId)
                .ForeignKey("dbo.Localidad", t => t.IdLocalidad)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdProfesor = c.Int(nullable: false),
                        IdEstudiante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Calle = c.String(nullable: false, maxLength: 50, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstudianteId)
                .ForeignKey("dbo.Localidad", t => t.IdLocalidad)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Evaluacion",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        Nota = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdTipo = c.Int(nullable: false),
                        IdDetalle = c.Int(nullable: false),
                        IdEstudiante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionId)
                .ForeignKey("dbo.Detalle", t => t.IdDetalle)
                .ForeignKey("dbo.Estudiante", t => t.IdEstudiante)
                .ForeignKey("dbo.Tipo", t => t.IdTipo)
                .Index(t => t.IdTipo)
                .Index(t => t.IdDetalle)
                .Index(t => t.IdEstudiante);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoId);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdCarrera = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanId)
                .ForeignKey("dbo.Carrera", t => t.IdCarrera)
                .Index(t => t.IdCarrera);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plan", "IdCarrera", "dbo.Carrera");
            DropForeignKey("dbo.Evaluacion", "IdTipo", "dbo.Tipo");
            DropForeignKey("dbo.Evaluacion", "IdEstudiante", "dbo.Estudiante");
            DropForeignKey("dbo.Evaluacion", "IdDetalle", "dbo.Detalle");
            DropForeignKey("dbo.Planilla", "IdProfesor", "dbo.Profesor");
            DropForeignKey("dbo.Profesor", "IdLocalidad", "dbo.Localidad");
            DropForeignKey("dbo.Estudiante", "IdLocalidad", "dbo.Localidad");
            DropForeignKey("dbo.Planilla", "IdMateria", "dbo.Materia");
            DropForeignKey("dbo.Detalle", "IdPlanilla", "dbo.Planilla");
            DropForeignKey("dbo.Planilla", "IdCurso", "dbo.Curso");
            DropForeignKey("dbo.Planilla", "IdCarrera", "dbo.Carrera");
            DropForeignKey("dbo.Detalle", "IdEstado", "dbo.Estado");
            DropIndex("dbo.Plan", new[] { "IdCarrera" });
            DropIndex("dbo.Evaluacion", new[] { "IdEstudiante" });
            DropIndex("dbo.Evaluacion", new[] { "IdDetalle" });
            DropIndex("dbo.Evaluacion", new[] { "IdTipo" });
            DropIndex("dbo.Estudiante", new[] { "IdLocalidad" });
            DropIndex("dbo.Profesor", new[] { "IdLocalidad" });
            DropIndex("dbo.Planilla", new[] { "IdCurso" });
            DropIndex("dbo.Planilla", new[] { "IdProfesor" });
            DropIndex("dbo.Planilla", new[] { "IdMateria" });
            DropIndex("dbo.Planilla", new[] { "IdCarrera" });
            DropIndex("dbo.Detalle", new[] { "IdPlanilla" });
            DropIndex("dbo.Detalle", new[] { "IdEstado" });
            DropTable("dbo.Plan");
            DropTable("dbo.Tipo");
            DropTable("dbo.Evaluacion");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Localidad");
            DropTable("dbo.Profesor");
            DropTable("dbo.Materia");
            DropTable("dbo.Planilla");
            DropTable("dbo.Estado");
            DropTable("dbo.Detalle");
            DropTable("dbo.Curso");
            DropTable("dbo.Carrera");
        }
    }
}
