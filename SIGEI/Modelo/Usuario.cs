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
        public string Permiso { get; set; }
        public virtual Empleado Empleado { get; set; }
        

    }
}
