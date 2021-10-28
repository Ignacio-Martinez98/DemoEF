namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregoclases : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Medicos", newName: "Medico");
            AlterColumn("dbo.Medico", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Medico", "Apellido", c => c.String());
            AlterColumn("dbo.Medico", "Nombre", c => c.String());
            RenameTable(name: "dbo.Medico", newName: "Medicos");
        }
    }
}
