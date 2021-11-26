using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Registro
    {
        #region Atributos
        private List<Periferico> _perifericos;
        private Equipo _equipo;
        private string _fecha;
        private string _hora;
        private string _vigencia;
        private Empleado _empleado;
        private Departamento _departamento;
        #endregion

        #region Constructores
        public Registro()
        {

        }
        
        public Registro(Equipo equipo, string vigencia, List<Periferico> perifericos,Empleado empleado,Departamento departamento)
        {
            Equipo = equipo;
            Perifericos = new List<Periferico>();
            Perifericos = perifericos;
            Fecha = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            Hora = DateTime.Now.ToString("hh:mm:ss tt");
            Vigencia = vigencia;
            Empleado = empleado;
            Departamento = departamento;
        }

        #endregion
        #region Propiedades
        public Departamento Departamento { get { return _departamento; } set { _departamento = value; } }
        public Empleado Empleado { get { return _empleado; } set { _empleado = value; } }
        public Equipo Equipo { get { return _equipo; } set { _equipo = value; } }
        public string Fecha { get { return _fecha; }  set { _fecha = value; } }
        public string Hora { get { return _hora; } set { _hora = value; }}
        public string Vigencia { get { return _vigencia; } set { _vigencia = value; } }
        public List<Periferico> Perifericos { get { return _perifericos; } set { _perifericos = value; } }
        #endregion



    }
}
