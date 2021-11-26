using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Almacen
    {
        #region Atributos 
        private Estado _estado;
        private Equipo _equipo;
        private Periferico _periferico;
        #endregion

        #region Constructores 
        public Almacen()
        {

        }

        public Almacen(Periferico periferico, Estado estado)
        {
            Periferico = periferico;
            Estado = estado;
        }

        public Almacen(Equipo equipo, Estado estado)
        {
            Equipo = equipo;
            Estado = estado;
        }
        #endregion

        #region Propiedades
        public Equipo Equipo { get { return _equipo; } set { _equipo = value; } }
        public Periferico Periferico { get { return _periferico; } set { _periferico = value; } }
        public Estado Estado { get { return _estado;  } set { _estado = value; } }

        public Periferico GetPeriferico()
        {
            return Periferico;
        }

        public Equipo GetEquipo()
        {
            return Equipo;
        }

        public void CambiarEstado()
        {
           Estado = Estado.OCUPADO;
        }

  
        #endregion
    }
}
