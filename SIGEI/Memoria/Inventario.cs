using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIGEI
{
    //public class Inventario
    //{
       
    //    /*************************************************************/
    //    private List<Equipo> _equipos = new List<Equipo>();
    //    private List<Periferico> _perifericos = new List<Periferico>();
    //    private List<Usuario> _usuarios = new List<Usuario>();
    //    private List<Departamento> _departamentos = new List<Departamento>();
    //    private List<Auditoria> _auditorias = new List<Auditoria>();
    //    private List<Empleado> _empleados = new List<Empleado>();
    //    private List<Rol> _roles = new List<Rol>();
    //    private List<Almacen> _almacen = new List<Almacen>();
    //    private List<Registro> _registro = new List<Registro>();
    //    private List<Proveedor> _proveedores = new List<Proveedor>();
    //    private List<Garantia> _garantias = new List<Garantia>();
    //    /*************************************************************/

        
    //    //Inicializar la instancia de inventario.
    //    public Inventario()
    //    {
    //        CargarDepartamentos();
    //        CrearPerifericos();
    //        CargarAlmacen();
    //        CargarRoles();
    //        CargarEmpleados();
    //        CrearUsuarios();
    //        CargarProveedores();
    //        CargarGarantias();
    //    }

    //    public void CargarDepartamentos()
    //    {
    //        _departamentos.Add(new Departamento(1,"Contabilidad"));
    //        _departamentos.Add(new Departamento(2,"Sistemas"));
    //        _departamentos.Add(new Departamento(3,"Ventas"));
    //        _departamentos.Add(new Departamento(4,"Direccion"));
    //        _departamentos.Add(new Departamento(5,"Administracion"));

    //    }

    //    public List<Departamento> GetDepartamentos()
    //    {
    //        return _departamentos.ToList();
    //    }

    //    public void AgregarDepartamento(Departamento departamento)
    //    {
    //        _departamentos.Add(departamento);
    //    }


    //    public void CrearEquipos()
    //    {
    //        _equipos.Add(new Equipo(01, 88887712, "Red Dragon", "2020", "GABINETE + PLACA MADRE XXX + FUENTE 600W", new Garantia(DateTime.Parse("2020-11-25"), DateTime.Parse("2022-11-25")), new Proveedor("Compumaq", "Responsable Inscripto", "24710035748")));
    //        _equipos.Add(new Equipo(02, 123123123, "Red Dragon", "2021", "GABINETE + PLACA MADRE YYY + FUENTE 550W", new Garantia(DateTime.Parse("2022-11-25"), DateTime.Parse("2025-11-25")), new Proveedor("Compumaq", "Responsable Inscripto", "24710035748")));
    //    }

    //    public List<Periferico> GetPerifericos()
    //    {
    //        return _perifericos.ToList();
    //    }

    //    public void CrearPerifericos()
    //    {
    //        _perifericos.Add(new Periferico(0001,"Red Dragon","2020","Mouse Inalambrico", 73568424,new Garantia(DateTime.Parse("2020-11-25"),DateTime.Parse("2022-11-25")),new Proveedor("Compumaq","Responsable Inscripto", "24710035748")));
    //        _perifericos.Add(new Periferico(0002, "Red Dragon", "2020", "Teclado Inalambrico",32869383, new Garantia(DateTime.Parse("2020-12-25"), DateTime.Parse("2022-12-25")), new Proveedor("Compumaq", "Responsable Inscripto", "24710035748")));
    //        _perifericos.Add(new Periferico(0003, "Philco", "2020", "Monitor 21' ",26665334, new Garantia(DateTime.Parse("2020-12-25"), DateTime.Parse("2022-12-25")), new Proveedor("Compumaq", "Responsable Inscripto", "24710035748")));
    //    }
        
    //    public void CargarAlmacen()
    //    {
    //        _almacen.Add(new Almacen(_perifericos.Find(x=>x.Codigo==0001), Estado.LIBRE));
    //        _almacen.Add(new Almacen(_perifericos.Find(x=>x.Codigo==0002), Estado.LIBRE));
    //        _almacen.Add(new Almacen(_perifericos.Find(x=>x.Codigo==0003), Estado.LIBRE));
    //        _almacen.Add(new Almacen(_equipos.Find(x=> x.Codigo==01), Estado.LIBRE));
    //        _almacen.Add(new Almacen(_equipos.Find(x=> x.Codigo==02), Estado.LIBRE));
    //    }

    //    public void CargarRoles()
    //    {
    //        _roles.Add(new Rol("ADMINISTRADOR","ENCARGADO DE REALIZAR LA GESTION DE LOS DEPARTAMENTOS, USUARIOS y ROLES"));
    //        _roles.Add(new Rol("RECEPCIONISTA", "ENCARGADO DE LA GESTION DE EQUIPOS Y PERIFERICOS"));
    //    }

    //    public void CargarEmpleados()
    //    {
    //        _empleados.Add(new Empleado(46241,"Nahuel Gaston","Valdez Peralta",40087254,_departamentos.Find(x=>x.ID==1)));
    //        _empleados.Add(new Empleado(46242, "Juan Agustin", "Lopez", 39888243, _departamentos.Find(x => x.ID == 2)));

    //    }

    //    public void CargarProveedores()
    //    {
    //        _proveedores.Add(new Proveedor("Compumaq", "Responsable Inscripto", "24710035748"));
    //    }

    //    public List<Proveedor> GetProveedores()
    //    {
    //        return _proveedores.ToList();
    //    }

    //    public void CargarGarantias()
    //    {
    //        _garantias.Add(new Garantia(DateTime.Parse("2020-11-25"), DateTime.Parse("2022-11-25")));
    //    }

    //    public List<Garantia> GetGarantias()
    //    {
    //        return _garantias.ToList();
    //    }
        


    //    public void CrearUsuarios()
    //    {
    //        _usuarios.Add(new Usuario("NAHUELPERALTA","nahu123",_roles.Find(x=>x.Nombre.Equals("RECEPCIONISTA")),_empleados.Find(x=>x.DNI==40087254)));
    //        _usuarios.Add(new Usuario("JUANLOPEZ", "juan123", _roles.Find(x => x.Nombre.Equals("ADMINISTRATIVO")), _empleados.Find(x => x.DNI == 39888243)));
    //    }

    //    public void CrearRegistros()
    //    {
    //        var listaTemporal = new List<Periferico>
    //        {
    //            new Periferico(_almacen.Find(x => x.Periferico.Codigo == 001 && x.Estado == Estado.LIBRE).GetPeriferico()),
    //            new Periferico(_almacen.Find(x => x.Periferico.Codigo == 002 && x.Estado == Estado.LIBRE).GetPeriferico())
    //        };

    //        _registro.Add(new Registro(_almacen.Find(x => x.Equipo.Codigo == 01 && x.Estado == Estado.LIBRE).GetEquipo(), "19:53", listaTemporal, _empleados.Find(x => x.Legajo == 46241),_departamentos.Find(x=>x.ID==1)));

    //        //Actualizar el Almacen 
    //        foreach (Almacen a in _almacen)
    //        {
    //            foreach (Periferico p in listaTemporal)
    //            {
    //                if (a.Periferico.Codigo == p.Codigo)
    //                {
    //                    a.CambiarEstado();
                        
    //                }
    //            }

    //            foreach (Registro r in _registro)
    //            {
    //                if (a.Equipo.Codigo == r.Equipo.Codigo)
    //                {
    //                    a.CambiarEstado();

    //                }
    //            }
    //        }
    //    }

    //    public void LiberarEquipoyPeriferico() //--> esta enlazado a un evento. 
    //    {
    //       //traer el registro.

    //       //obtener el almacen y cambiarle de estado tanto al equipo como al periferico.
    //    }


    //    /*************************ABM Usuario**************************/
    //    public void AgregarUsuario(Usuario nuevoUsuario)
    //    {
    //        _usuarios.Add(nuevoUsuario);
    //    }

    //    public Usuario BuscarUsuario(string usuario, string contraseña)
    //    {
    //        return _usuarios.Find(x => x.UserName.Equals(usuario) && x.Password.Equals(contraseña));
    //    }

    //    public void EliminarUsuario(int codigo)
    //    {
    //        int indiceEliminar = _usuarios.FindIndex(x => x.Empleado.DNI == codigo);
    //        _perifericos.RemoveAt(indiceEliminar);
    //    }

    //    public void ModificarUsuario(int codigoActual, Usuario usuarioModificado)
    //    {
    //        int indiceModificar = _usuarios.FindIndex(x => x.Empleado.DNI == codigoActual);
    //        _usuarios[indiceModificar] = usuarioModificado;
    //    }

    //    public List<Usuario> FiltrarListaUsuarios(string terminoBusqueda)
    //    {
    //        return _usuarios.FindAll(x => x.UserName.ToLower().Contains(terminoBusqueda?.ToLower()));
    //    }

    //    public List<Usuario> ObtenerListadeUsuarios()
    //    {
    //        return _usuarios.ToList();
    //    }

    //    /******************************************************************************/


    //    /************************************ABM Periferico****************************/
    //    public void AgregarPeriferico(Periferico nuevoPeriferico)
    //    {
    //        _perifericos.Add(nuevoPeriferico);
    //    }

    //    public void EliminarPeriferico(int codigo)
    //    {
    //        int indiceEliminar = _perifericos.FindIndex(x => x.Codigo == codigo);
    //        _perifericos.RemoveAt(indiceEliminar);
    //    }

    //    public void ModificarPeriferico(int codigoActual,Periferico perifericoModificado)
    //    {
    //        int indiceModificar = _perifericos.FindIndex(x => x.Codigo == codigoActual);
    //        _perifericos[indiceModificar] = perifericoModificado;
    //    }

    //    public Periferico BuscarPeriferico(int codigo)
    //    {
    //        return _perifericos.Find(x => x.Codigo == codigo);
    //    }
        
    //    public List<Periferico> FiltrarListaPerifericos(string terminoBusqueda)
    //    {
    //        return _perifericos.FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
    //    }

    //    public List<Periferico> ObtenerListadePerifericos()
    //    {
    //        return _perifericos.ToList();
    //    }
    //    /************************************************************************************/
    //    public void AgregarAuditoria(Auditoria nuevaAuditoria)
    //    {
    //        _auditorias.Add(nuevaAuditoria);
    //    }

    //    public Auditoria BuscarAuditoria(int codigo)
    //    {
    //        return _auditorias.Find(x => x.Codigo == codigo);
    //    }

    //    public List<Auditoria> FiltrarListaAuditorias(string terminoBusqueda)
    //    {
    //        return _auditorias.FindAll(x => x.Datos.ToLower().Contains(terminoBusqueda?.ToLower()));
    //    }

    //    public List<Auditoria> ObtenerListadeAuditorias()
    //    {
    //        return _auditorias.ToList();
    //    }
    //    /**********************************************************************************************/
    //    public void AgregarEquipoInformatico(Equipo nuevoEquipoInformatico)
    //    {
    //        _equipos.Add(nuevoEquipoInformatico);
    //    }

    //    public Equipo BuscarEquipo(int codigo)
    //    {
    //        return _equipos.Find(x => x.Codigo == codigo);
    //    }

    //    public void EliminarEquipo(int codigo)
    //    {
    //        int indiceEliminar = _equipos.FindIndex(x => x.Codigo == codigo);
    //        _equipos.RemoveAt(indiceEliminar);
    //    }

    //    public void ModificarEquipo(int codigoActual, Equipo equipoModificado)
    //    {
    //        int indiceModificar = _equipos.FindIndex(x => x.Codigo == codigoActual);
    //        _equipos[indiceModificar] = equipoModificado;
    //    }

    //    public List<Equipo> FiltrarListaEquipos(string terminoBusqueda)
    //    {
    //        return _equipos.FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
    //    }

    //    public List<Equipo> ObtenerListadeEquipos()
    //    {
    //        return _equipos.ToList();
    //    }
    //    /************************************************************************/

    //    public bool ValidarUsuario(string usuario, string contraseña)
    //    {
    //        bool bandera = false;
    //        if (_usuarios.Exists(x=>x.UserName.Equals(usuario) && x.Password.Equals(contraseña)))
    //        {
    //            bandera = true;
    //            return bandera;
    //        }

    //        return bandera;
    //    }


    //}
}
