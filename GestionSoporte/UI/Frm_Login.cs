using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GestionSoporte.ENT;
using GestionSoporte.BLL;

using System.Windows.Forms;
using System.Threading;

namespace GestionSoporte.UI
{
    public partial class Frm_Login : Form
    {
        private Gestionador_BLL _gestionBLL;
        public bool SwUsuarioValido = false;
        public Usuario_ENT usuarioLogeado;
        ENT.TiposAnidado_ENT.Perfil perfilValido;
        public Frm_Login()
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
            perfilValido = TiposAnidado_ENT.Perfil.Null;
        }
        public Frm_Login(ENT.TiposAnidado_ENT.Perfil _perfilValido)
        {
            InitializeComponent();
            _gestionBLL = new Gestionador_BLL();
            perfilValido = _perfilValido;
        }

        private void txt_Usuario_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Usuario.Text))
            {
                usuarioLogeado = _gestionBLL.CargarDatosUsuario(txt_Usuario.Text);
                if (usuarioLogeado != null)
                {
                    usuarioLogeado.nombreCompleto = _gestionBLL.ListarEmpleados(usuarioLogeado.numeroDocumento).FirstOrDefault().nombreCompleto;
                    lbl_Mensaje.Text = usuarioLogeado.nombreCompleto;
                    lbl_Mensaje.ForeColor = Color.White;
                }
                else
                {
                    lbl_Mensaje.Text = "USUARIO INEXISTENTE !!!";
                    lbl_Mensaje.ForeColor = Color.Tomato;
                }
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Mensaje.Text = "";
                if (string.IsNullOrEmpty(txt_Usuario.Text))
                {
                    MessageBox.Show("Ingrese un usuario válido.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txt_Password.Text))
                {
                    MessageBox.Show("Ingrese una contraseña válida.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ValidarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarUsuario()
        {
            try
            {
                SwUsuarioValido = false;
                if (usuarioLogeado == null && !string.IsNullOrEmpty(txt_Password.Text))
                {
                    lbl_Mensaje.Text = "USUARIO O CONTRASEÑA INCORRECTAS !!!";
                    lbl_Mensaje.ForeColor = Color.Firebrick;
                }
                else
                {
                    if (usuarioLogeado.contraseña != txt_Password.Text)
                    {
                        lbl_Mensaje.Text = "CONTRASEÑA INCORRECTA !!!";
                        lbl_Mensaje.ForeColor = Color.Firebrick;
                        txt_Password.Focus(); txt_Password.SelectAll();
                    }
                    else
                    {
                        if (perfilValido != TiposAnidado_ENT.Perfil.Null && ((int)perfilValido != usuarioLogeado.idPerfil))
                        {
                            lbl_Mensaje.Text = "NO POSEE PERMISOS PARA REALIZAR ESTA ACCION";
                            SwUsuarioValido = false;
                            lbl_Mensaje.ForeColor = Color.Red;
                        }
                        else
                        {
                            lbl_Mensaje.Text = "USUARIO VALIDADO CORECTAMENTE !!!";
                            lbl_Mensaje.ForeColor = Color.DarkSeaGreen;
                            SwUsuarioValido = true;
                            this.Close();
                        }
                    }
                }


            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
