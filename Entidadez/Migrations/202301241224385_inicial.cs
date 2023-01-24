namespace Entidadez.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Especialidad = c.String(),
                        Matricula = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroHistClinica = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
        }
    }
}
