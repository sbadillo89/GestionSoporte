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
    public partial class Frm_AdminTipoEquipo : Form
    {
        Gestionador_BLL _gestionBLL;
        int _codTipoSel = 0;
        public Frm_AdminTipoEquipo()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_AdminTipoEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                ListarTipoEquipos();
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
                if (string.IsNullOrEmpty(Txt_TipoEqp.Text))
                {
                    MessageBox.Show("Ingrese un tipo de equipo válido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    _codTipoSel = Convert.ToInt32(Dtg_TipoEqp.Rows[e.RowIndex].Cells["colCodigo"].Value);
                    Txt_TipoEqp.Text = Dtg_TipoEqp.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Inicializar()
        {
            try
            {
                Txt_TipoEqp.Text = "";
                Txt_TipoEqp.Focus();
                _codTipoSel = 0;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarTipoEquipos()
        {
            try
            {
                Dtg_TipoEqp.DataSource = _gestionBLL.ListarTipoEquipos();
                lbl_Total.Text = "Cantidad de Registros: " + Dtg_TipoEqp.RowCount.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Guardar()
        {
            try
            {
                if (_gestionBLL.RegistrarTipoEquipo(_codTipoSel, Txt_TipoEqp.Text))
                {
                    MessageBox.Show("Tipo de Equipo registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTipoEquipos();
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
