namespace GestionSoporte.UI
{
    partial class Frm_AdminUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdminUbicacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.Dtg_ubicaciones = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Total = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Nombre = new CajaDeTexto.CajaDeTexto();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Direccion = new CajaDeTexto.CajaDeTexto();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Telefono = new CajaDeTexto.CajaDeTexto();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pnl_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_ubicaciones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Botones.Controls.Add(this.btn_Salir);
            this.Pnl_Botones.Controls.Add(this.btn_Cancelar);
            this.Pnl_Botones.Controls.Add(this.btn_Grabar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Botones.Location = new System.Drawing.Point(599, 0);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(110, 366);
            this.Pnl_Botones.TabIndex = 17;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(6, 327);
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
            // Dtg_ubicaciones
            // 
            this.Dtg_ubicaciones.AllowUserToAddRows = false;
            this.Dtg_ubicaciones.AllowUserToDeleteRows = false;
            this.Dtg_ubicaciones.AllowUserToResizeRows = false;
            this.Dtg_ubicaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_ubicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_ubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_ubicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDireccion,
            this.colTelefono});
            this.Dtg_ubicaciones.Location = new System.Drawing.Point(0, 98);
            this.Dtg_ubicaciones.Name = "Dtg_ubicaciones";
            this.Dtg_ubicaciones.ReadOnly = true;
            this.Dtg_ubicaciones.RowHeadersVisible = false;
            this.Dtg_ubicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_ubicaciones.Size = new System.Drawing.Size(597, 244);
            this.Dtg_ubicaciones.TabIndex = 101;
            this.Dtg_ubicaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Perfiles_CellDoubleClick);
            this.Dtg_ubicaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dtg_ubicaciones_CellFormatting);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 220;
            // 
            // colDireccion
            // 
            this.colDireccion.DataPropertyName = "Direccion";
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 180;
            // 
            // colTelefono
            // 
            this.colTelefono.DataPropertyName = "Telefono";
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 120;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Total});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 102;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Total
            // 
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 17);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.White;
            this.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nombre.EJ_Cedula = false;
            this.txt_Nombre.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_Nombre.EJ_Decimales = false;
            this.txt_Nombre.EJ_Dinero = false;
            this.txt_Nombre.EJ_Mayúsculas = false;
            this.txt_Nombre.EJ_Requerido = true;
            this.txt_Nombre.EJ_Saltar = false;
            this.txt_Nombre.EJ_SoloNumero = false;
            this.txt_Nombre.EJ_TextoInformativo = null;
            this.txt_Nombre.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Nombre.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(12, 21);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(294, 23);
            this.txt_Nombre.TabIndex = 0;
            this.txt_Nombre.Tag = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.White;
            this.txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Direccion.EJ_Cedula = false;
            this.txt_Direccion.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_Direccion.EJ_Decimales = false;
            this.txt_Direccion.EJ_Dinero = false;
            this.txt_Direccion.EJ_Mayúsculas = false;
            this.txt_Direccion.EJ_Requerido = true;
            this.txt_Direccion.EJ_Saltar = false;
            this.txt_Direccion.EJ_SoloNumero = false;
            this.txt_Direccion.EJ_TextoInformativo = null;
            this.txt_Direccion.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Direccion.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Direccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(312, 21);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(235, 23);
            this.txt_Direccion.TabIndex = 1;
            this.txt_Direccion.Tag = "DIRECCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teléfono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.White;
            this.txt_Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Telefono.EJ_Cedula = false;
            this.txt_Telefono.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_Telefono.EJ_Decimales = false;
            this.txt_Telefono.EJ_Dinero = false;
            this.txt_Telefono.EJ_Mayúsculas = false;
            this.txt_Telefono.EJ_Requerido = false;
            this.txt_Telefono.EJ_Saltar = false;
            this.txt_Telefono.EJ_SoloNumero = false;
            this.txt_Telefono.EJ_TextoInformativo = null;
            this.txt_Telefono.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Telefono.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Telefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(13, 65);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(130, 23);
            this.txt_Telefono.TabIndex = 2;
            this.txt_Telefono.Tag = "Primer Nombre";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(149, 65);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(157, 23);
            this.cmb_estado.TabIndex = 3;
            this.cmb_estado.Tag = "ESTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estado";
            // 
            // Frm_AdminUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 366);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dtg_ubicaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pnl_Botones);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AdminUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Ubicaciones";
            this.Load += new System.EventHandler(this.Frm_AdminTipoEquipo_Load);
            this.Pnl_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_ubicaciones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.DataGridView Dtg_ubicaciones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Total;
        private CajaDeTexto.CajaDeTexto txt_Nombre;
        private System.Windows.Forms.Label label2;
        private CajaDeTexto.CajaDeTexto txt_Direccion;
        private System.Windows.Forms.Label label3;
        private CajaDeTexto.CajaDeTexto txt_Telefono;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
    }
}