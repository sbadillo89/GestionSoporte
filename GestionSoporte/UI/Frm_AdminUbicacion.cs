using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using GestionSoporte.BLL;
using System.Windows.Forms;
using System.Drawing;

namespace GestionSoporte.UI
{
    public partial class Frm_AdminUbicacion : Form
    {
        Gestionador_BLL _gestionBLL;
        ENT.Ubicacion_ENT _ubicacionActual;
        private string controlesRequeridos;

        public Frm_AdminUbicacion()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_AdminTipoEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                Dtg_ubicaciones.AutoGenerateColumns = false;
                cmb_estado.DataSource = Enum.GetValues(typeof(ENT.TiposAnidado_ENT.Estado));
                cmb_estado.SelectedIndex = -1;
                ListarUbicaciones();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de esta opción ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Close();
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
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Dtg_Perfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    _ubicacionActual = (ENT.Ubicacion_ENT)Dtg_ubicaciones.Rows[e.RowIndex].DataBoundItem;
                    MostrarDatosUbicacion();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void MostrarDatosUbicacion()
        {
            try
            {
                if (_ubicacionActual != null)
                {
                    txt_Nombre.Text = _ubicacionActual.nombre;
                    txt_Direccion.Text = _ubicacionActual.direccion;
                    txt_Telefono.Text = _ubicacionActual.telefono;
                    cmb_estado.Text = _ubicacionActual.estado == "ACT" ? "ACTIVA" : "INACTIVA";
                }
                else
                { InicializarControles(); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void InicializarControles()
        {
            try
            {
                _ubicacionActual = null;
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
                } 
                cmb_estado.SelectedIndex = -1;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarUbicaciones()
        {
            try
            {
                Dtg_ubicaciones.DataSource = _gestionBLL.ListarUbicaciones();
                lbl_Total.Text = "Cantidad de Registros: " + Dtg_ubicaciones.RowCount.ToString();
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

        private void Guardar()
        {
            try
            {
                ENT.Ubicacion_ENT newUbicacion = new ENT.Ubicacion_ENT();
                newUbicacion.codigo = _ubicacionActual != null ? _ubicacionActual.codigo : 0;
                newUbicacion.nombre = txt_Nombre.Text;
                newUbicacion.direccion = txt_Direccion.Text;
                newUbicacion.telefono = txt_Telefono.Text;
                newUbicacion.estado = cmb_estado.Text.Substring(0, 3);

                if (_gestionBLL.RegistrarUbicacion(newUbicacion))
                {
                    string msg= _ubicacionActual != null ? "Ubicación modificada correctamente" : "Ubicación registrada correctamente";
                    MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarUbicaciones();
                    InicializarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo completar el proceso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Dtg_ubicaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var estado = ((ENT.Ubicacion_ENT)Dtg_ubicaciones.Rows[e.RowIndex].DataBoundItem).estado;
                if (estado == "INA")
                {
                    Dtg_ubicaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    Dtg_ubicaciones.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
