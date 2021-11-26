using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Equipo
    {
        #region Atributes
        
        private int _codigo;
        private int _sn;
        private string _descripcion;
        private string _marca;
        private string _modelo;
        private Garantia _garantia;
        private Proveedor _proveedor;

        #endregion

        #region Constructores 

        public Equipo()
        {

        }


        public Equipo(int codigo, int serialnumber, string marca, string modelo,string descripcion,Garantia garantia,Proveedor proveedor)
        {
            Codigo = codigo;
            SerialNumber = serialnumber;
            Marca = marca;
            Modelo = modelo;
            Descripcion = descripcion;
            Garantia = garantia;
            Proveedor = proveedor;
        }


        public Equipo(Equipo aCopiar)
        {
            SerialNumber = aCopiar.SerialNumber;
            Marca = aCopiar.Marca;
            Modelo = aCopiar.Modelo;
            Descripcion = aCopiar.Descripcion;
            Garantia = aCopiar.Garantia;
            Proveedor = aCopiar.Proveedor;
        }

        #endregion
        #region Propiedades
        public Proveedor Proveedor { get { return _proveedor; } set { _proveedor = value; } }
        public int Codigo { get { return _codigo; } set { _codigo = value; }  }
        public int SerialNumber { get { return _sn; } set { _sn = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string Marca { get { return _marca; } set { _marca = value; } }
        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public Garantia Garantia { get { return _garantia;  } set { _garantia = value; } }
        #endregion


    }
}
