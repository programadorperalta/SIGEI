using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Rol
    {
        #region Atributes
        private string _nombre;
        private string _descripcion;
        #endregion

        #region Constructores
        public Rol()
        {

        }

        public Rol(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        #endregion

        #region Propiedades
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        #endregion
    }
}
