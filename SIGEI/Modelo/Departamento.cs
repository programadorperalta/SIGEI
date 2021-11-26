using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Departamento
    {
        #region Atributes
        private int _id;
        private string _nombre;
        #endregion

        #region Constructores 
        public Departamento()
        {

        }

        public Departamento(int id,  string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
        #endregion

        #region Propiedades
        public int ID { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        #endregion

    }
}
