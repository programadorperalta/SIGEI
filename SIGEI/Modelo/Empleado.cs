using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public string Dni { get; set; }
        public Equipo Equipo { get; set;  }

        public virtual Departamento Departamento { get; set; }



    }
}
