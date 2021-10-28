namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregoclases2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IdHabitacion = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        IdEspecialidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdEspecialidad);
            
            AddColumn("dbo.Medico", "IdEspecialidad", c => c.Int(nullable: false));
            CreateIndex("dbo.Medico", "IdEspecialidad");
            AddForeignKey("dbo.Medico", "IdEspecialidad", "dbo.Especialidad", "IdEspecialidad", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "IdEspecialidad", "dbo.Especialidad");
            DropForeignKey("dbo.Habitacion", "Id", "dbo.Clinica");
            DropIndex("dbo.Medico", new[] { "IdEspecialidad" });
            DropIndex("dbo.Habitacion", new[] { "Id" });
            DropColumn("dbo.Medico", "IdEspecialidad");
            DropTable("dbo.Especialidad");
            DropTable("dbo.Habitacion");
            DropTable("dbo.Clinica");
        }
    }
}
