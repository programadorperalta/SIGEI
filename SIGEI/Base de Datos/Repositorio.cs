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

        public void EliminarUsuario(int codigo)
        {
            _context.Usuarios.Remove(_context.Usuarios.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }

        public List<Usuario> FiltrarListaUsuarios(string terminoBusqueda)
        {
            return _context.Usuarios.ToList().FindAll(x => x.Nick.ToLower().Contains(terminoBusqueda?.ToLower()));
        }

        public List<Usuario> ObtenerListadeUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public void ModificarUsuario(int codigoActual, Usuario usuarioModificado)
        {

            if (codigoActual != usuarioModificado.Id && YaExisteUsuario(usuarioModificado.Id)) throw new Exception("Ya existe un usuario con este codigo.");

            var usuario = BuscarUsuario(codigoActual);

            if (usuario != null)
            {
                usuario.Contraseña = usuarioModificado.Contraseña;
                usuario.Nick = usuarioModificado.Nick;
                usuario.Permiso = usuarioModificado.Permiso;

            }

            _context.SaveChanges();
        }

        private bool YaExisteUsuario(int codigoConsulta)
        {
            return _context.Usuarios.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public Usuario BuscarUsuario(int codigo)
        {
            return _context.Usuarios.ToList().Find(x => x.Id == codigo);
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

        public void EliminarProveedor(int codigo)
        {
            _context.Proveedores.Remove(_context.Proveedores.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }

        public void ModificarProveedor(int codigoActual, Proveedor proveedorModificado)
        {

            if (codigoActual != proveedorModificado.Id && YaExisteProveedor(proveedorModificado.Id)) throw new Exception("Ya existe un proveedor con este codigo.");

            var proveedor= BuscarProveedor(codigoActual);

            if (proveedor != null)
            {
                proveedor.Cuit = proveedorModificado.Cuit;
                proveedor.Nombre = proveedorModificado.Nombre;
                proveedor.RazonSocial = proveedorModificado.RazonSocial;

            }

            _context.SaveChanges();
        }

        private bool YaExisteProveedor(int codigoConsulta)
        {
            return _context.Proveedores.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public Proveedor BuscarProveedor(int codigo)
        {
            return _context.Proveedores.ToList().Find(x => x.Id == codigo);
        }




        //******************************Departamentos************************************************/
        public void AgregarDepartamento(Departamento nuevoDepartamento)
        {
            _context.Departamentos.Add(nuevoDepartamento);
            _context.SaveChanges();
        }

        public List<Departamento> ObtenerTodosLosDepartamentos()
        {
            return _context.Departamentos.ToList();
        }

        public void EliminarDepartamento(int codigo)
        {
            _context.Departamentos.Remove(_context.Departamentos.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }

        public void ModificarDepartamento(int codigoActual, Departamento departamentoModificado)
        {

            if (codigoActual != departamentoModificado.Id && YaExisteDepartamento(departamentoModificado.Id)) throw new Exception("Ya existe un departamento con este codigo.");

            var departamento = BuscarDepartamento(codigoActual);

            if (departamento!=null)
            {
                departamento.Nombre = departamentoModificado.Nombre;
               
            }

            _context.SaveChanges();
        }

        private bool YaExisteDepartamento(int codigoConsulta)
        {
            return _context.Departamentos.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public Departamento BuscarDepartamento(int codigo)
        {
            return _context.Departamentos.ToList().Find(x => x.Id == codigo);
        }


        //******************************Empleados************************************************/

        public void AgregarEmpleado(Empleado nuevoEmpleado)
        {
            _context.Empleados.Add(nuevoEmpleado);
            _context.SaveChanges();
        }

        public Empleado BuscarEmpleado(int legajo)
        {
            var empleado = _context.Empleados.ToList().Find(x => x.Legajo == legajo);
            if (empleado!=null) { return empleado; };
            return null;
        }

        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            return _context.Empleados.ToList();
        }

        public void EliminarEmpleado(int codigo)
        {
            _context.Empleados.Remove(_context.Empleados.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }


        public void ModificarEmpleado(int codigoActual, Empleado empleadoModificado)
        {

            if (codigoActual != empleadoModificado.Id && YaExisteEmpleado(empleadoModificado.Id)) throw new Exception("Ya existe un empleado con este codigo.");

            var empleado = BuscarEmpleado2(codigoActual);

            if (empleado != null)
            {
                empleado.Nombre = empleadoModificado.Nombre;
                empleado.Apellido = empleadoModificado.Apellido;
                empleado.Dni = empleadoModificado.Dni;
                empleado.Departamento = empleadoModificado.Departamento;
                empleado.Equipo = empleadoModificado.Equipo;
            }

            _context.SaveChanges();
        }

        public Empleado BuscarEmpleado2(int codigo)
        {
            return _context.Empleados.ToList().Find(x => x.Id == codigo);
        }


        private bool YaExisteEmpleado(int codigoConsulta)
        {
            return _context.Empleados.ToList().Exists(x => x.Id == codigoConsulta);
        }

        //******************************Equipos************************************************/

        public void AgregarEquipo(Equipo nuevoEquipo)
        {
            _context.Equipos.Add(nuevoEquipo);
            _context.SaveChanges();
        }

        public List<Equipo> ObtenerTodosLosEquipos()
        {
            return _context.Equipos.ToList();
        }

        public Equipo BuscarEquipo(string numerodeserie)
        {
            var equipo = _context.Equipos.ToList().Find(x => x.SerielNumber.Equals(numerodeserie));
            if (equipo != null) { return equipo; };
            return null;
        }

        public void EliminarEquipo(int codigo)
        {
            _context.Equipos.Remove(_context.Equipos.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }


        public void ModificarEquipo(int codigoActual, Equipo equipoModificado)
        {

            if (codigoActual != equipoModificado.Id && YaExisteEquipo(equipoModificado.Id)) throw new Exception("Ya existe un equipo con este codigo.");

            var equipo = BuscarEquipo1(codigoActual);

            if (equipo != null)
            {
                equipo.Description = equipoModificado.Description;
                equipo.Marca = equipoModificado.Marca;
                equipo.Model = equipoModificado.Model;
                equipo.SerielNumber = equipoModificado.SerielNumber;
                equipo.Proveedor = equipoModificado.Proveedor;
                equipo.Departamento = equipoModificado.Departamento;
                equipo.FechaAlta = equipoModificado.FechaAlta;
                equipo.FechaVencimientoGarantia = equipoModificado.FechaVencimientoGarantia;

            }

            _context.SaveChanges();
        }

        private bool YaExisteEquipo(int codigoConsulta)
        {
            return _context.Equipos.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public Equipo BuscarEquipo1(int codigo)
        {
            return _context.Equipos.ToList().Find(x => x.Id == codigo);
        }

        //******************************Perifericos************************************************/

        public void AgregarPeriferico(Periferico nuevoPeriferico)
        {
            _context.Periferico.Add(nuevoPeriferico);
            _context.SaveChanges();
        }

        public List<Periferico> ObtenerTodosLosPerifericos()
        {
            return _context.Periferico.ToList();
        }

        public void EliminarPeriferico(int codigo)
        {
            _context.Periferico.Remove(_context.Periferico.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }

        public void ModificarPeriferico(int codigoActual, Periferico perifericoModificado)
        {

            if (codigoActual != perifericoModificado.Id && YaExistePeriferico(perifericoModificado.Id)) throw new Exception("Ya existe un periferico con este codigo.");

            var periferico = BuscarPeriferico(codigoActual);

            if (periferico != null)
            {
                periferico.Descripcion = perifericoModificado.Descripcion;
                periferico.Marca = perifericoModificado.Marca;
                periferico.Modelo = perifericoModificado.Modelo;
                periferico.NumeroDeSerie = perifericoModificado.NumeroDeSerie;
                periferico.Proveedor = perifericoModificado.Proveedor;
                periferico.FechaAlta = perifericoModificado.FechaAlta;
                periferico.FechaVencimientoGarantia = perifericoModificado.FechaVencimientoGarantia;
                
            }

            _context.SaveChanges();
        }

        private bool YaExistePeriferico(int codigoConsulta)
        {
            return _context.Periferico.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public Periferico BuscarPeriferico(int codigo)
        {
            return _context.Periferico.ToList().Find(x => x.Id == codigo);
        }



        //******************************Equipo-Perifericos************************************************/

        public void AgregarEquipoPerifericos(EquipoPeriferico nuevoEquipoPeriferico)
        {
            _context.EquipoPerifericos.Add(nuevoEquipoPeriferico);
            _context.SaveChanges();
        }

        public List<EquipoPeriferico> ListaDePerifericosAsignados(string serialNumber)
        {
            return _context.EquipoPerifericos.ToList().FindAll(x=>x.Equipo.SerielNumber.Equals(serialNumber));

        }


        public void EliminarEquipoPeriferico(int codigo)
        {
            _context.EquipoPerifericos.Remove(_context.EquipoPerifericos.SingleOrDefault(d => d.Id == codigo));
            _context.SaveChanges();
        }

        public void ModificarEquipoPerifericos(int codigoActual, EquipoPeriferico equipoPerifericoModificado)
        {

            if (codigoActual != equipoPerifericoModificado.Id && YaExisteEquipoPeriferico(equipoPerifericoModificado.Id)) throw new Exception("Ya existe un equipo-periferico con este codigo.");

            var equipoperiferico = BuscarEquipoPeriferico(codigoActual);

            if (equipoperiferico != null)
            {
                equipoperiferico.Periferico = equipoPerifericoModificado.Periferico;
                equipoperiferico.FechaAlta = equipoPerifericoModificado.FechaAlta;
                equipoperiferico.FechaBaja = equipoPerifericoModificado.FechaBaja;
                equipoperiferico.Equipo = equipoperiferico.Equipo;
            }

            _context.SaveChanges();
        }

        private bool YaExisteEquipoPeriferico(int codigoConsulta)
        {
            return _context.EquipoPerifericos.ToList().Exists(x => x.Id == codigoConsulta);
        }


        public EquipoPeriferico BuscarEquipoPeriferico(int codigo)
        {
            return _context.EquipoPerifericos.ToList().Find(x => x.Id == codigo);
        }





        //******************************Auditoria************************************************/
        public void AgregarAuditoria(Auditoria nuevaAuditoria)
        {
            _context.Auditorias.Add(nuevaAuditoria);
            _context.SaveChanges();
        }
        public List<Auditoria> ObtenerTodasLasAuditorias()
        {
            return _context.Auditorias.ToList();
        }

        public List<Auditoria> FiltrarListaAuditorias(string terminoBusqueda)
        {
            return _context.Auditorias.ToList().FindAll(x => x.Entidad.ToLower().Contains(terminoBusqueda?.ToLower()));
        }


    }
}
