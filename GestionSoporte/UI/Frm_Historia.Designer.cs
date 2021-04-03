namespace GestionSoporte.UI
{
    partial class Frm_Historia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historia));
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_costo = new CajaDeTexto.CajaDeTexto();
            this.Pnl_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_tipo.Location = new System.Drawing.Point(0, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(500, 25);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "ASIGNACION";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.Enabled = false;
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(5, 54);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(224, 23);
            this.Cmb_Empleado.TabIndex = 0;
            this.Cmb_Empleado.Tag = "Empleado Responsable";
            this.Cmb_Empleado.SelectedIndexChanged += new System.EventHandler(this.Cmb_Empleado_SelectedIndexChanged);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Descripcion.Location = new System.Drawing.Point(5, 154);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(379, 50);
            this.txt_Descripcion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Empleado responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción";
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Botones.Controls.Add(this.btn_Salir);
            this.Pnl_Botones.Controls.Add(this.btn_Cancelar);
            this.Pnl_Botones.Controls.Add(this.btn_Grabar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Botones.Location = new System.Drawing.Point(390, 25);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(110, 186);
            this.Pnl_Botones.TabIndex = 19;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(6, 144);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Costo";
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.Color.White;
            this.txt_costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_costo.EJ_Cedula = false;
            this.txt_costo.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_costo.EJ_Decimales = false;
            this.txt_costo.EJ_Dinero = true;
            this.txt_costo.EJ_Mayúsculas = false;
            this.txt_costo.EJ_Requerido = false;
            this.txt_costo.EJ_Saltar = false;
            this.txt_costo.EJ_SoloNumero = false;
            this.txt_costo.EJ_TextoInformativo = null;
            this.txt_costo.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_costo.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_costo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.Location = new System.Drawing.Point(8, 106);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(166, 23);
            this.txt_costo.TabIndex = 1;
            this.txt_costo.Tag = "Costo";
            this.txt_costo.Text = "0";
            this.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_costo.Validated += new System.EventHandler(this.txt_costo_Validated);
            // 
            // Frm_Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 211);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pnl_Botones);
            this.Controls.Add(this.Cmb_Empleado);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_tipo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Historia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia de solicitud";
            this.Load += new System.EventHandler(this.Frm_Historia_Load);
            this.Pnl_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Label label3;
        private CajaDeTexto.CajaDeTexto txt_costo;
    }
}