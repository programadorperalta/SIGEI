using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEI
{
    public class EquipoPeriferico
    {
        public int Id { get; set; }
        public int IdEquipo { get; set; }

        public int IdPeriferico { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual Equipo Equipo { get; set; }
        public virtual Periferico Periferico { get; set; }
    }
}