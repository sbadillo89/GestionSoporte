using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using GestionSoporte.BLL;
using System.Windows.Forms;

namespace GestionSoporte.UI
{
    public partial class Frm_TipoDocumento : Form
    {
        Gestionador_BLL _gestionBLL;
        int _codTipoSel = 0;
        public Frm_TipoDocumento()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_TipoDocumento_Load(object sender, EventArgs e)
        {
            try
            {
                Dtg_TipoDocs.AutoGenerateColumns = false;
                ListarTipoDocumentos();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
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
                if (string.IsNullOrEmpty(Txt_Nombre.Text))
                {
                    MessageBox.Show("Ingrese un tipo de documento válido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Dtg_TipoDocs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    _codTipoSel = Convert.ToInt32(Dtg_TipoDocs.Rows[e.RowIndex].Cells["colCodigo"].Value);
                    Txt_Nombre.Text = Dtg_TipoDocs.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Inicializar()
        {
            try
            {
                Txt_Nombre.Text = "";
                Txt_Nombre.Focus();
                _codTipoSel = 0;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarTipoDocumentos()
        {
            try
            {
                Dtg_TipoDocs.DataSource = _gestionBLL.ListarTipoDocumentos();
                lbl_Total.Text = "Cantidad de Registros: " + Dtg_TipoDocs.RowCount.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Guardar()
        {
            try
            {
                if (_gestionBLL.RegistrarTipoDocumento(_codTipoSel, Txt_Nombre.Text))
                {
                    MessageBox.Show("Tipo de Documento registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTipoDocumentos();
                    Inicializar();
                }
                else
                {
                    MessageBox.Show("No se pudo completar el proceso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

    }
}
