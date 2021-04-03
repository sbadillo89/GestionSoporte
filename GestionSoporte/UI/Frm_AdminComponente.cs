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
    public partial class Frm_AdminComponente : Form
    {
        Gestionador_BLL _gestionBLL;
        int _codComponente = 0;
        public Frm_AdminComponente()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_AdminTipoEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                Dtg_Componente.AutoGenerateColumns = false;
                ListarComponentes();
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
                if (string.IsNullOrEmpty(Txt_Componente.Text))
                {
                    MessageBox.Show("Ingrese un nomnbre válido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DtgCaracteristica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    _codComponente = Convert.ToInt32(Dtg_Componente.Rows[e.RowIndex].Cells["colCodigo"].Value);
                    Txt_Componente.Text = Dtg_Componente.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Inicializar()
        {
            try
            {
                Txt_Componente.Text = "";
                Txt_Componente.Focus();
                _codComponente = 0;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarComponentes()
        {
            try
            {
                Dtg_Componente.DataSource = _gestionBLL.ListarComponentes();
                lbl_Total.Text = "Cantidad de Registros: " + Dtg_Componente.RowCount.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Guardar()
        {
            try
            {
                if (_gestionBLL.RegistrarComponente(_codComponente, Txt_Componente.Text))
                {
                    MessageBox.Show("Componente registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarComponentes();
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
