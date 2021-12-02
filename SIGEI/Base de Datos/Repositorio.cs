using SIGEI.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEI.Base_de_Datos
{
    public class Repositorio
    {
        private TiendaContext _context;

        //TODO:
        public Repositorio()
        {
            _context = new TiendaContext();
        }

        //Validar Usuario 
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            bool bandera = false;
            if (_context.Usuarios.ToList().Exists(x => x.Nick.Equals(usuario) && x.Contraseña.Equals(contraseña)))
            {
                bandera = true;
                return bandera;
            }

            return bandera;
        }

        //*************************Usuario**************************/
        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();
        }

        public Usuario BuscarUsuario(string usuario, string contraseña)
        {
            return _context.Usuarios.ToList().Find(x => x.Nick.Equals(usuario) && x.Contraseña.Equals(contraseña));
        }

        //public void EliminarUsuario(int codigo)
        //{
        //    int indiceEliminar = _context.Usuarios.ToList().FindIndex(x => x.Id == codigo);
        //    _context.Usuarios.Remove(indiceEliminar);
        //}

        //public void ModificarUsuario(int codigoActual, Usuario usuarioModificado)
        //{
        //    int indiceModificar = _usuarios.FindIndex(x => x.Empleado.DNI == codigoActual);
        //    _usuarios[indiceModificar] = usuarioModificado;
        //}

        public List<Usuario> FiltrarListaUsuarios(string terminoBusqueda)
        {
            return _context.Usuarios.ToList().FindAll(x => x.Nick.ToLower().Contains(terminoBusqueda?.ToLower()));
        }

        public List<Usuario> ObtenerListadeUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        //******************************Proveedores************************************************/

        public void AgregarProveedor(Proveedor nuevoProveedor)
        {
            _context.Proveedores.Add(nuevoProveedor);
            _context.SaveChanges();
        }

        public List<Proveedor> ObtenerTodosLosProveedores()
        {
            return _context.Proveedores.ToList();
        }



        //******************************Departamentos************************************************/

        public List<Departamento> ObtenerTodosLosDepartamentos()
        {
            return _context.Departamentos.ToList();
        }

        //******************************Empleados************************************************/

        public void AgregarEmpleado(Empleado nuevoEmpleado)
        {
            _context.Empleados.Add(nuevoEmpleado);
            _context.SaveChanges();
        }
        

    }
}
