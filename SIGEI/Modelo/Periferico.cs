using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Periferico
    {
        #region Atributes
        private int _codigo;
        private string _marca;
        private string _modelo;
        private string _descripcion;
        private int _sn;
        private Garantia _garantia;
        private Proveedor _proveedor;
        #endregion

        #region Constructores 
        public Periferico()
        {
            this.SerialNumber = 0;
        }

        public Periferico(int codigo, string marca, string modelo, string descripcion, int sn, Garantia garantia, Proveedor proveedor)
        {
            this.Codigo = codigo;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Descripcion = descripcion;
            this.SerialNumber = sn;
            this.Garantia = garantia;
            this.Proveedor = proveedor;
        }

        public Periferico(Periferico aCopiar)
        {
            this.Codigo = aCopiar.Codigo;
            this.Marca = aCopiar.Marca;
            this.Modelo = aCopiar.Modelo;
            this.Descripcion = aCopiar.Descripcion;
            this.SerialNumber = aCopiar.SerialNumber;
            this.Garantia = aCopiar.Garantia;
            this.Proveedor = aCopiar.Proveedor;
        }
        #endregion

        #region Propiedades
        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Marca { get { return _marca;  } set { _marca = value; } }
        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public int SerialNumber { get { return _sn; } set { _sn = value; } }
        public Garantia Garantia { get { return _garantia; } set { _garantia = value; } }
        public Proveedor Proveedor { get { return _proveedor; } set { _proveedor = value; } }
        #endregion
    }
}
