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
    public partial class Frm_MensajeRadicado : Form
    {
        public Frm_MensajeRadicado()
        {
            InitializeComponent();
        }

        public Frm_MensajeRadicado(string _numRadicado)
        {
            InitializeComponent();
            lbl_Radicado.Text = _numRadicado;
        }
        private void Frm_MensajeRadicado_Load(object sender, EventArgs e)
        {

        }

        private void Btn_continuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
