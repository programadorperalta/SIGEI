using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI
{
    public class Usuario
    {
        #region Atributos 
        private string _username;
        private string _password;
        private Rol _rol;
        private Empleado _empleado;
        #endregion


        #region Constructores

        public Usuario()
        {

        }

        public Usuario(string username, string password,Rol rol, Empleado empleado)
        {
            this.UserName = username;
            this.Password = password;
            this.Rol = rol;
            this.Empleado = empleado;

        }

        public Usuario(Usuario aCopiar)
        {
            this.UserName = aCopiar.UserName;
            this.Password = aCopiar.Password;
            this.Rol = aCopiar.Rol;
            this.Empleado = aCopiar.Empleado;
        }
        #endregion

        #region Propiedades
        public string UserName { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } } 
        public Rol Rol { get { return _rol; } set { _rol = value; } }
        public Empleado Empleado { get { return _empleado; } set { _empleado = value; } }
        #endregion

    }
}
