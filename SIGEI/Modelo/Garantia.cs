using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Garantia
    {
        #region Atributes
        private DateTime _fechaAdquisicion;
        private DateTime _fechaFinalizacion;
        #endregion

        #region Constructores 
        public Garantia()
        {
            
        }

        public Garantia(DateTime fechaAdquisicion, DateTime fechaFinalizacion)
        {
            FechadeAdquisicion = fechaAdquisicion;
            FechaFinalizacion = fechaFinalizacion;
        }

        #endregion

        #region Propiedades
        public DateTime FechadeAdquisicion { get { return _fechaAdquisicion; } set { _fechaAdquisicion = value; } }
        public DateTime FechaFinalizacion { get { return _fechaFinalizacion; } set { _fechaFinalizacion = value; } }
        #endregion

    }
}
