using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Proveedor
    {
        #region Atributes
        private string _nombre;
        private string _razonSocial;
        private string _cuit;
        #endregion

        #region Constructores
        public Proveedor()
        {

        }
        public Proveedor(string nombre, string razonSocial, string cuit)
        {
            this.Nombre = nombre;
            this.RazonSocial = razonSocial;
            this.Cuit = cuit;
            
        }

        public Proveedor(Proveedor aCopiar)
        {
            this.Nombre = aCopiar.Nombre;
            this.RazonSocial = aCopiar.RazonSocial;
            this.Cuit = aCopiar.Cuit;
        }
        #endregion

        #region Propiedades
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string RazonSocial { get { return _razonSocial; } set { _razonSocial = value; } }
        public string Cuit { get { return _cuit; } set { _cuit = value; } }

        #endregion
    }
}
