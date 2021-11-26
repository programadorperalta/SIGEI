using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Auditoria
    {

        #region Atributes
        private int _codigo;
        private Object _entidad;
        private string _fecha;
        private string _hora;
        private string _datos;
        #endregion

        #region Constructores 
        public Auditoria()
        {

        }

        public Auditoria(int codigo, Object entidad, string datos)
        {
            Codigo = codigo;
            Entidad = entidad;
            Fecha = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            Hora = DateTime.Now.ToString("hh:mm:ss tt");
            Datos = datos; 
        }
        #endregion

        #region Propiedades
        public int Codigo { get { return _codigo; } set { _codigo = value; } } 
        public Object Entidad { get { return _entidad; } set { _entidad = value; } }
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Hora { get { return _hora; } set { _hora = value; }  } 
        public string Datos { get { return _datos; } set { _datos = value; } } 
        #endregion

    }
}
