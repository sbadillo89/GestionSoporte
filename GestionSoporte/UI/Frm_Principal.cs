using GestionSoporte.BLL;
using GestionSoporte.ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionSoporte.UI
{
    public partial class Frm_Principal : Form
    {
        Gestionador_BLL _gestionBLL;
        List<Color> colores = new List<Color>();
        Random rnd = new Random(DateTime.Now.Millisecond);
        ENT.Solicitud_ENT _solicitudSel;
        string estadoSolicitud = "";
        string idUsuAdmin = "";

        public Frm_Principal()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
            Dtp_FechaIni.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        #region "Métodos y Funciones"

        private void HabilitarOpcionesPorEstado(string _estado)
        {
            try
            {
                if (_estado == "SIN LEER" || _estado == "LEIDO")
                {
                    Btn_Procesar.Enabled = true;
                    Btn_Finalizar.Enabled = true;
                    Btn_Asignar.Enabled = true;
                    Btn_Aplazar.Enabled = true;
                }
                else if (_estado == "ASIGNADO")
                {
                    Btn_Procesar.Enabled = true;
                    Btn_Finalizar.Enabled = true;
                    Btn_Asignar.Enabled = false;
                    Btn_Aplazar.Enabled = true;
                }
                else if (_estado == "APLAZADO")
                {
                    Btn_Procesar.Enabled = true;
                    Btn_Finalizar.Enabled = true;
                    Btn_Asignar.Enabled = true;
                    Btn_Aplazar.Enabled = false;
                }
                else if (_estado == "PROCESADO")
                {
                    Btn_Procesar.Enabled = false;
                    Btn_Finalizar.Enabled = true;
                    Btn_Asignar.Enabled = false;
                    Btn_Aplazar.Enabled = false;
                }
                else if (_estado == "FINALIZADO")
                {
                    Btn_Procesar.Enabled = false;
                    Btn_Finalizar.Enabled = false;
                    Btn_Asignar.Enabled = false;
                    Btn_Aplazar.Enabled = false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void MostrarHistorias()
        {
            try
            {
                if (_solicitudSel != null)
                {
                    Pnl_Historias.Controls.Clear();
                    var Historias = _gestionBLL.ListarHistorias(_solicitudSel.codigo);

                    int yGroup = 4;
                    int x = 6;
                    int y = 20;

                    foreach (var h in Historias)
                    {
                        GroupBox gbx = new GroupBox();
                        gbx.Name = h.tipo.ToString();
                        gbx.Text = h.tipo.ToString();

                        //tipo de historia
                        Label lblTitulo = new Label();
                        lblTitulo.Text = "Tipo de Historia";
                        lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        lblTitulo.Size = new Size(110, 15);
                        lblTitulo.Location = new Point(x, y);
                        gbx.Controls.Add(lblTitulo);
                        //FechaAtencion
                        lblTitulo = new Label();
                        lblTitulo.Text = "Fecha de Atención";
                        lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        lblTitulo.Size = new Size(110, 15);
                        lblTitulo.Location = new Point(x + 106, y);
                        gbx.Controls.Add(lblTitulo);
                        //empleado
                        lblTitulo = new Label();
                        lblTitulo.Text = "Empleado que realizó";
                        lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        lblTitulo.Size = new Size(170, 15);
                        lblTitulo.Location = new Point(x + 220, y);
                        gbx.Controls.Add(lblTitulo);
                        //costo
                        lblTitulo = new Label();
                        lblTitulo.Text = "Costo";
                        lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        lblTitulo.Size = new Size(50, 15);
                        lblTitulo.Location = new Point(x + 480, y);
                        gbx.Controls.Add(lblTitulo);

                        y += 18;

                        //tipo de historia
                        Label lblDato = new Label();
                        lblDato.Text = h.tipo.ToString();
                        lblDato.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblDato.Size = new Size(110, 23);
                        lblDato.Location = new Point(x, y);
                        gbx.Controls.Add(lblDato);
                        //FechaAtencion
                        lblDato = new Label();
                        lblDato.Text = h.fechaRegistro.ToShortDateString();
                        lblDato.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblDato.Size = new Size(110, 23);
                        lblDato.Location = new Point(x + 107, y);
                        gbx.Controls.Add(lblDato);
                        //empleado
                        lblDato = new Label();
                        lblDato.Text = h.nombreEmpleado;
                        lblDato.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblDato.Size = new Size(260, 23);
                        lblDato.Location = new Point(x + 220, y);
                        gbx.Controls.Add(lblDato);
                        //costo
                        lblDato = new Label();
                        lblDato.Text = Funcionalidades.FuncionesEspeciales.AplicarFormatoMoneda(h.costo.ToString());
                        lblDato.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblDato.Size = new Size(90, 23);
                        lblDato.Location = new Point(x + 480, y);
                        gbx.Controls.Add(lblDato);

                        y += 22;
                        x = 6;
                        //Observacion
                        lblTitulo = new Label();
                        lblTitulo.Text = "Observación";
                        lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        lblTitulo.Size = new Size(200, 15);
                        lblTitulo.Location = new Point(x, y);
                        gbx.Controls.Add(lblTitulo);

                        lblDato = new Label();
                        lblDato.Text = h.observacion;
                        lblDato.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblDato.AutoSize = false;
                        lblDato.Size = new Size(gbx_Detalles.Size.Width - 12, 47);
                        lblDato.Location = new Point(x, y + 18);
                        gbx.Controls.Add(lblDato);

                        gbx.Size = new Size(gbx_Detalles.Size.Width, y + 70);//gbx_Detalles.Size;//
                        gbx.Location = new Point(gbx_Detalles.Location.X, /*gbx_Detalles.Location.Y + altoGroupBox + 10*/yGroup);
                        Pnl_Historias.Controls.Add(gbx);

                        yGroup += gbx.Size.Height + 5;
                        y = 20;

                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarSolicitudes()
        {
            try
            {
                _gestionBLL.fechaInicial = Dtp_FechaIni.Value.Date;
                _gestionBLL.fechaFinal = Dtp_FechaFin.Value.Date;
                List<ControlInfo.DatosControl_ENT> datos = new List<ControlInfo.DatosControl_ENT>();
                /*
                ControlInfo.DatosControl_ENT newDAto = new ControlInfo.DatosControl_ENT();
                newDAto.Dato1 = "00000789";
                newDAto.Dato2 = "LA GRAN VIA";
                newDAto.Dato3 = "Por medio del presente les informo que el día de mañana, jueves 5 de octubre de 2017, no habrá clases en la jornada nocturna.";
                newDAto.Dato4 = DateTime.Now.ToShortDateString();
                datos.Add(newDAto);

                newDAto = new ControlInfo.DatosControl_ENT();
                newDAto.Dato1 = "00000895";
                newDAto.Dato2 = "PUERTO COLOMBIA";
                newDAto.Dato3 = "El contenido de este mensaje y de los archivos adjuntos están dirigidos exclusivamente a sus destinatarios";
                newDAto.Dato4 = DateTime.Now.ToShortDateString();
                datos.Add(newDAto);

                newDAto = new ControlInfo.DatosControl_ENT();
                newDAto.Dato1 = "00000789";
                newDAto.Dato2 = "LA GRAN VIA";
                newDAto.Dato3 = "Por medio del presente les informo que el día de mañana, jueves 5 de octubre de 2017, no habrá clases en la jornada nocturna.";
                newDAto.Dato4 = DateTime.Now.ToShortDateString();
                datos.Add(newDAto);
                */
                if (_gestionBLL.ListarSolicitudes(estadoSolicitud))
                {
                    datos = _gestionBLL.solicitudes.Select(x => new ControlInfo.DatosControl_ENT()
                    {
                        Dato1 = x.codigo.ToString("########00000000"),
                        Dato2 = x.ubicacion,
                        Dato3 = x.Equipo == null ? x.descripcion : x.Equipo.tipoEquipo + " // " + x.descripcion,
                        Dato4 = x.fechaInicio.ToShortDateString(),
                        Dato5 = x.estado
                    }).ToList();
                }
                controlPanel1.ReiniciarControl();
                controlPanel1.datosControl = datos;
                controlPanel1.ArmarControl();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private bool ValidarUsuario(ENT.TiposAnidado_ENT.Perfil _perfilValido = ENT.TiposAnidado_ENT.Perfil.Null)
        {
            try
            {
                UI.Frm_Login frm = new UI.Frm_Login(_perfilValido);
                frm.ShowDialog();
                if (frm.SwUsuarioValido)
                {
                    if (_perfilValido == TiposAnidado_ENT.Perfil.Adminsitrador) { idUsuAdmin = frm.usuarioLogeado.numeroDocumento; }
                    TiposAnidado_ENT.usuarioLogueado = (TiposAnidado_ENT.usuarioLogueado == null ? frm.usuarioLogeado : TiposAnidado_ENT.usuarioLogueado);
                }
                else
                {
                    MessageBox.Show("Acceso no permitido.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return frm.SwUsuarioValido;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private bool ValidarFechas()
        {
            try
            {
                DateTime _fechaIni = Dtp_FechaIni.Value.Date;
                DateTime _fechaFin = Dtp_FechaFin.Value.Date;

                if (_fechaIni > _fechaFin)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void CerrarSesion()
        {
            try
            {
                if(MessageBox.Show("¿Desear cerrar la sesión actual?", this.Text, MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No) { return; }
                lbl_usuario.Text = "";
                lbl_perfil.Text = "";
                controlPanel1.ReiniciarControl();
                
                TiposAnidado_ENT.usuarioLogueado = null;
                if (!ValidarUsuario()) { this.Dispose(); }
                MostrarDatosUsuario();
                Consultar();
            }
            catch (Exception ex)
            { throw ex; }
        }
         
        private void Consultar()
        {
            try
            {
                gbx_Detalles.Visible = false;
                Pnl_Historias.Controls.Clear();
                pnl_Botones.Enabled = false;
                if (!ValidarFechas()) { return; }
                ListarSolicitudes();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void MostrarDatosUsuario()
        { 
            lbl_usuario.Text = TiposAnidado_ENT.usuarioLogueado.nombreCompleto;
            lbl_perfil.Text = TiposAnidado_ENT.usuarioLogueado.perfil;
        }

        #endregion "Métodos y Funciones"


        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarUsuario()) { this.Dispose(); }
                MostrarDatosUsuario();

                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
                ListarSolicitudes();

                colores.Add(Color.LightBlue);
                colores.Add(Color.LightGray);
                colores.Add(Color.LightGreen);
                colores.Add(Color.LightYellow);
                colores.Add(Color.Lavender);
                colores.Add(Color.MistyRose);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_Principal_Resize(object sender, EventArgs e)
        {
            spc_Contenedor.SplitterDistance = 218;
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Dispose();
        }
        private void Btn_Config_Click(object sender, EventArgs e)
        {
            if (TiposAnidado_ENT.usuarioLogueado.idPerfil != (int)TiposAnidado_ENT.Perfil.Adminsitrador)
            {
                MessageBox.Show("Para acceder a esta opción necesita privilegios de administrador.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!ValidarUsuario(ENT.TiposAnidado_ENT.Perfil.Adminsitrador)) { return; }
            }

            UI.Frm_Configuracion frm = new UI.Frm_Configuracion();
            frm.ShowDialog();
        }
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            var index = rnd.Next(colores.Count);
            ((Button)sender).BackColor = colores[index];
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gainsboro;
        }
        private void btn_Solicitud_Click(object sender, EventArgs e)
        {
            UI.Frm_Solicitud frm = new UI.Frm_Solicitud();
            frm.ShowDialog();
            ListarSolicitudes();
        }
        private void controlPanel1_PasaItemSelecionado_1(string codItemSeleccionado, bool checkeado)
        {
            try
            {
                _solicitudSel = _gestionBLL.solicitudes.FirstOrDefault(s => s.codigo == Convert.ToInt32(codItemSeleccionado));
                int xcant = controlPanel1.datosControl.Where(x => x.SwCheckeado).Count();
                bool itemCheckeado = pnl_Botones.Enabled = (controlPanel1.datosControl.Where(x => x.SwCheckeado).Count() != 0);
                pnl_Botones.Enabled = itemCheckeado;
                if (itemCheckeado)
                {
                    HabilitarOpcionesPorEstado(_solicitudSel.estado);
                }
                gbx_Detalles.Visible = true;

                lbl_Equipo.Text = _solicitudSel.Equipo == null ? "No Aplica" : _solicitudSel.Equipo.tipoEquipo + "//" + _solicitudSel.Equipo.descripcion;
                lbl_Descripcion.Text = _solicitudSel.descripcion;
                lbl_FechaIni.Text = _solicitudSel.fechaInicio.ToShortDateString();
                lbl_TipoSolicitud.Text = _solicitudSel.TipoSolicitud;
                lbl_usuGenera.Text = _solicitudSel.empleadoAsignado;
                lbl_Ubicacion.Text = _solicitudSel.ubicacion;
                if (_solicitudSel.estado == "SIN LEER") { _gestionBLL.ActualizarEstadoSolicitud(_solicitudSel.codigo, "LEI"); }
                MostrarHistorias();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void Btn_Asignar_Click(object sender, EventArgs e)
        {
            if (TiposAnidado_ENT.usuarioLogueado.idPerfil != (int)TiposAnidado_ENT.Perfil.Adminsitrador)
            {
                MessageBox.Show("Para realizar esta operación necesita privilegios de administrador.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!ValidarUsuario(ENT.TiposAnidado_ENT.Perfil.Adminsitrador)) { return; }
            }
            else { idUsuAdmin = TiposAnidado_ENT.usuarioLogueado.numeroDocumento; }
            Frm_Historia frm = new Frm_Historia(_solicitudSel, ENT.TiposAnidado_ENT.TipoHistoria.ASIGNACION, idUsuAdmin);
            frm.ShowDialog();
        }
        private void Btn_Aplazar_Click(object sender, EventArgs e)
        {
            if (TiposAnidado_ENT.usuarioLogueado.idPerfil != (int)TiposAnidado_ENT.Perfil.Adminsitrador)
            {
                MessageBox.Show("Para realizar esta operación necesita privilegios de administrador.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!ValidarUsuario(ENT.TiposAnidado_ENT.Perfil.Adminsitrador)) { return; }
            }
            else { idUsuAdmin = TiposAnidado_ENT.usuarioLogueado.numeroDocumento; }

            Frm_Historia frm = new Frm_Historia(_solicitudSel, ENT.TiposAnidado_ENT.TipoHistoria.APLAZADO);
            frm.ShowDialog();
        }
        private void Btn_Procesar_Click(object sender, EventArgs e)
        {
            Frm_Historia frm = new Frm_Historia(_solicitudSel, ENT.TiposAnidado_ENT.TipoHistoria.PROCESADO);
            frm.ShowDialog();
        }
        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (TiposAnidado_ENT.usuarioLogueado.idPerfil != (int)TiposAnidado_ENT.Perfil.Adminsitrador)
            {
                MessageBox.Show("Para realizar esta operación necesita privilegios de administrador.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!ValidarUsuario(ENT.TiposAnidado_ENT.Perfil.Adminsitrador)) { return; }
            }
            else { idUsuAdmin = TiposAnidado_ENT.usuarioLogueado.numeroDocumento; }

            Frm_Historia frm = new Frm_Historia(_solicitudSel, ENT.TiposAnidado_ENT.TipoHistoria.FINALIZADO, idUsuAdmin);
            frm.ShowDialog();
        }
        private void Btn_Equipos_Click(object sender, EventArgs e)
        {
            UI.Frm_Equipo frm = new UI.Frm_Equipo();
            frm.ShowDialog();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                switch (((RadioButton)sender).Text)
                {
                    case "Todos":
                        estadoSolicitud = "";
                        break;
                    case "Sin Leer":
                        estadoSolicitud = "ACT";
                        break;
                    case "Leidos":
                        estadoSolicitud = "LEI";
                        break;
                    case "Asignados":
                        estadoSolicitud = "ASI";
                        break;
                    case "Procesados":
                        estadoSolicitud = "PRO";
                        break;
                    case "Finalizados":
                        estadoSolicitud = "FIN";
                        break;
                    default:
                        break;
                }
            }
        }
        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { e.Cancel = true; ; }
        }
        private void Dtp_FechaIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Dtp_FechaFin.Focus();
            }
        }
        private void Dtp_FechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Consultar.Focus();
            }
        }
        private void btn_cerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            pnl_msg.BringToFront();
            var xX = this.Controls[0].Name;
            pnl_msg.Location = new Point(btn_cerrarSesion.Location.X + 194, (btn_cerrarSesion.Location.Y + btn_cerrarSesion.Size.Height + 1));
            pnl_msg.Visible = true;
        }
        private void btn_cerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            pnl_msg.Visible = false;
        }
        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
    }
}
