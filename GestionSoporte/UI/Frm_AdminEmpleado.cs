using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GestionSoporte.BLL;
using System.Windows.Forms;
using GestionSoporte.ENT;

namespace GestionSoporte.UI
{
    public partial class Frm_AdminEmpleado : Form
    {
        private Gestionador_BLL _gestionBLL;
        private string controlesRequeridos;
        Empleado_ENT _empleadoActual;
        public Frm_AdminEmpleado()
        {
            InitializeComponent();
            _gestionBLL = new BLL.Gestionador_BLL();
        }

        #region "Eventos y Controles"
        private void Frm_AdminEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                tpg_datosUsuario.Parent = null;
                Dtg_Empleados.AutoGenerateColumns = false;
                CargarCombos();
                ListarEmpleados();
                txt_NumDocumento.Select();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarControlesRequeridos(tpg_datosEmpleado))
                {
                    MessageBox.Show("Todos estos datos son requeridos:" + Environment.NewLine + controlesRequeridos, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GuardarEmpleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_NumDocumento_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_NumDocumento.Text))
            {
                _empleadoActual = ((List<Empleado_ENT>)Dtg_Empleados.DataSource).FirstOrDefault(x => x.numeroDocumento == txt_NumDocumento.Text);
                MostrarDatosEmpleado();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea cancelar la operación actual ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            tpg_datosUsuario.Parent = null;
            InicializarControles();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de esta opción ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Close();
        }
        private void Dtg_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _empleadoActual = (Empleado_ENT)Dtg_Empleados.Rows[e.RowIndex].DataBoundItem;
                MostrarDatosEmpleado();
            }
        }
        private void txt_contraseña2_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_contraseña1.Text) && !string.IsNullOrEmpty(txt_contraseña2.Text))
            {
                if (txt_contraseña2.Text != txt_contraseña1.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_contraseña2.Clear();
                    txt_contraseña2.Select();
                }
            }
        }
        private void btn_GrabarUsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_PerfilUsu.SelectedIndex == -1)
                {
                    MessageBox.Show("Es necesario seleccionar un perfil", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txt_contraseña2.Text))
                {
                    MessageBox.Show("Ingrese las contraseñas", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GuardarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion "Eventos y Controles"

        #region "Métodos y Funciones"

        private void CargarCombos()
        {
            try
            {
                //Cmb_PerfilUsu.SelectedIndexChanged -= Cmb_PerfilUsu_SelectedIndexChanged;
                Cmb_PerfilUsu.DisplayMember = "Nombre_PER";
                Cmb_PerfilUsu.ValueMember = "Codigo_PER";
                Cmb_PerfilUsu.DataSource = _gestionBLL.ListarPerfilesUsu();
                Cmb_PerfilUsu.SelectedIndex = -1;
               // Cmb_PerfilUsu.SelectedIndexChanged += Cmb_PerfilUsu_SelectedIndexChanged;

                cmb_TipoDoc.DisplayMember = "Nombre_TDO";
                cmb_TipoDoc.ValueMember = "Codigo_TDO";
                cmb_TipoDoc.DataSource = _gestionBLL.ListarTipoDocumentos();
                cmb_TipoDoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool ValidarControlesRequeridos(Control _ctrol)
        {
            controlesRequeridos = string.Empty;
            try
            {
                foreach (Control ctrl in _ctrol.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (((CajaDeTexto.CajaDeTexto)ctrl).EJ_Requerido & string.IsNullOrEmpty(((CajaDeTexto.CajaDeTexto)ctrl).Text))
                        {
                            //((CajaDeTexto.CajaDeTexto)ctrl).Focus();
                            //return true;
                            controlesRequeridos += ((((CajaDeTexto.CajaDeTexto)ctrl).Tag == null) ? "Sin Especificar" : ((CajaDeTexto.CajaDeTexto)ctrl).Tag.ToString()) + Environment.NewLine;
                        }
                    }
                    if (ctrl is ComboBox)
                    {
                        if (((ComboBox)ctrl).SelectedIndex == -1)
                        {
                            //return true;
                            controlesRequeridos += ((((ComboBox)ctrl).Tag == null) ? "Sin Especificar" : ((ComboBox)ctrl).Tag.ToString()) + Environment.NewLine;
                        }
                    }
                }
                return (string.IsNullOrEmpty(controlesRequeridos));
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void GuardarEmpleado()
        {
            try
            {
                Empleado_ENT newEmpleado = new Empleado_ENT();
                newEmpleado.numeroDocumento = txt_NumDocumento.Text;
                newEmpleado.idTipoDocumento = Convert.ToInt32(cmb_TipoDoc.SelectedValue);
                newEmpleado.primerNombre = txt_pNombre.Text;
                newEmpleado.segundoNombre = txt_sNombre.Text;
                newEmpleado.primerApellido = txt_pApellido.Text;
                newEmpleado.segundoApellido = txt_sApellido.Text;
                newEmpleado.direccion = txt_direccion.Text;
                newEmpleado.telefono = txt_telefono.Text;
                newEmpleado.correo = txt_correo.Text;
                newEmpleado.fechaNacimiento = dtp_fechaNac.Value.Date;

                if (_gestionBLL.RegistrarEmpleado(newEmpleado))
                {
                    ListarEmpleados();
                    MessageBox.Show("Empleado registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarControles();
                }
                else { MessageBox.Show("No se pudo completar el proceso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void GuardarUsuario()
        {
            try
            {
                _empleadoActual.usuario = new Usuario_ENT();
                _empleadoActual.usuario.numeroDocumento = txt_NumDocumento.Text;
                _empleadoActual.usuario.idPerfil = Convert.ToInt32(Cmb_PerfilUsu.SelectedValue);
                _empleadoActual.usuario.contraseña = txt_contraseña1.Text;
                if (_gestionBLL.RegistrarUsuario(_empleadoActual.usuario))
                {
                    ListarEmpleados();
                    MessageBox.Show("Usuario registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarControles();
                }
                else { MessageBox.Show("No se pudo completar el proceso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void MostrarDatosEmpleado()
        {
            try
            {
                if (_empleadoActual != null && !string.IsNullOrEmpty(_empleadoActual.numeroDocumento))
                {
                    txt_NumDocumento.Text = _empleadoActual.numeroDocumento;
                    cmb_TipoDoc.SelectedValue = _empleadoActual.idTipoDocumento;
                    txt_pNombre.Text = _empleadoActual.primerNombre;
                    txt_sNombre.Text = _empleadoActual.segundoNombre;
                    txt_pApellido.Text = _empleadoActual.primerApellido;
                    txt_sApellido.Text = _empleadoActual.segundoApellido;
                    txt_direccion.Text = _empleadoActual.direccion;
                    txt_telefono.Text = _empleadoActual.telefono;
                    txt_correo.Text = _empleadoActual.correo;
                    dtp_fechaNac.Value = _empleadoActual.fechaNacimiento;
                    lbl_NombreEmpleado.Text = _empleadoActual.nombreCompleto; 
                    tpg_datosUsuario.Parent = Tbc_Principal; 
                    _empleadoActual.usuario = _gestionBLL.CargarDatosUsuario(_empleadoActual.numeroDocumento);

                }
                else
                {
                    string NumDoc = txt_NumDocumento.Text;
                    InicializarControles();
                    txt_NumDocumento.Text = NumDoc;
                    cmb_TipoDoc.Focus();
                    tpg_datosUsuario.Parent = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void MostrarDatosUsuario()
        {
            try
            {
                if (_empleadoActual.usuario != null)
                {
                    Cmb_PerfilUsu.SelectedValue = _empleadoActual.usuario.idPerfil;
                    txt_contraseña1.Text = _empleadoActual.usuario.contraseña;
                    txt_contraseña2.Text = _empleadoActual.usuario.contraseña;
                }
                else
                {
                    txt_contraseña1.Text = "";
                    txt_contraseña2.Text = ""; 
                    Cmb_PerfilUsu.SelectedIndex = -1;
                    Cmb_PerfilUsu.Text = "";
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarEmpleados()
        {
            try
            {
                Dtg_Empleados.DataSource = _gestionBLL.ListarEmpleados().Where(e => e.estado == "ACT").ToList();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void InicializarControles()
        {
            try
            {
                foreach (Control ctrol in Tbc_Principal.Controls)
                {
                    foreach (Control ctrl in ctrol.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ((CajaDeTexto.CajaDeTexto)ctrl).Clear();
                        }
                        if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).SelectedIndex = -1;
                        }
                    }
                }
                lbl_NombreEmpleado.Text = "";
                dtp_fechaNac.Value = DateTime.Now.Date;
                txt_NumDocumento.Focus();
                tpg_datosUsuario.Parent = null;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion "Métodos y Funciones"
          
        private void Tbc_Principal_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(Tbc_Principal.SelectedTab.Text == "Datos de Usuario")
            {
                MostrarDatosUsuario();
                Cmb_PerfilUsu.Focus();
            }
            else
            {
                txt_NumDocumento.Focus();
            }
        }
    }
}
