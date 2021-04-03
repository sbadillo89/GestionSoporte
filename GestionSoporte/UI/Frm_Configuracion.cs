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
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Evento_MouseEnter(object sender, EventArgs e)
        {
            //((Button)sender).Image = Properties.Resources.seleccionadoLateral;
            // ((Button)sender).BackColor = Color.Gainsboro;
        }

        private void Evento_MouseLeave(object sender, EventArgs e)
        {
            //((Button)sender).Image = null;
            //((Button)sender).BackColor = Color.White;
        }

        private void Btn_AdmPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AdminPerfiles frmPerfiles = new Frm_AdminPerfiles();
                frmPerfiles.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de esta opción ?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            this.Close();
        }

        private void Btn_AdmTipoDoc_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_TipoDocumento frmTipoDoc = new Frm_TipoDocumento();
                frmTipoDoc.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Btn_AdmTipoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AdminTipoEquipo frmTipoEqp = new Frm_AdminTipoEquipo();
                frmTipoEqp.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Btn_AdmComponente_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AdminComponente frm = new UI.Frm_AdminComponente();
                frm.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void Btn_Ubicaciones_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AdminUbicacion frm = new UI.Frm_AdminUbicacion();
                frm.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AdminEmpleado frm = new Frm_AdminEmpleado();
                frm.ShowDialog();
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
