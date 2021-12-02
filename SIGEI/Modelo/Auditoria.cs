using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Auditoria
    {
        public int Id { get; set; }
        public string Entidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Datos { get; set; }
    }
}
