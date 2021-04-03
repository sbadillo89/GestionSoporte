using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionSoporte.DAL;
using System.Data;
using GestionSoporte.ENT;

namespace GestionSoporte.BLL
{
    public class Gestionador_BLL
    {
        private Gestionador_DAL _gestionDAL;
        public string IdUsuario { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<Solicitud_ENT> solicitudes { get; set; }

        public Gestionador_BLL()
        {
            _gestionDAL = new Gestionador_DAL();
        }

        #region "Métodos y Funciones"   

        public DataTable ListarPerfilesUsu(int? codPerfil = null)
        {
            return _gestionDAL.ListarPerfilesUsu(codPerfil);
        }
        public bool RegistrarPerfil(int _codigo, string _nombre)
        {
            return _gestionDAL.RegistrarPerfil(_codigo, _nombre);
        }
        public DataTable ListarTipoDocumentos()
        {
            return _gestionDAL.ListarTipoDocumentos();
        }
        public bool RegistrarTipoDocumento(int _codigo, string _nombre)
        {
            return _gestionDAL.RegistrarTipoDocumento(_codigo, _nombre);
        }
        public List<Empleado_ENT> ListarEmpleados(string idEmp = null)
        {
            return _gestionDAL.ListarEmpleados(idEmp);
        }
        public bool RegistrarEmpleado(Empleado_ENT _empleado)
        {
            return _gestionDAL.RegistrarEmpleado(_empleado);
        }
        public Usuario_ENT CargarDatosUsuario(string idEmp)
        {
            return _gestionDAL.CargarDatosUsuario(idEmp);
        }
        public bool RegistrarUsuario(Usuario_ENT _usuario)
        {
            return _gestionDAL.RegistrarUsuario(_usuario);
        }

        public bool RegistrarTipoEquipo(int _codigo, string _nombre)
        {
            return _gestionDAL.RegistrarTipoEquipo(_codigo, _nombre);
        }
        public DataTable ListarTipoEquipos()
        {
            return _gestionDAL.ListarTipoEquipos();
        }

        public DataTable ListarComponentes()
        {
            return _gestionDAL.ListarComponentes();
        }
        public bool RegistrarComponente(int _codigo, string _nombre)
        {
            return _gestionDAL.RegistrarComponente(_codigo, _nombre);
        }

        public List<Ubicacion_ENT> ListarUbicaciones(int _codUbi = 0)
        {
            return _gestionDAL.ListarUbicaciones(_codUbi);
        }
        public bool RegistrarUbicacion(Ubicacion_ENT _ubicacion)
        {
            return _gestionDAL.RegistrarUbicacion(_ubicacion);
        }
        public int RetornarCodigoEquipo()
        {
            return _gestionDAL.RetornarCodigoEquipo();
        }
        public bool RegistrarEquipo(Equipo_ENT _equipo)
        {
            return _gestionDAL.RegistrarEquipo(_equipo);
        }
        public List<Equipo_ENT> ListarEquipos(int _codEquipo = 0)
        {
            return _gestionDAL.ListarEquipos(_codEquipo);
        }
        public DataTable ListarTipoSolicitud()
        {
            return _gestionDAL.ListarTipoSolicitud();
        }
        public bool RegistrarSolicitud(Solicitud_ENT _solicitud)
        {
            _gestionDAL.IdUsuario =TiposAnidado_ENT.usuarioLogueado.numeroDocumento;
            return _gestionDAL.RegistrarSolicitud(_solicitud);
        }
        public bool ListarSolicitudes(string _estado)
        {
            _gestionDAL.fechaInicial = fechaInicial;
            _gestionDAL.fechaFinal = fechaFinal;
            solicitudes = _gestionDAL.ListarSolicitudes(_estado);
            return Convert.ToBoolean(solicitudes.Count);
        }
        public bool RegistrarHistoria(HistoriaSolicitud_ENT _historia)
        {
            return _gestionDAL.RegistrarHistoria(_historia);
        }
        public List<HistoriaSolicitud_ENT> ListarHistorias(int codSolicitud)
        {
            return _gestionDAL.ListarHistorias(codSolicitud);
        }
        public bool ActualizarEstadoSolicitud(int codSolicitud, string estado)
        {
            return _gestionDAL.ActualizarEstadoSolicitud(codSolicitud,estado);
        }
        public bool DescartarEquipo(int codEquipo, string nota)
        {
            _gestionDAL.IdUsuario = TiposAnidado_ENT.usuarioLogueado.numeroDocumento;
            return _gestionDAL.DescartarEquipo(codEquipo,nota);
        }
        #endregion  "Métodos y Funciones"

    }
}
