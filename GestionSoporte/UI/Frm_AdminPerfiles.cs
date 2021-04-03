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
    public partial class Frm_AdminPerfiles : Form
    {
        Gestionador_BLL _gestionBLL;
        int _codPerfilSel = 0;
        public Frm_AdminPerfiles()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
        }

        private void Frm_AdminPerfiles_Load(object sender, EventArgs e)
        {
            try
            {
                ListarPerfiles();
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
                if (string.IsNullOrEmpty(Txt_Perfil.Text))
                {
                    MessageBox.Show("Ingrese un nombre de perfil válido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    _codPerfilSel = Convert.ToInt32(Dtg_Perfiles.Rows[e.RowIndex].Cells["colCodigo"].Value);
                    Txt_Perfil.Text = Dtg_Perfiles.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Inicializar()
        {
            try
            {
                Txt_Perfil.Text = "";
                Txt_Perfil.Focus();
                _codPerfilSel = 0;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void ListarPerfiles()
        {
            try
            {
                Dtg_Perfiles.DataSource = _gestionBLL.ListarPerfilesUsu();
                lbl_Total.Text = "Cantidad de Registros: " + Dtg_Perfiles.RowCount.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Guardar()
        {
            try
            {
                if (_codPerfilSel == 1)
                {
                    MessageBox.Show("El perfil administrador no puede ser modificado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Perfil.SelectAll();
                    return;
                }
                if (_gestionBLL.RegistrarPerfil(_codPerfilSel, Txt_Perfil.Text))
                {
                    MessageBox.Show("Perfil registrado correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPerfiles();
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
