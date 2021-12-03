namespace SIGEI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevas_Entidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entidad = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        Datos = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Legajo = c.Int(nullable: false),
                        Dni = c.String(),
                        Departamento_Id = c.Int(),
                        Equipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.Departamento_Id)
                .ForeignKey("dbo.Equipo", t => t.Equipo_Id)
                .Index(t => t.Departamento_Id)
                .Index(t => t.Equipo_Id);
            
            CreateTable(
                "dbo.Equipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SerielNumber = c.String(),
                        Description = c.String(),
                        Model = c.String(),
                        Marca = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaVencimientoGarantia = c.DateTime(nullable: false),
                        Departamento_Id = c.Int(),
                        Proveedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.Departamento_Id)
                .ForeignKey("dbo.Proveedor", t => t.Proveedor_Id)
                .Index(t => t.Departamento_Id)
                .Index(t => t.Proveedor_Id);
            
            CreateTable(
                "dbo.EquipoPeriferico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaBaja = c.DateTime(),
                        Equipo_Id = c.Int(),
                        Periferico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipo", t => t.Equipo_Id)
                .ForeignKey("dbo.Periferico", t => t.Periferico_Id)
                .Index(t => t.Equipo_Id)
                .Index(t => t.Periferico_Id);
            
            CreateTable(
                "dbo.Periferico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Descripcion = c.String(),
                        NumeroDeSerie = c.String(),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaVencimientoGarantia = c.DateTime(nullable: false),
                        Proveedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proveedor", t => t.Proveedor_Id)
                .Index(t => t.Proveedor_Id);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        RazonSocial = c.String(),
                        Cuit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nick = c.String(),
                        Contraseña = c.String(),
                        Permiso = c.String(),
                        Empleado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleado", t => t.Empleado_Id)
                .Index(t => t.Empleado_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Empleado_Id", "dbo.Empleado");
            DropForeignKey("dbo.Periferico", "Proveedor_Id", "dbo.Proveedor");
            DropForeignKey("dbo.Equipo", "Proveedor_Id", "dbo.Proveedor");
            DropForeignKey("dbo.EquipoPeriferico", "Periferico_Id", "dbo.Periferico");
            DropForeignKey("dbo.EquipoPeriferico", "Equipo_Id", "dbo.Equipo");
            DropForeignKey("dbo.Empleado", "Equipo_Id", "dbo.Equipo");
            DropForeignKey("dbo.Equipo", "Departamento_Id", "dbo.Departamento");
            DropForeignKey("dbo.Empleado", "Departamento_Id", "dbo.Departamento");
            DropIndex("dbo.Usuario", new[] { "Empleado_Id" });
            DropIndex("dbo.Periferico", new[] { "Proveedor_Id" });
            DropIndex("dbo.EquipoPeriferico", new[] { "Periferico_Id" });
            DropIndex("dbo.EquipoPeriferico", new[] { "Equipo_Id" });
            DropIndex("dbo.Equipo", new[] { "Proveedor_Id" });
            DropIndex("dbo.Equipo", new[] { "Departamento_Id" });
            DropIndex("dbo.Empleado", new[] { "Equipo_Id" });
            DropIndex("dbo.Empleado", new[] { "Departamento_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Proveedor");
            DropTable("dbo.Periferico");
            DropTable("dbo.EquipoPeriferico");
            DropTable("dbo.Equipo");
            DropTable("dbo.Empleado");
            DropTable("dbo.Departamento");
            DropTable("dbo.Auditoria");
        }
    }
}
