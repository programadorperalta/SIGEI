using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Periferico
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string NumeroDeSerie { get; set; }
        public int IdProveedor { get; set; }
        public ICollection<EquipoPeriferico> EquiposPerifericos { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
