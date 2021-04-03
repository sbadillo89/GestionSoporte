using GestionSoporte.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static GestionSoporte.ENT.TiposAnidado_ENT;

namespace GestionSoporte.UI
{
    public partial class Frm_Solicitud : Form
    {
        Gestionador_BLL _gestionBLL;
        private string controlesRequeridos;
        string IdUsuario;
        TipoSolicitud _tipoSolic;

        public Frm_Solicitud()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }
        private void Frm_Solicitud_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void CargarCombo()
        {
            try
            {
                Cmb_Ubicacion.SelectedIndexChanged -= Cmb_Ubicacion_SelectedIndexChanged;
                Cmb_Ubicacion.DisplayMember = "Nombre";
                Cmb_Ubicacion.ValueMember = "Codigo";
                Cmb_Ubicacion.DataSource = _gestionBLL.ListarUbicaciones().Where(x=> x.estado=="ACT").ToList();
                Cmb_Ubicacion.SelectedIndex = -1;
                Cmb_Ubicacion.SelectedIndexChanged += Cmb_Ubicacion_SelectedIndexChanged;

                cmb_TipoSolicitud.SelectedIndexChanged -= cmb_TipoSolicitud_SelectedIndexChanged;
                cmb_TipoSolicitud.DisplayMember = "Nombre_TPS";
                cmb_TipoSolicitud.ValueMember = "Codigo_TPS";
                cmb_TipoSolicitud.DataSource = _gestionBLL.ListarTipoSolicitud();
                cmb_TipoSolicitud.SelectedIndex = -1;
                cmb_TipoSolicitud.SelectedIndexChanged += cmb_TipoSolicitud_SelectedIndexChanged;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void Cmb_Ubicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Ubicacion.SelectedIndex != -1)
            {
                int codUbi = Convert.ToInt32(Cmb_Ubicacion.SelectedValue);

                if (_tipoSolic == TipoSolicitud.MANTENIMIENTO_DE_COMPUTO)
                {
                    chkl_Equipos.DataSource = _gestionBLL.ListarEquipos().FindAll(x => x.codigoUbicacion == codUbi && x.estado != "DB").ToList();
                    chkl_Equipos.DisplayMember = "Etiqueta";
                    chkl_Equipos.ValueMember = "Codigo";
                    lbl_equipos.Visible = true;
                }
                else { lbl_equipos.Visible = false; } 
            }
            else
            {
                lbl_equipos.Visible = true;
                chkl_Equipos.DataSource = null;
            }
        }
        private void InicializarControles()
        {
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CajaDeTexto.CajaDeTexto)
                    {
                        ((CajaDeTexto.CajaDeTexto)ctrl).Clear();
                    }
                    else if (ctrl is ComboBox)
                    {
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    }
                    else if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Clear();
                    }
                }
                Cmb_Ubicacion.Focus();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarControlesRequeridos())
                {
                    MessageBox.Show("Todos estos datos son requeridos." + Environment.NewLine + controlesRequeridos, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               // if (!ValidarUsuario()) { return; }

                ENT.Solicitud_ENT _newSolicitud = new ENT.Solicitud_ENT();

                if (_tipoSolic == TipoSolicitud.MANTENIMIENTO_DE_COMPUTO)
                {
                    _newSolicitud.Equipo = (chkl_Equipos.CheckedItems[0] as ENT.Equipo_ENT);
                }
                _newSolicitud.idEquipo = chkl_Equipos.CheckedItems.Count != 0 ? _newSolicitud.Equipo.codigo : 0;
                _newSolicitud.descripcion = txt_Descripcion.Text;
                _newSolicitud.ubicacion = Convert.ToString(Cmb_Ubicacion.SelectedValue);
                _newSolicitud.estado = "ACT";
                _newSolicitud.fechaInicio = DateTime.Now.Date;
                _newSolicitud.idTipoSolicitud = Convert.ToInt32(cmb_TipoSolicitud.SelectedValue);

                _newSolicitud.historia = new ENT.HistoriaSolicitud_ENT();
                _newSolicitud.historia.fechaRegistro = DateTime.Now.Date;
                _newSolicitud.historia.idEmpleado = usuarioLogueado.numeroDocumento; //IdUsuario;
                _newSolicitud.historia.observacion = "CREACION DE NOVEDAD";
                _newSolicitud.historia.tipo = TipoHistoria.CREACION;
                _newSolicitud.historia.costo = 0;

                if (_gestionBLL.RegistrarSolicitud(_newSolicitud))
                {
                    /*MessageBox.Show("Solicitud generada correctamente." + Environment.NewLine + "Radicado #: " + _newSolicitud.codigo.ToString("########00000000"),
                                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    new Frm_MensajeRadicado(_newSolicitud.codigo.ToString("########00000000")).ShowDialog();
                    InicializarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo completar el proceso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarUsuario(Perfil _perfilValido = Perfil.Null)
        {
            try
            {
                UI.Frm_Login frm = new UI.Frm_Login(_perfilValido);
                frm.ShowDialog();
                if (frm.SwUsuarioValido)
                {
                    _gestionBLL.IdUsuario = frm.usuarioLogeado.numeroDocumento;
                    IdUsuario = frm.usuarioLogeado.numeroDocumento;
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
        public bool ValidarControlesRequeridos()
        {
            controlesRequeridos = string.Empty;
            try
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CajaDeTexto.CajaDeTexto)
                    {
                        if (((CajaDeTexto.CajaDeTexto)ctrl).EJ_Requerido & string.IsNullOrEmpty(((CajaDeTexto.CajaDeTexto)ctrl).Text))
                        {
                            //((CajaDeTexto.CajaDeTexto)ctrl).Focus();
                            //return true;
                            controlesRequeridos += ((((CajaDeTexto.CajaDeTexto)ctrl).Tag == null) ? "Sin Especificar" : ((CajaDeTexto.CajaDeTexto)ctrl).Tag.ToString()) + Environment.NewLine;
                        }
                    }
                    else if (ctrl is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)ctrl).Text))
                        {
                            controlesRequeridos += ((((TextBox)ctrl).Tag == null) ? "Sin Especificar" : ((TextBox)ctrl).Tag.ToString()) + Environment.NewLine;
                        }

                    }
                    else if (ctrl is ComboBox)
                    {
                        if (((ComboBox)ctrl).SelectedIndex == -1)
                        {
                            //return true;
                            controlesRequeridos += ((((ComboBox)ctrl).Tag == null) ? "Sin Especificar" : ((ComboBox)ctrl).Tag.ToString()) + Environment.NewLine;
                        }
                    }
                }
                if (chkl_Equipos.CheckedItems.Count == 0 && _tipoSolic == TipoSolicitud.MANTENIMIENTO_DE_COMPUTO)
                {
                    controlesRequeridos += "Equipo";
                }

                return (string.IsNullOrEmpty(controlesRequeridos));
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void chkl_Equipos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Checkear(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Checkear(bool _estado)
        {
            for (int i = 0; i < chkl_Equipos.Items.Count; i++)
            {
                chkl_Equipos.SetItemChecked(i, _estado);
            }

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de esta opción ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Close();
        }
        private void cmb_TipoSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tipoSolic = (TipoSolicitud)Convert.ToInt32(cmb_TipoSolicitud.SelectedValue);
            chkl_Equipos.Enabled = _tipoSolic == TipoSolicitud.MANTENIMIENTO_DE_COMPUTO ? true : false;
            chkl_Equipos.DataSource = null;
            Cmb_Ubicacion.SelectedIndex = -1;
        }

    }
}
