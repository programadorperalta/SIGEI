using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI.Infraestructura
{
    public class TiendaContext : DbContext
    {
        public TiendaContext() : base("Tienda")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<EquipoPeriferico>()
            //    .HasKey(x => new { x.Id })
            //    .HasRequired(x => new { x.IdEquipo, x.IdPeriferico })
            //    .WithMany();
        }

        //Entities
        public DbSet<Equipo> Producto { get; set; }
        public DbSet<EquipoPeriferico> EquipoPerifericos { get; set; }
        public DbSet<Periferico> Periferico { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }


    }
}
