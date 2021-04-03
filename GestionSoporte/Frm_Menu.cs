using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Windows.Forms;

namespace GestionSoporte
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.Frm_AdminEmpleado frm = new UI.Frm_AdminEmpleado();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.Frm_Login frm = new UI.Frm_Login( ENT.TiposAnidado_ENT.Perfil.Adminsitrador);
            frm.ShowDialog();
            if (frm.SwUsuarioValido)
            {
                var USU = frm.usuarioLogeado;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UI.Frm_Configuracion frm = new UI.Frm_Configuracion();
            frm.ShowDialog();
        }

        private void principal_Click(object sender, EventArgs e)
        {
            UI.Frm_Principal frm = new UI.Frm_Principal();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UI.Frm_Equipo frm = new UI.Frm_Equipo();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UI.Frm_Solicitud frm = new UI.Frm_Solicitud();
            frm.ShowDialog();
        }
    }
}
