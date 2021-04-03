using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionSoporte.BLL;
using GestionSoporte.ENT;

namespace GestionSoporte.UI
{
    public partial class Frm_Equipo : Form
    {
        Gestionador_BLL _gestionBLL;
        Equipo_ENT _equipoSeleccionado;
        List<EquipoDetalle_ENT> _detalles;
        List<Equipo_ENT> _equipos;
        private string controlesRequeridos;

        public Frm_Equipo()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_Equipo_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_ListaEquipos.AutoGenerateColumns = false;
                CargarInfoBase();
                txt_Etiqueta.Focus();
                txt_Etiqueta.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInfoBase()
        {
            try
            {
                lbl_Codigo.Text = (_gestionBLL.RetornarCodigoEquipo() + 1).ToString();

                Cmb_Empleado.DisplayMember = "NombreCompleto";
                Cmb_Empleado.ValueMember = "numeroDocumento";
                Cmb_Empleado.DataSource = _gestionBLL.ListarEmpleados();
                Cmb_Empleado.SelectedIndex = -1;

                cmb_tipoEquipo.DisplayMember = "Nombre_Tpe";
                cmb_tipoEquipo.ValueMember = "Codigo_Tpe";
                cmb_tipoEquipo.DataSource = _gestionBLL.ListarTipoEquipos();
                cmb_tipoEquipo.SelectedIndex = -1;

                Cmb_Ubicacion.DisplayMember = "Nombre";
                Cmb_Ubicacion.ValueMember = "Codigo";
                Cmb_Ubicacion.DataSource = _gestionBLL.ListarUbicaciones();
                Cmb_Ubicacion.SelectedIndex = -1;

                DataGridViewComboBoxColumn comboboxColum = (DataGridViewComboBoxColumn)dtg_Componentes.Columns["colComponente"];
                comboboxColum.ValueMember = "Codigo_cpt";
                comboboxColum.DisplayMember = "Nombre_Cpt";
                comboboxColum.DataSource = _gestionBLL.ListarComponentes();

                _equipos = _gestionBLL.ListarEquipos();
                dtg_ListaEquipos.DataSource = _equipos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarFila();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarFila();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void AgregarFila()
        {
            try
            {
                if (dtg_Componentes.CurrentRow == null)
                {
                    dtg_Componentes.Rows.Add();
                    SeleccionarCelda(1);
                }
                else
                {
                    DataGridViewRow ultimafila = dtg_Componentes.Rows[dtg_Componentes.Rows.Count - 1];
                    if (Convert.ToInt32(ultimafila.Cells["colComponente"].Value) == 0)
                    {
                        MessageBox.Show("Antes de agregar una nueva fila, asegurese de completar la anterior.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dtg_Componentes.Rows.Add();
                    //dtg_Componentes.Rows[dtg_Componentes.Rows.Count-1].Selected = true;
                    SeleccionarCelda(1);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void SeleccionarCelda(int _index, bool _swEdit = true)
        {
            try
            {
                DataGridViewCell cell = dtg_Componentes.CurrentRow.Cells[_index];
                dtg_Componentes.CurrentRow.Cells[_index].Selected = _swEdit;
                dtg_Componentes.CurrentCell = cell;
                dtg_Componentes.BeginEdit(_swEdit);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void EliminarFila()
        {
            try
            {
                if (dtg_Componentes.RowCount == 0) { return; }
                dtg_Componentes.Rows.Remove(dtg_Componentes.Rows[dtg_Componentes.Rows.Count - 1]);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void InicializarControles()
        {
            try
            {
                _detalles = null;
                _equipoSeleccionado = null;
                Btn_DarDeBaja.Visible = false;
                foreach (Control _ctrol in this.tbc_Principal.Controls)
                {
                    foreach (Control ctrl in _ctrol.Controls)
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

                }
                dtg_Componentes.Rows.Clear();
                lbl_Codigo.Text = (_gestionBLL.RetornarCodigoEquipo() + 1).ToString();
                cmb_tipoEquipo.Focus();
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void dtg_Componentes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex == dtg_Componentes.Columns["colComponente"].Index)
                    {
                        if (dtg_Componentes.Rows[e.RowIndex].Cells["colComponente"].Value == null)
                        {
                            MessageBox.Show("Seleccione un componente válido.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtg_Componentes.CurrentRow.Cells[e.ColumnIndex + 1].Selected = false;
                            return;
                        }
                        int _componente = (Int32)dtg_Componentes.Rows[e.RowIndex].Cells["colComponente"].Value;
                        SendKeys.Send("{TAB}");
                    }
                    else if (e.ColumnIndex == dtg_Componentes.Columns["colMarca"].Index)
                    {
                        string _marca = dtg_Componentes.Rows[e.RowIndex].Cells["colMarca"].Value == null ? "" : dtg_Componentes.Rows[e.RowIndex].Cells["colMarca"].Value.ToString();
                        //dtg_Componentes.CurrentRow.Cells[e.ColumnIndex + 1].Selected = true;
                        SendKeys.Send("{TAB}");
                    }
                    else if (e.ColumnIndex == dtg_Componentes.Columns["colModelo"].Index)
                    {
                        string _modelo = dtg_Componentes.Rows[e.RowIndex].Cells["colModelo"].Value == null ? "" : dtg_Componentes.Rows[e.RowIndex].Cells["colModelo"].Value.ToString();
                        //dtg_Componentes.CurrentRow.Cells[e.ColumnIndex + 1].Selected = true;
                        SendKeys.Send("{TAB}");
                    }
                    else if (e.ColumnIndex == dtg_Componentes.Columns["colSerial"].Index)
                    {
                        string _modelo = dtg_Componentes.Rows[e.RowIndex].Cells["colSerial"].Value == null ? "" : dtg_Componentes.Rows[e.RowIndex].Cells["colSerial"].Value.ToString();
                        SendKeys.Send("{TAB}");
                    }

                }
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
                //if (!ValidarUsuario()) { return; }
                Equipo_ENT _newEquipo = new Equipo_ENT();
                _newEquipo.codigo = _equipoSeleccionado != null ? _equipoSeleccionado.codigo : 0;
                _newEquipo.codigoTipoEquipo = (Int32)cmb_tipoEquipo.SelectedValue;
                _newEquipo.codigoUbicacion = (Int32)Cmb_Ubicacion.SelectedValue;
                _newEquipo.empleadoEncargado = Cmb_Empleado.SelectedValue.ToString();
                _newEquipo.descripcion = txt_Descripcion.Text;
                _newEquipo.etiqueta = txt_Etiqueta.Text;
                _newEquipo.serial = txt_serial.Text;
                _newEquipo.marca = txt_marca.Text;
                _newEquipo.estado = "ACT";
                _newEquipo.detalles = AgregarDetalles();
                if (_gestionBLL.RegistrarEquipo(_newEquipo))
                {
                    MessageBox.Show("Proceso completado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _equipos = _gestionBLL.ListarEquipos();
                    dtg_ListaEquipos.DataSource = _equipos;
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
        private List<EquipoDetalle_ENT> AgregarDetalles()
        {
            try
            {
                _detalles = new List<EquipoDetalle_ENT>();
                if (dtg_Componentes.RowCount != 0)
                {
                    foreach (DataGridViewRow row in dtg_Componentes.Rows)
                    {
                        if (row.Cells["colComponente"].Value == null) { continue; }
                        EquipoDetalle_ENT eqpDetalle = new EquipoDetalle_ENT();
                        eqpDetalle.codigo = row.Cells["colCodigo"].Value == null ? 0 : (Int32)row.Cells["colCodigo"].Value;
                        eqpDetalle.codigoComponente = (Int32)row.Cells["colComponente"].Value;
                        eqpDetalle.marca = row.Cells["colMarca"].Value == null ? "" : row.Cells["colMarca"].Value.ToString();
                        eqpDetalle.modelo = row.Cells["colModelo"].Value == null ? "" : row.Cells["colModelo"].Value.ToString();
                        eqpDetalle.serial = row.Cells["colSerial"].Value == null ? "" : row.Cells["colSerial"].Value.ToString();
                        eqpDetalle.datoAdicional = row.Cells["colDato"].Value == null ? "" : row.Cells["colDato"].Value.ToString();
                        eqpDetalle.estado = "ACT";
                        eqpDetalle.isNuevo = true;
                        _detalles.Add(eqpDetalle);
                    }
                }
                return _detalles;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool ValidarControlesRequeridos()
        {
            controlesRequeridos = string.Empty;
            try
            {
                foreach (Control _ctrol in this.tbc_Principal.Controls)
                {
                    foreach (Control ctrl in _ctrol.Controls)
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
                        if (ctrl is ComboBox)
                        {
                            if (((ComboBox)ctrl).SelectedIndex == -1)
                            {
                                //return true;
                                controlesRequeridos += ((((ComboBox)ctrl).Tag == null) ? "Sin Especificar" : ((ComboBox)ctrl).Tag.ToString()) + Environment.NewLine;
                            }
                        }
                    }
                }
                return (string.IsNullOrEmpty(controlesRequeridos));
            }
            catch (Exception ex)
            { throw ex; }
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
        private void MostrarDatosEquipo()
        {
            try
            {
                if (_equipoSeleccionado != null)
                {
                    dtg_Componentes.Rows.Clear();
                    Cmb_Empleado.SelectedValue = _equipoSeleccionado.empleadoEncargado;
                    cmb_tipoEquipo.SelectedValue = _equipoSeleccionado.codigoTipoEquipo;
                    Cmb_Ubicacion.SelectedValue = _equipoSeleccionado.codigoUbicacion;
                    lbl_Codigo.Text = _equipoSeleccionado.codigo.ToString();
                    txt_Descripcion.Text = _equipoSeleccionado.descripcion;
                    txt_Etiqueta.Text = _equipoSeleccionado.etiqueta;
                    txt_serial.Text = _equipoSeleccionado.serial;
                    txt_marca.Text = _equipoSeleccionado.marca;

                    foreach (var item in _equipoSeleccionado.detalles)
                    {
                        dtg_Componentes.Rows.Add(item.codigo, item.codigoComponente, item.marca, item.modelo, item.serial, item.datoAdicional);
                    }
                    tbc_Principal.SelectedTab = tbc_Principal.TabPages["tpg_NuevoEquipo"];
                }
                Btn_DarDeBaja.Visible = (_equipoSeleccionado != null);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void dtg_ListaEquipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _equipoSeleccionado = (Equipo_ENT)dtg_ListaEquipos.Rows[e.RowIndex].DataBoundItem;
                if (_equipoSeleccionado.estado == "DB") { return; }
                MostrarDatosEquipo();
            }
        }
        private void Filtrar(Filtro _tipoFiltro)
        {
            try
            {
                var eqps = _equipos;

                if ((!string.IsNullOrEmpty(txt_tipo.Text) && _tipoFiltro == Filtro.TipoEquipo) || !string.IsNullOrEmpty(txt_tipo.Text))
                {
                    eqps = eqps.Where(e => e.tipoEquipo.Contains(txt_tipo.Text)).ToList();
                }
                // else if (_tipoFiltro == Filtro.TipoEquipo) { eqps = _equipos; }

                if ((!string.IsNullOrEmpty(txt_responsable.Text) && _tipoFiltro == Filtro.Responsable) || !string.IsNullOrEmpty(txt_responsable.Text))
                {
                    eqps = eqps.Where(e => e.nombreEmpleado.Contains(txt_responsable.Text)).ToList();
                }
                //else if (_tipoFiltro == Filtro.Responsable) { eqps = _equipos; }
                if ((!string.IsNullOrEmpty(txt_ubicacion.Text) && _tipoFiltro == Filtro.Ubicacion) || !string.IsNullOrEmpty(txt_ubicacion.Text))
                {
                    eqps = eqps.Where(e => e.nombreUbicacion.Contains(txt_ubicacion.Text)).ToList();
                }

                if ((!string.IsNullOrEmpty(txt_descrip.Text) && _tipoFiltro == Filtro.Descripcion) || !string.IsNullOrEmpty(txt_descrip.Text))
                {
                    eqps = eqps.Where(e => e.descripcion.Contains(txt_descrip.Text)).ToList();
                }
                dtg_ListaEquipos.DataSource = eqps;

            }
            catch (Exception ex)
            { throw ex; }
        }
        private bool ValidarUsuario()
        {
            try
            {
                UI.Frm_Login frm = new UI.Frm_Login(TiposAnidado_ENT.Perfil.Adminsitrador);
                frm.ShowDialog();
                if (frm.SwUsuarioValido)
                {
                    _gestionBLL.IdUsuario = frm.usuarioLogeado.numeroDocumento;
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
        private void txt_TextChanged(object sender, EventArgs e)
        {
            Filtrar((Filtro)Convert.ToInt32(((TextBox)sender).Tag));
        }
        private enum Filtro
        {
            TipoEquipo = 1,
            Ubicacion = 2,
            Responsable = 3,
            Descripcion = 4
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            txt_descrip.Clear();
            txt_responsable.Clear();
            txt_tipo.Clear();
            txt_ubicacion.Clear();
            dtg_ListaEquipos.DataSource = _equipos;
        }
        private void Btn_DarDeBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (_equipoSeleccionado != null)
                {
                    if (MessageBox.Show("¿Desea dar de baja este equipo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
                    if (!ValidarUsuario()) { return; }
                    Frm_Justificacion frmJustif = new Frm_Justificacion();
                    frmJustif.ShowDialog();
                    if (string.IsNullOrEmpty(frmJustif.justificacion)) { return; }
                    if (_gestionBLL.DescartarEquipo(_equipoSeleccionado.codigo, frmJustif.justificacion))
                    {
                        MessageBox.Show("Equipo dado de baja correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _equipos = _gestionBLL.ListarEquipos();
                        dtg_ListaEquipos.DataSource = _equipos;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar el proceso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un equipo válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void dtg_ListaEquipos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var estado = ((Equipo_ENT)dtg_ListaEquipos.Rows[e.RowIndex].DataBoundItem).estado;
                if (estado == "DB")
                {
                    dtg_ListaEquipos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    dtg_ListaEquipos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void txt_Etiqueta_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Etiqueta.Text))
            {
                _equipoSeleccionado = _equipos.FirstOrDefault(et => et.etiqueta == txt_Etiqueta.Text);
                MostrarDatosEquipo();
            }
        }
    }
}
