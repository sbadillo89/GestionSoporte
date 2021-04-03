using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSoporte.UI
{
    public partial class Frm_Justificacion : Form
    {
        public string justificacion { get; set; }
        public Frm_Justificacion()
        {
            InitializeComponent();
        }

        private void Frm_Justificacion_Load(object sender, EventArgs e)
        {
            justificacion = string.Empty;
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Justificacion.Text))
                {
                    MessageBox.Show("Se requiere una justificación para dar de baja un equipo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                justificacion = txt_Justificacion.Text;
                this.Close();
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
