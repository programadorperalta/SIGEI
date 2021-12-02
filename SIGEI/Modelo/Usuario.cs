using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Contraseña { get; set; }
        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }
    }
}
