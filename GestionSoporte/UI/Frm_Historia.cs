using GestionSoporte.BLL;
using GestionSoporte.ENT;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionSoporte.UI
{
    public partial class Frm_Historia : Form
    {
        Gestionador_BLL _gestionBLL;
        Solicitud_ENT _newSolicitud;

        public Frm_Historia()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        public Frm_Historia(Solicitud_ENT _solicitud, TiposAnidado_ENT.TipoHistoria tipo, string idEmpAdmin = "")
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
            _newSolicitud = new Solicitud_ENT();

            _newSolicitud = _solicitud;
            _newSolicitud.historia.tipo = tipo;
            _newSolicitud.historia.idEmpleado = idEmpAdmin;

            lbl_tipo.Text = tipo.ToString().ToUpper();
            switch (tipo)
            {
                case TiposAnidado_ENT.TipoHistoria.ASIGNACION:
                    _newSolicitud.estado = "ASI";
                    Cmb_Empleado.Enabled = true; 
                    break;
                case TiposAnidado_ENT.TipoHistoria.APLAZADO:
                    _newSolicitud.estado = "APL";
                    break;
                case TiposAnidado_ENT.TipoHistoria.PROCESADO:
                    _newSolicitud.estado = "PRO";
                    break;
                case TiposAnidado_ENT.TipoHistoria.FINALIZADO:
                    _newSolicitud.estado = "FIN";
                    break;
                default:
                    break;
            }
        }

        private void Frm_Historia_Load(object sender, EventArgs e)
        {
            try
            {
                CargarInfoBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿ Desea salir de esta opción ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void CargarInfoBase()
        {
            try
            {
                Cmb_Empleado.DisplayMember = "NombreCompleto";
                Cmb_Empleado.ValueMember = "numeroDocumento";
                Cmb_Empleado.DataSource = _gestionBLL.ListarEmpleados();
                Cmb_Empleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            { throw ex; }
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
                Cmb_Empleado.Focus();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Empleado.Enabled && Cmb_Empleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un empleado válido, para asignar la tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (_newSolicitud.historia.tipo == TiposAnidado_ENT.TipoHistoria.PROCESADO || _newSolicitud.historia.tipo == TiposAnidado_ENT.TipoHistoria.APLAZADO)
                //{
                //    if (!ValidarUsuario()) { return; }
                //}

                _newSolicitud.historia.costo = Convert.ToDecimal(txt_costo.Text);
                _newSolicitud.historia.observacion = txt_Descripcion.Text;
                _newSolicitud.historia.fechaRegistro = DateTime.Now.Date;
                _newSolicitud.historia.idSolicitud = _newSolicitud.codigo; 
                _newSolicitud.ubicacion = _gestionBLL.ListarUbicaciones().Find(u => u.nombre == _newSolicitud.ubicacion).codigo.ToString();
                if (_gestionBLL.RegistrarSolicitud(_newSolicitud))
                {
                    MessageBox.Show("Historia generada correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        private bool ValidarUsuario()
        {
            try
            {
                UI.Frm_Login frm = new UI.Frm_Login();
                frm.ShowDialog();
                if (frm.SwUsuarioValido)
                {
                    _gestionBLL.IdUsuario = frm.usuarioLogeado.numeroDocumento;
                    _newSolicitud.historia.idEmpleado = frm.usuarioLogeado.numeroDocumento;
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
        private void txt_costo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_costo.Text))
            {
                txt_costo.Text = "0";
            }
        }
        private void Cmb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Empleado.SelectedIndex != -1)
            {
                _newSolicitud.idUsuarioAsignado = ((Empleado_ENT)Cmb_Empleado.SelectedItem).numeroDocumento;
            }
        }
    }
}
