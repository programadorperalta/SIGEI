using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Equipo
    {
        public int Id { get; set; }
        public string SerielNumber { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaVencimientoGarantia { get; set; }
        public ICollection<EquipoPeriferico> EquiposPerifericos { get; set; }
        public ICollection<Empleado> Empleados { get; set; }

        //prop Nav
        public virtual Departamento Departamento { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        
    }
}
