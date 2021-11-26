using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Empleado
    {
        #region Atributes
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private Departamento _departamento;
        #endregion

        #region Constructores 

        public Empleado()
        {

        }
        
        public Empleado(int legajo,string nombre, string apellido, int dni, Departamento departamento)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = Apellido;
            DNI = dni;
            Departamento = departamento;
        }


        #endregion

        #region Propiedades
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public int DNI { get { return _dni; } set { _dni = value; } }
        public Departamento Departamento { get { return _departamento; } set { _departamento = value; } }
        #endregion

    }
}
