using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexion;
using System.Data;
using GestionSoporte.ENT;

namespace GestionSoporte.DAL
{
    public class Gestionador_DAL
    {
        DBConexion _conex;
        string _nomConex;
        public string IdUsuario { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public Gestionador_DAL()
        {
            _nomConex = "Gestion";
        }

        #region "Métodos y Funciones"

        public DataTable ListarPerfilesUsu(int? codPerfil = null)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("PER_ListarPerfiles", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@CodPerfil", codPerfil);
                _conex.LLenarDataTable(dt);
                return dt;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarPerfil(int _codigo, string _nombre)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("PER_RegistrarPerfil", DBConexion.TipoComando.StoredProcedure);
                if (_codigo != 0) { _conex.AgregarParameters("@codPerfil", _codigo); }
                _conex.AgregarParameters("@Nombre", _nombre);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public DataTable ListarTipoDocumentos()
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("TDO_ListarTipoDoc", DBConexion.TipoComando.StoredProcedure);
                _conex.LLenarDataTable(dt);
                return dt;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarTipoDocumento(int _codigo, string _nombre)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("TDO_RegistrarTipoDoc", DBConexion.TipoComando.StoredProcedure);
                if (_codigo != 0) { _conex.AgregarParameters("@codTipo", _codigo); }
                _conex.AgregarParameters("@Nombre", _nombre);
                _conex.AgregarParameters("@Estado", "ACT");
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarEmpleado(Empleado_ENT _empleado)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("EMP_RegistrarEmpleado", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@tipoDoc", _empleado.idTipoDocumento);
                _conex.AgregarParameters("@IdEmp", _empleado.numeroDocumento);
                _conex.AgregarParameters("@pNombre", _empleado.primerNombre);
                _conex.AgregarParameters("@sNombre", _empleado.segundoNombre);
                _conex.AgregarParameters("@pApellido", _empleado.primerApellido);
                _conex.AgregarParameters("@sApellido", _empleado.segundoApellido);
                _conex.AgregarParameters("@Direccion", _empleado.direccion);
                _conex.AgregarParameters("@telefono", _empleado.telefono);
                _conex.AgregarParameters("@fechaNac", _empleado.fechaNacimiento);
                _conex.AgregarParameters("@correo", _empleado.correo);
                _conex.AgregarParameters("@Estado", _empleado.estado);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public List<Empleado_ENT> ListarEmpleados(string idEmp = null)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("EMP_ListarEmpleado", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@IdEmp", idEmp);
                _conex.LLenarDataTable(dt);

                return dt.Rows.Cast<DataRow>().ToList().Select(e =>
                        new Empleado_ENT()
                        {
                            idTipoDocumento = Convert.ToInt32(e["Codigo_TDO"]),
                            numeroDocumento = e["Identificacion_Emp"].ToString(),
                            primerNombre = e["PrimerNombre_Emp"].ToString(),
                            segundoNombre = e["SegundoNombre_Emp"].ToString(),
                            primerApellido = e["PrimerApellido_Emp"].ToString(),
                            segundoApellido = e["SegundoApellido_Emp"].ToString(),
                            direccion = e["Direccion_Emp"].ToString(),
                            telefono = e["Telefono_Emp"].ToString(),
                            estado = e["Estado_Emp"].ToString(),
                            correo = e["Correo_Emp"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(e["FechaNacimiento_Emp"]),
                            fechaRegistro = Convert.ToDateTime(e["FechaRegistro_Emp"])
                        }).ToList();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarUsuario(Usuario_ENT _usuario)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("USU_RegistrarUsuario", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@codPerfil", _usuario.idPerfil);
                _conex.AgregarParameters("@idEmp", _usuario.numeroDocumento);
                _conex.AgregarParameters("@password", _usuario.contraseña);
                _conex.AgregarParameters("@Estado", _usuario.estado);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public Usuario_ENT CargarDatosUsuario(string idEmp)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("USU_ListarUsuarios", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@IdEmp", idEmp);
                _conex.LLenarDataTable(dt);

                return (dt.Rows.Cast<DataRow>().ToList().Select(e =>
                        new Usuario_ENT()
                        {
                            codigoUsuario = Convert.ToInt32(e["Codigo_USR"]),
                            idPerfil = Convert.ToInt32(e["Codigo_PER"]),
                            numeroDocumento = e["Identificacion_Emp"].ToString(),
                            contraseña = e["Contraseña_USR"].ToString(),
                            estado = e["Estado_USR"].ToString(),
                            perfil = e["Nombre_PER"].ToString()
                        }).FirstOrDefault());
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public DataTable ListarTipoEquipos()
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("TPE_ListarTiposEquipo", DBConexion.TipoComando.StoredProcedure);
                _conex.LLenarDataTable(dt);
                return dt;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarTipoEquipo(int _codigo, string _nombre)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("TPE_RegistrarTipoEquipo", DBConexion.TipoComando.StoredProcedure);
                if (_codigo != 0) { _conex.AgregarParameters("@codigo", _codigo); }
                _conex.AgregarParameters("@Nombre", _nombre);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public DataTable ListarComponentes()
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("CPT_ListarComponentes", DBConexion.TipoComando.StoredProcedure);
                _conex.LLenarDataTable(dt);
                return dt;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarComponente(int _codigo, string _nombre)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("CPT_RegistrarComponente", DBConexion.TipoComando.StoredProcedure);
                if (_codigo != 0) { _conex.AgregarParameters("@codigo", _codigo); }
                _conex.AgregarParameters("@Nombre", _nombre);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public List<Ubicacion_ENT> ListarUbicaciones(int _codUbi)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("UBI_ListarUbicaciones", DBConexion.TipoComando.StoredProcedure);
                if (_codUbi != 0) { _conex.AgregarParameters("@codUbi", _codUbi); }
                _conex.LLenarDataTable(dt);
                return (from row in dt.Rows.Cast<DataRow>().ToList()
                        select new Ubicacion_ENT()
                        {
                            codigo = Convert.ToInt32(row["Codigo_Ubi"]),
                            nombre = row["Nombre_Ubi"].ToString(),
                            direccion = row["Direccion_Ubi"].ToString(),
                            telefono = row["Telefono_Ubi"].ToString(),
                            estado = row["Estado_Ubi"].ToString()
                        }).ToList();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarUbicacion(Ubicacion_ENT _ubicacion)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("UBI_CrearUbicacion", DBConexion.TipoComando.StoredProcedure);
                if (_ubicacion.codigo != 0) { _conex.AgregarParameters("@codUbi", _ubicacion.codigo); }
                _conex.AgregarParameters("@Nombre", _ubicacion.nombre);
                _conex.AgregarParameters("@Direccion", _ubicacion.direccion);
                _conex.AgregarParameters("@Telefono", _ubicacion.telefono);
                _conex.AgregarParameters("@estado", _ubicacion.estado);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public int RetornarCodigoEquipo()
        {
            DBConexion _conexion = new DBConexion(_nomConex);
            try
            {
                int _codigo = 0;
                _conexion.Abrir();
                _conexion.SetAdapter("select IDENT_CURRENT('Equipo')Codigo", DBConexion.TipoComando.ComandText);
                System.Data.Common.DbDataReader _reader = _conexion.Leer();
                if (_reader.Read())
                {
                    _codigo = Convert.ToInt32(_reader["Codigo"]);
                }
                _reader.Close();
                return _codigo;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conexion.Cerrar(); }
        }
        public List<Equipo_ENT> ListarEquipos(int _codEquipo = 0)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("EQP_ListarEquipos", DBConexion.TipoComando.StoredProcedure);
                if (_codEquipo != 0) { _conex.AgregarParameters("@codEquipo", _codEquipo); }
                _conex.LLenarDataTable(dt);
                var equipos = (from row in dt.Rows.Cast<DataRow>().ToList()
                               select new Equipo_ENT()
                               {
                                   codigo = Convert.ToInt32(row["Codigo_EQP"]),
                                   codigoUbicacion = Convert.ToInt32(row["Codigo_UBI"]),
                                   codigoTipoEquipo = Convert.ToInt32(row["Codigo_TPE"]),
                                   empleadoEncargado = row["IdResponsable_EQP"].ToString(),
                                   descripcion = row["Descripcion_EQP"].ToString(),
                                   fechaCreacion = Convert.ToDateTime(row["FechaRegistro_EQP"]),
                                   estado = row["Estado_EQP"].ToString(),
                                   nombreEmpleado = row["empleado"].ToString(),
                                   nombreUbicacion = row["ubicacion"].ToString(),
                                   tipoEquipo = row["tipoEquipo"].ToString(),
                                   etiqueta = row["Etiqueta_EQP"] == null ? "" : row["Etiqueta_EQP"].ToString(),
                                   serial = row["Serial_EQP"] == null ? "" : row["Serial_EQP"].ToString(),
                                   marca = row["Marca_EQP"] == null ? "" : row["Marca_EQP"].ToString()
                               }).ToList();

                //Llenamos los detalles
                dt = new DataTable();
                _conex.SetAdapter("EQD_ListarDetallesEquipo", DBConexion.TipoComando.StoredProcedure);
                //if (_codEquipo != 0) { _conex.AgregarParameters("@codDetalle", _codEquipo); }
                _conex.LLenarDataTable(dt);
                var detalles = (from row in dt.Rows.Cast<DataRow>().ToList()
                                select new EquipoDetalle_ENT()
                                {
                                    codigo = Convert.ToInt32(row["Codigo_EQD"]),
                                    codigoComponente = Convert.ToInt32(row["Codigo_CPT"]),
                                    codigoEquipo = Convert.ToInt32(row["Codigo_EQP"]),
                                    marca = row["Marca_EQD"].ToString(),
                                    modelo = row["Modelo_EQD"].ToString(),
                                    serial = row["Serial_EQD"].ToString(),
                                    datoAdicional = row["Dato_EQD"] == DBNull.Value ? "" : row["Dato_EQD"].ToString(),
                                    estado = row["Estado_EQD"].ToString()
                                }).ToList();
                equipos.ForEach(e => e.detalles = detalles.FindAll(d => d.codigoEquipo == e.codigo));
                return equipos;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarEquipo(Equipo_ENT _equipo)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                int _codEquipo;

                _conex.SetAdapter("EQP_RegistrarEquipo", DBConexion.TipoComando.StoredProcedure);
                if (_equipo.codigo != 0) { _conex.AgregarParameters("@codEquipo", _equipo.codigo); }
                _conex.AgregarParameters("@codUbicacion", _equipo.codigoUbicacion);
                _conex.AgregarParameters("@codTipoEquipo", _equipo.codigoTipoEquipo);
                _conex.AgregarParameters("@Responsable", _equipo.empleadoEncargado);
                _conex.AgregarParameters("@descripcion", _equipo.descripcion);
                _conex.AgregarParameters("@estado", _equipo.estado); 
                _conex.AgregarParameters("@etiqueta", _equipo.etiqueta);
                _conex.AgregarParameters("@serial", _equipo.serial);
                _conex.AgregarParameters("@marca", _equipo.marca);

                if (!_conex.Ejecutar()) { return false; } 
                _codEquipo = _equipo.codigo != 0 ? _equipo.codigo : RetornarCodigoEquipo();

                foreach (var _detalle in _equipo.detalles)
                {
                    _conex.SetAdapter("EQD_RegistrarDetalleEquipo", DBConexion.TipoComando.StoredProcedure);
                    if (_detalle.codigo != 0) { _conex.AgregarParameters("@codDetalle", _detalle.codigo); }
                    _conex.AgregarParameters("@codComponente", _detalle.codigoComponente);
                    _conex.AgregarParameters("@codEquipo", _codEquipo);
                    _conex.AgregarParameters("@marca", _detalle.marca);
                    _conex.AgregarParameters("@modelo", _detalle.modelo);
                    _conex.AgregarParameters("@serial", _detalle.serial);
                    _conex.AgregarParameters("@datoAdic", _detalle.datoAdicional);
                    _conex.AgregarParameters("@estado", _detalle.estado);
                    if (!_conex.Ejecutar()) { return false; }
                }
                _equipo.codigo = _codEquipo;
                return true;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public DataTable ListarTipoSolicitud()
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("TPS_ListarTipoSolicitud", DBConexion.TipoComando.StoredProcedure);
                _conex.LLenarDataTable(dt);
                return dt;
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarSolicitud(Solicitud_ENT _solicitud)
        {
            int codSolicitud = 0;
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                 
                _conex.SetAdapter("STD_CrearSolicitud", DBConexion.TipoComando.StoredProcedure);
                if (_solicitud.codigo != 0) { _conex.AgregarParameters("@codigo", _solicitud.codigo); }
                _conex.AgregarParameters("@codUbi", Convert.ToInt32(_solicitud.ubicacion));
                _conex.AgregarParameters("@codEquipo", _solicitud.idEquipo);
                _conex.AgregarParameters("@codTipoSol", _solicitud.idTipoSolicitud);
                _conex.AgregarParameters("@descripcion", _solicitud.descripcion);
                _conex.AgregarParameters("@idCrea", IdUsuario);
                _conex.AgregarParameters("@fechaIni", _solicitud.fechaInicio);
                if (_solicitud.fechaFin != new DateTime()) { _conex.AgregarParameters("@fechaFin", _solicitud.fechaFin); }
                _conex.AgregarParameters("@idAsignado", _solicitud.idUsuarioAsignado);
                _conex.AgregarParameters("@estado", _solicitud.estado);
                if (!_conex.Ejecutar()) { return false; }

                _conex.SetAdapter("select IDENT_CURRENT('Solicitud') Codigo", DBConexion.TipoComando.ComandText);
                System.Data.Common.DbDataReader _reader = _conex.Leer();
                if (_reader.Read())
                {
                    codSolicitud = Convert.ToInt32(_reader["Codigo"]);
                }
                _reader.Close();

                if (_solicitud.codigo == 0)
                {
                    _solicitud.codigo = codSolicitud;
                    _solicitud.historia.idSolicitud = codSolicitud;
                }


                _conex.SetAdapter("HST_RegistrarHistoria", DBConexion.TipoComando.StoredProcedure);
                if (_solicitud.historia.codigo != 0) { _conex.AgregarParameters("@codTipoH", _solicitud.historia.codigo); }
                _conex.AgregarParameters("@codSolic", _solicitud.historia.idSolicitud);
                _conex.AgregarParameters("@codTipoH", _solicitud.historia.tipo);
                _conex.AgregarParameters("@Fecha", _solicitud.historia.fechaRegistro);
                _conex.AgregarParameters("@empAtiende", _solicitud.historia.idEmpleado);
                _conex.AgregarParameters("@observ", _solicitud.historia.observacion);
                _conex.AgregarParameters("@costo", _solicitud.historia.costo);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public List<Solicitud_ENT> ListarSolicitudes(string _estado)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("STD_ListarSolicitudes", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@fechaIni", fechaInicial);
                _conex.AgregarParameters("@fechaFin", fechaFinal);//
                if (!string.IsNullOrEmpty(_estado)) { _conex.AgregarParameters("@estado", _estado); }
                _conex.LLenarDataTable(dt);
                var Solicitudes = (from row in dt.Rows.Cast<DataRow>().ToList()
                                   select new Solicitud_ENT()
                                   {
                                       codigo = Convert.ToInt32(row["Codigo_STD"]),
                                       ubicacion = row["Nombre_Ubi"].ToString(),
                                       idEquipo = Convert.ToInt32(row["Codigo_EQP"]),
                                       idTipoSolicitud = Convert.ToInt32(row["Codigo_TPS"]),
                                       idUsuarioAsignado = row["IdAsignado_STD"].ToString(),
                                       descripcion = row["Descripcion_STD"].ToString(),
                                       estado = row["Estado"].ToString(),
                                       fechaInicio = Convert.ToDateTime(row["FechaInicio_STD"]),
                                       TipoSolicitud = row["Nombre_TPS"].ToString(),
                                       fechaFin = row["FechaFin_STD"] == DBNull.Value ? new DateTime() : Convert.ToDateTime(row["FechaFin_STD"]),
                                       //idEmpCrea = row["idCrea_STD"] == DBNull.Value ? "0" : Convert.ToString(row["idCrea_STD"]),
                                       empleadoCrea = row["empCrea"] == DBNull.Value ? "*SIN ASIGNAR*" : Convert.ToString(row["empCrea"]),
                                       //idAsignadoCrea = row["idAsignado_STD"] == DBNull.Value ? "0" : Convert.ToString(row["idAsignado_STD"]),
                                       empleadoAsignado = row["EmpAsignado"] == DBNull.Value ? "*SIN ASIGNAR*" : Convert.ToString(row["EmpAsignado"])
                                   }).ToList();
                var equipos = ListarEquipos();
                Solicitudes.ForEach(s => s.Equipo = equipos.FirstOrDefault(e => e.codigo == s.idEquipo));
                return Solicitudes;
            } // 						
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool RegistrarHistoria(HistoriaSolicitud_ENT _historia)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();
                _conex.SetAdapter("HST_RegistrarHistoria", DBConexion.TipoComando.StoredProcedure);
                if (_historia.codigo != 0) { _conex.AgregarParameters("@codTipoH", _historia.codigo); }
                _conex.AgregarParameters("@codSolic", _historia.idSolicitud);
                _conex.AgregarParameters("@Fecha", _historia.fechaRegistro);
                _conex.AgregarParameters("@empAtiende", _historia.idEmpleado);
                _conex.AgregarParameters("@observ", _historia.observacion);
                _conex.AgregarParameters("@costo", _historia.costo);

                return _conex.Ejecutar();
                //@,@,@,@,@,@
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public List<HistoriaSolicitud_ENT> ListarHistorias(int codSolicitud)
        {
            try
            {
                DataTable dt = new DataTable();
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("HST_ListarHistoriaSolicitud", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@codigoSolic", codSolicitud);
                _conex.LLenarDataTable(dt);
                return (from row in dt.Rows.Cast<DataRow>().ToList()
                        select new HistoriaSolicitud_ENT()
                        {
                            codigo = Convert.ToInt32(row["Codigo_HST"]),
                            idSolicitud = Convert.ToInt32(row["Codigo_STD"]),
                            tipo = (TiposAnidado_ENT.TipoHistoria)Convert.ToInt32(row["Codigo_TPH"]),
                            fechaRegistro = Convert.ToDateTime(row["FechaAtencion_HST"]),
                            idEmpleado = Convert.ToString(row["EmpleadoAtiende_HST"]),
                            nombreEmpleado = row["empleado"].ToString(),
                            observacion = row["Observacion_HST"].ToString(),
                            costo = Convert.ToDecimal(row["Costo_HST"])
                        }).ToList();
            } // 						
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool ActualizarEstadoSolicitud(int codSolicitud, string estado)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("STD_ActualizarEstado", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@codigoSTD", codSolicitud);
                _conex.AgregarParameters("@estado", estado);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }
        public bool DescartarEquipo(int codEquipo, string nota)
        {
            try
            {
                _conex = new DBConexion(_nomConex);
                _conex.Abrir();

                _conex.SetAdapter("EQP_DescartarEquipo", DBConexion.TipoComando.StoredProcedure);
                _conex.AgregarParameters("@codEquipo", codEquipo);
                _conex.AgregarParameters("@nota", nota);
                _conex.AgregarParameters("@idEmp", IdUsuario);
                return _conex.Ejecutar();
            }
            catch (Exception ex)
            { throw ex; }
            finally { _conex.Cerrar(); }
        }

        #endregion "Métodos y Funciones"
    }
}
