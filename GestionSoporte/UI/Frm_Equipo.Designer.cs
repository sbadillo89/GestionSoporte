namespace GestionSoporte.UI
{
    partial class Frm_Equipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Equipo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_tipoEquipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.dtg_Componentes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComponente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.Btn_DarDeBaja = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.tbc_Principal = new System.Windows.Forms.TabControl();
            this.tpg_NuevoEquipo = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_serial = new CajaDeTexto.CajaDeTexto();
            this.txt_Etiqueta = new CajaDeTexto.CajaDeTexto();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tpg_VerEquipos = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.dtg_ListaEquipos = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_marca = new CajaDeTexto.CajaDeTexto();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Componentes)).BeginInit();
            this.Pnl_Botones.SuspendLayout();
            this.tbc_Principal.SuspendLayout();
            this.tpg_NuevoEquipo.SuspendLayout();
            this.tpg_VerEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipoEquipo
            // 
            this.cmb_tipoEquipo.FormattingEnabled = true;
            this.cmb_tipoEquipo.Location = new System.Drawing.Point(510, 22);
            this.cmb_tipoEquipo.Name = "cmb_tipoEquipo";
            this.cmb_tipoEquipo.Size = new System.Drawing.Size(199, 23);
            this.cmb_tipoEquipo.TabIndex = 3;
            this.cmb_tipoEquipo.Tag = "Tipo de Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Equipo";
            // 
            // Cmb_Ubicacion
            // 
            this.Cmb_Ubicacion.FormattingEnabled = true;
            this.Cmb_Ubicacion.Location = new System.Drawing.Point(8, 68);
            this.Cmb_Ubicacion.Name = "Cmb_Ubicacion";
            this.Cmb_Ubicacion.Size = new System.Drawing.Size(286, 23);
            this.Cmb_Ubicacion.TabIndex = 4;
            this.Cmb_Ubicacion.Tag = "Ubicación de Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación del Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(8, 22);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(56, 23);
            this.lbl_Codigo.TabIndex = 1;
            this.lbl_Codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(300, 68);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(409, 23);
            this.Cmb_Empleado.TabIndex = 5;
            this.Cmb_Empleado.Tag = "Empleado Responsable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Empleado responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripción";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Descripcion.Location = new System.Drawing.Point(8, 114);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(701, 23);
            this.txt_Descripcion.TabIndex = 6;
            // 
            // dtg_Componentes
            // 
            this.dtg_Componentes.AllowUserToAddRows = false;
            this.dtg_Componentes.AllowUserToDeleteRows = false;
            this.dtg_Componentes.AllowUserToResizeRows = false;
            this.dtg_Componentes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Componentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_Componentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Componentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colComponente,
            this.colMarca,
            this.colModelo,
            this.colSerial,
            this.colDato});
            this.dtg_Componentes.Location = new System.Drawing.Point(8, 168);
            this.dtg_Componentes.Name = "dtg_Componentes";
            this.dtg_Componentes.RowHeadersVisible = false;
            this.dtg_Componentes.Size = new System.Drawing.Size(701, 232);
            this.dtg_Componentes.TabIndex = 5;
            this.dtg_Componentes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Componentes_CellEndEdit);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = false;
            // 
            // colComponente
            // 
            this.colComponente.HeaderText = "Componente";
            this.colComponente.Name = "colComponente";
            this.colComponente.Width = 210;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMarca.Width = 120;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSerial
            // 
            this.colSerial.HeaderText = "Serial";
            this.colSerial.Name = "colSerial";
            this.colSerial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDato
            // 
            this.colDato.HeaderText = "Dato Adicional";
            this.colDato.Name = "colDato";
            this.colDato.Width = 140;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Componentes de Equipo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Botones.Controls.Add(this.Btn_DarDeBaja);
            this.Pnl_Botones.Controls.Add(this.btn_Salir);
            this.Pnl_Botones.Controls.Add(this.btn_Cancelar);
            this.Pnl_Botones.Controls.Add(this.btn_Grabar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Botones.Location = new System.Drawing.Point(749, 3);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(110, 398);
            this.Pnl_Botones.TabIndex = 18;
            // 
            // Btn_DarDeBaja
            // 
            this.Btn_DarDeBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DarDeBaja.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_DarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DarDeBaja.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DarDeBaja.Image")));
            this.Btn_DarDeBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DarDeBaja.Location = new System.Drawing.Point(6, 85);
            this.Btn_DarDeBaja.Name = "Btn_DarDeBaja";
            this.Btn_DarDeBaja.Size = new System.Drawing.Size(99, 35);
            this.Btn_DarDeBaja.TabIndex = 15;
            this.Btn_DarDeBaja.Text = "Dar de Baja";
            this.Btn_DarDeBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_DarDeBaja.UseVisualStyleBackColor = true;
            this.Btn_DarDeBaja.Visible = false;
            this.Btn_DarDeBaja.Click += new System.EventHandler(this.Btn_DarDeBaja_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(5, 361);
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
            // tbc_Principal
            // 
            this.tbc_Principal.Controls.Add(this.tpg_NuevoEquipo);
            this.tbc_Principal.Controls.Add(this.tpg_VerEquipos);
            this.tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_Principal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Principal.Location = new System.Drawing.Point(0, 0);
            this.tbc_Principal.Name = "tbc_Principal";
            this.tbc_Principal.SelectedIndex = 0;
            this.tbc_Principal.Size = new System.Drawing.Size(870, 434);
            this.tbc_Principal.TabIndex = 20;
            // 
            // tpg_NuevoEquipo
            // 
            this.tpg_NuevoEquipo.Controls.Add(this.label13);
            this.tpg_NuevoEquipo.Controls.Add(this.label12);
            this.tpg_NuevoEquipo.Controls.Add(this.txt_marca);
            this.tpg_NuevoEquipo.Controls.Add(this.txt_serial);
            this.tpg_NuevoEquipo.Controls.Add(this.txt_Etiqueta);
            this.tpg_NuevoEquipo.Controls.Add(this.Pnl_Botones);
            this.tpg_NuevoEquipo.Controls.Add(this.dtg_Componentes);
            this.tpg_NuevoEquipo.Controls.Add(this.cmb_tipoEquipo);
            this.tpg_NuevoEquipo.Controls.Add(this.btn_Remove);
            this.tpg_NuevoEquipo.Controls.Add(this.Cmb_Ubicacion);
            this.tpg_NuevoEquipo.Controls.Add(this.btn_add);
            this.tpg_NuevoEquipo.Controls.Add(this.Cmb_Empleado);
            this.tpg_NuevoEquipo.Controls.Add(this.label1);
            this.tpg_NuevoEquipo.Controls.Add(this.txt_Descripcion);
            this.tpg_NuevoEquipo.Controls.Add(this.label11);
            this.tpg_NuevoEquipo.Controls.Add(this.label3);
            this.tpg_NuevoEquipo.Controls.Add(this.label5);
            this.tpg_NuevoEquipo.Controls.Add(this.label6);
            this.tpg_NuevoEquipo.Controls.Add(this.label2);
            this.tpg_NuevoEquipo.Controls.Add(this.lbl_Codigo);
            this.tpg_NuevoEquipo.Controls.Add(this.label4);
            this.tpg_NuevoEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpg_NuevoEquipo.Location = new System.Drawing.Point(4, 26);
            this.tpg_NuevoEquipo.Name = "tpg_NuevoEquipo";
            this.tpg_NuevoEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_NuevoEquipo.Size = new System.Drawing.Size(862, 404);
            this.tpg_NuevoEquipo.TabIndex = 0;
            this.tpg_NuevoEquipo.Text = "Nuevo Equipo";
            this.tpg_NuevoEquipo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Serial";
            // 
            // txt_serial
            // 
            this.txt_serial.BackColor = System.Drawing.Color.White;
            this.txt_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_serial.EJ_Cedula = false;
            this.txt_serial.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_serial.EJ_Decimales = false;
            this.txt_serial.EJ_Dinero = false;
            this.txt_serial.EJ_Mayúsculas = false;
            this.txt_serial.EJ_Requerido = true;
            this.txt_serial.EJ_Saltar = false;
            this.txt_serial.EJ_SoloNumero = false;
            this.txt_serial.EJ_TextoInformativo = null;
            this.txt_serial.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_serial.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_serial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serial.Location = new System.Drawing.Point(364, 22);
            this.txt_serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_serial.MaxLength = 20;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(143, 23);
            this.txt_serial.TabIndex = 2;
            this.txt_serial.Tag = "Serial";
            // 
            // txt_Etiqueta
            // 
            this.txt_Etiqueta.BackColor = System.Drawing.Color.White;
            this.txt_Etiqueta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Etiqueta.EJ_Cedula = false;
            this.txt_Etiqueta.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_Etiqueta.EJ_Decimales = false;
            this.txt_Etiqueta.EJ_Dinero = false;
            this.txt_Etiqueta.EJ_Mayúsculas = false;
            this.txt_Etiqueta.EJ_Requerido = true;
            this.txt_Etiqueta.EJ_Saltar = false;
            this.txt_Etiqueta.EJ_SoloNumero = false;
            this.txt_Etiqueta.EJ_TextoInformativo = null;
            this.txt_Etiqueta.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Etiqueta.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Etiqueta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Etiqueta.Location = new System.Drawing.Point(67, 22);
            this.txt_Etiqueta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Etiqueta.Name = "txt_Etiqueta";
            this.txt_Etiqueta.Size = new System.Drawing.Size(143, 23);
            this.txt_Etiqueta.TabIndex = 0;
            this.txt_Etiqueta.Tag = "Etiqueta";
            this.txt_Etiqueta.Validated += new System.EventHandler(this.txt_Etiqueta_Validated);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_Remove.Image")));
            this.btn_Remove.Location = new System.Drawing.Point(713, 231);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(32, 32);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(713, 193);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(32, 32);
            this.btn_add.TabIndex = 10;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Etiqueta";
            // 
            // tpg_VerEquipos
            // 
            this.tpg_VerEquipos.Controls.Add(this.label10);
            this.tpg_VerEquipos.Controls.Add(this.btn_Refrescar);
            this.tpg_VerEquipos.Controls.Add(this.label9);
            this.tpg_VerEquipos.Controls.Add(this.txt_descrip);
            this.tpg_VerEquipos.Controls.Add(this.label8);
            this.tpg_VerEquipos.Controls.Add(this.txt_responsable);
            this.tpg_VerEquipos.Controls.Add(this.label7);
            this.tpg_VerEquipos.Controls.Add(this.txt_ubicacion);
            this.tpg_VerEquipos.Controls.Add(this.txt_tipo);
            this.tpg_VerEquipos.Controls.Add(this.dtg_ListaEquipos);
            this.tpg_VerEquipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpg_VerEquipos.Location = new System.Drawing.Point(4, 26);
            this.tpg_VerEquipos.Name = "tpg_VerEquipos";
            this.tpg_VerEquipos.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_VerEquipos.Size = new System.Drawing.Size(862, 404);
            this.tpg_VerEquipos.TabIndex = 1;
            this.tpg_VerEquipos.Text = "Lista de Equipos";
            this.tpg_VerEquipos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dados de Baja";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackColor = System.Drawing.Color.White;
            this.btn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.Image")));
            this.btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refrescar.Location = new System.Drawing.Point(758, 4);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(91, 22);
            this.btn_Refrescar.TabIndex = 11;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Refrescar.UseVisualStyleBackColor = false;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Activos";
            // 
            // txt_descrip
            // 
            this.txt_descrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.Location = new System.Drawing.Point(476, 4);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(268, 22);
            this.txt_descrip.TabIndex = 3;
            this.txt_descrip.Tag = "4";
            this.txt_descrip.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(77, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 12);
            this.label8.TabIndex = 21;
            // 
            // txt_responsable
            // 
            this.txt_responsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_responsable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_responsable.Location = new System.Drawing.Point(285, 4);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.Size = new System.Drawing.Size(190, 22);
            this.txt_responsable.TabIndex = 2;
            this.txt_responsable.Tag = "3";
            this.txt_responsable.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_responsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(3, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 12);
            this.label7.TabIndex = 21;
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ubicacion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion.Location = new System.Drawing.Point(135, 4);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(149, 22);
            this.txt_ubicacion.TabIndex = 1;
            this.txt_ubicacion.Tag = "2";
            this.txt_ubicacion.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_ubicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_tipo
            // 
            this.txt_tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(3, 4);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(131, 22);
            this.txt_tipo.TabIndex = 0;
            this.txt_tipo.Tag = "1";
            this.txt_tipo.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // dtg_ListaEquipos
            // 
            this.dtg_ListaEquipos.AllowUserToAddRows = false;
            this.dtg_ListaEquipos.AllowUserToDeleteRows = false;
            this.dtg_ListaEquipos.AllowUserToResizeRows = false;
            this.dtg_ListaEquipos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ListaEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_ListaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListaEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colUbicacion,
            this.colResponsable,
            this.ColDescripcion,
            this.colFecha});
            this.dtg_ListaEquipos.Location = new System.Drawing.Point(3, 29);
            this.dtg_ListaEquipos.Name = "dtg_ListaEquipos";
            this.dtg_ListaEquipos.ReadOnly = true;
            this.dtg_ListaEquipos.RowHeadersVisible = false;
            this.dtg_ListaEquipos.Size = new System.Drawing.Size(856, 345);
            this.dtg_ListaEquipos.TabIndex = 10;
            this.dtg_ListaEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ListaEquipos_CellDoubleClick);
            this.dtg_ListaEquipos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_ListaEquipos_CellFormatting);
            // 
            // colTipo
            // 
            this.colTipo.DataPropertyName = "TipoEquipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 130;
            // 
            // colUbicacion
            // 
            this.colUbicacion.DataPropertyName = "nombreUbicacion";
            this.colUbicacion.HeaderText = "Ubicación";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            this.colUbicacion.Width = 150;
            // 
            // colResponsable
            // 
            this.colResponsable.DataPropertyName = "nombreEmpleado";
            this.colResponsable.HeaderText = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.ReadOnly = true;
            this.colResponsable.Width = 190;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.DataPropertyName = "descripcion";
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 270;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "fechaCreacion";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle9;
            this.colFecha.HeaderText = "F. Resgistro";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 90;
            // 
            // txt_marca
            // 
            this.txt_marca.BackColor = System.Drawing.Color.White;
            this.txt_marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_marca.EJ_Cedula = false;
            this.txt_marca.EJ_ColorTexto = System.Drawing.Color.Empty;
            this.txt_marca.EJ_Decimales = false;
            this.txt_marca.EJ_Dinero = false;
            this.txt_marca.EJ_Mayúsculas = false;
            this.txt_marca.EJ_Requerido = true;
            this.txt_marca.EJ_Saltar = false;
            this.txt_marca.EJ_SoloNumero = false;
            this.txt_marca.EJ_TextoInformativo = null;
            this.txt_marca.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_marca.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_marca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(213, 22);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_marca.MaxLength = 20;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(145, 23);
            this.txt_marca.TabIndex = 1;
            this.txt_marca.Tag = "Marca";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Marca";
            // 
            // Frm_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 434);
            this.Controls.Add(this.tbc_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Equipos";
            this.Load += new System.EventHandler(this.Frm_Equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Componentes)).EndInit();
            this.Pnl_Botones.ResumeLayout(false);
            this.tbc_Principal.ResumeLayout(false);
            this.tpg_NuevoEquipo.ResumeLayout(false);
            this.tpg_NuevoEquipo.PerformLayout();
            this.tpg_VerEquipos.ResumeLayout(false);
            this.tpg_VerEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipoEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Ubicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.DataGridView dtg_Componentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.TabControl tbc_Principal;
        private System.Windows.Forms.TabPage tpg_NuevoEquipo;
        private System.Windows.Forms.TabPage tpg_VerEquipos;
        private System.Windows.Forms.DataGridView dtg_ListaEquipos;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button Btn_DarDeBaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private CajaDeTexto.CajaDeTexto txt_Etiqueta;
        private System.Windows.Forms.Label label11;
        private CajaDeTexto.CajaDeTexto txt_serial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDato;
        private System.Windows.Forms.Label label13;
        private CajaDeTexto.CajaDeTexto txt_marca;
    }
}