namespace GestionSoporte.UI
{
    partial class Frm_Solicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Solicitud));
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.Cmb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkl_Equipos = new System.Windows.Forms.CheckedListBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TipoSolicitud = new System.Windows.Forms.ComboBox();
            this.lbl_equipos = new System.Windows.Forms.Label();
            this.Pnl_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Botones.Controls.Add(this.btn_Salir);
            this.Pnl_Botones.Controls.Add(this.btn_Cancelar);
            this.Pnl_Botones.Controls.Add(this.btn_Grabar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Botones.Location = new System.Drawing.Point(665, 0);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(110, 221);
            this.Pnl_Botones.TabIndex = 19;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(8, 177);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(99, 35);
            this.btn_Salir.TabIndex = 15;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(6, 47);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 35);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Grabar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Grabar.Image")));
            this.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Grabar.Location = new System.Drawing.Point(6, 9);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(99, 35);
            this.btn_Grabar.TabIndex = 15;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // Cmb_Ubicacion
            // 
            this.Cmb_Ubicacion.FormattingEnabled = true;
            this.Cmb_Ubicacion.Location = new System.Drawing.Point(390, 21);
            this.Cmb_Ubicacion.Name = "Cmb_Ubicacion";
            this.Cmb_Ubicacion.Size = new System.Drawing.Size(265, 23);
            this.Cmb_Ubicacion.TabIndex = 20;
            this.Cmb_Ubicacion.Tag = "Ubicación de Equipo";
            this.Cmb_Ubicacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_Ubicacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ubicación";
            // 
            // chkl_Equipos
            // 
            this.chkl_Equipos.Enabled = false;
            this.chkl_Equipos.FormattingEnabled = true;
            this.chkl_Equipos.Location = new System.Drawing.Point(389, 51);
            this.chkl_Equipos.Name = "chkl_Equipos";
            this.chkl_Equipos.Size = new System.Drawing.Size(266, 166);
            this.chkl_Equipos.TabIndex = 23;
            this.chkl_Equipos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkl_Equipos_ItemCheck);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Descripcion.Location = new System.Drawing.Point(2, 64);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(379, 153);
            this.txt_Descripcion.TabIndex = 25;
            this.txt_Descripcion.Tag = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo de Solicitud";
            // 
            // cmb_TipoSolicitud
            // 
            this.cmb_TipoSolicitud.FormattingEnabled = true;
            this.cmb_TipoSolicitud.Location = new System.Drawing.Point(2, 21);
            this.cmb_TipoSolicitud.Name = "cmb_TipoSolicitud";
            this.cmb_TipoSolicitud.Size = new System.Drawing.Size(379, 23);
            this.cmb_TipoSolicitud.TabIndex = 27;
            this.cmb_TipoSolicitud.Tag = "Tipo de Solicitud";
            this.cmb_TipoSolicitud.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoSolicitud_SelectedIndexChanged);
            // 
            // lbl_equipos
            // 
            this.lbl_equipos.AutoSize = true;
            this.lbl_equipos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipos.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_equipos.Location = new System.Drawing.Point(410, 113);
            this.lbl_equipos.Name = "lbl_equipos";
            this.lbl_equipos.Size = new System.Drawing.Size(220, 21);
            this.lbl_equipos.TabIndex = 28;
            this.lbl_equipos.Text = "[ EQUIPOS POR UBICACION ]";
            // 
            // Frm_Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 221);
            this.Controls.Add(this.lbl_equipos);
            this.Controls.Add(this.cmb_TipoSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkl_Equipos);
            this.Controls.Add(this.Cmb_Ubicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pnl_Botones);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Genera nueva solicitud";
            this.Load += new System.EventHandler(this.Frm_Solicitud_Load);
            this.Pnl_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ComboBox Cmb_Ubicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkl_Equipos;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TipoSolicitud;
        private System.Windows.Forms.Label lbl_equipos;
    }
}