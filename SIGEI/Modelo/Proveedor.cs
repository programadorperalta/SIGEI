using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public ICollection<Equipo> Equipos { get; set; }
        public ICollection<Periferico> Perifericos { get; set; }
    }
}
