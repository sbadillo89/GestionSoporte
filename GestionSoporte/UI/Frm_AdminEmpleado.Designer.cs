namespace GestionSoporte.UI
{
    partial class Frm_AdminEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdminEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_Principal = new System.Windows.Forms.TabControl();
            this.tpg_datosEmpleado = new System.Windows.Forms.TabPage();
            this.dtp_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new CajaDeTexto.CajaDeTexto();
            this.txt_sApellido = new CajaDeTexto.CajaDeTexto();
            this.txt_pApellido = new CajaDeTexto.CajaDeTexto();
            this.txt_telefono = new CajaDeTexto.CajaDeTexto();
            this.txt_sNombre = new CajaDeTexto.CajaDeTexto();
            this.txt_direccion = new CajaDeTexto.CajaDeTexto();
            this.txt_pNombre = new CajaDeTexto.CajaDeTexto();
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.cmb_TipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_NumDocumento = new CajaDeTexto.CajaDeTexto();
            this.tpg_datosUsuario = new System.Windows.Forms.TabPage();
            this.Cmb_PerfilUsu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_GrabarUsu = new System.Windows.Forms.Button();
            this.lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_contraseña2 = new CajaDeTexto.CajaDeTexto();
            this.txt_contraseña1 = new CajaDeTexto.CajaDeTexto();
            this.Dtg_Empleados = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbc_Principal.SuspendLayout();
            this.tpg_datosEmpleado.SuspendLayout();
            this.Pnl_Botones.SuspendLayout();
            this.tpg_datosUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbc_Principal
            // 
            this.Tbc_Principal.Controls.Add(this.tpg_datosEmpleado);
            this.Tbc_Principal.Controls.Add(this.tpg_datosUsuario);
            this.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tbc_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Principal.Name = "Tbc_Principal";
            this.Tbc_Principal.SelectedIndex = 0;
            this.Tbc_Principal.Size = new System.Drawing.Size(827, 173);
            this.Tbc_Principal.TabIndex = 80;
            this.Tbc_Principal.SelectedIndexChanged += new System.EventHandler(this.Tbc_Principal_SelectedIndexChanged);
            // 
            // tpg_datosEmpleado
            // 
            this.tpg_datosEmpleado.Controls.Add(this.dtp_fechaNac);
            this.tpg_datosEmpleado.Controls.Add(this.label10);
            this.tpg_datosEmpleado.Controls.Add(this.label6);
            this.tpg_datosEmpleado.Controls.Add(this.label9);
            this.tpg_datosEmpleado.Controls.Add(this.label5);
            this.tpg_datosEmpleado.Controls.Add(this.label8);
            this.tpg_datosEmpleado.Controls.Add(this.label7);
            this.tpg_datosEmpleado.Controls.Add(this.label4);
            this.tpg_datosEmpleado.Controls.Add(this.label3);
            this.tpg_datosEmpleado.Controls.Add(this.label2);
            this.tpg_datosEmpleado.Controls.Add(this.label1);
            this.tpg_datosEmpleado.Controls.Add(this.txt_correo);
            this.tpg_datosEmpleado.Controls.Add(this.txt_sApellido);
            this.tpg_datosEmpleado.Controls.Add(this.txt_pApellido);
            this.tpg_datosEmpleado.Controls.Add(this.txt_telefono);
            this.tpg_datosEmpleado.Controls.Add(this.txt_sNombre);
            this.tpg_datosEmpleado.Controls.Add(this.txt_direccion);
            this.tpg_datosEmpleado.Controls.Add(this.txt_pNombre);
            this.tpg_datosEmpleado.Controls.Add(this.Pnl_Botones);
            this.tpg_datosEmpleado.Controls.Add(this.cmb_TipoDoc);
            this.tpg_datosEmpleado.Controls.Add(this.txt_NumDocumento);
            this.tpg_datosEmpleado.Location = new System.Drawing.Point(4, 24);
            this.tpg_datosEmpleado.Name = "tpg_datosEmpleado";
            this.tpg_datosEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_datosEmpleado.Size = new System.Drawing.Size(819, 145);
            this.tpg_datosEmpleado.TabIndex = 0;
            this.tpg_datosEmpleado.Text = "Datos de Empleado";
            this.tpg_datosEmpleado.UseVisualStyleBackColor = true;
            // 
            // dtp_fechaNac
            // 
            this.dtp_fechaNac.CustomFormat = "yyyy/MM/dd";
            this.dtp_fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaNac.Location = new System.Drawing.Point(352, 112);
            this.dtp_fechaNac.Name = "dtp_fechaNac";
            this.dtp_fechaNac.Size = new System.Drawing.Size(117, 23);
            this.dtp_fechaNac.TabIndex = 8;
            this.dtp_fechaNac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Segundo Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Primer Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Segundo  Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Documento";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_correo.EJ_Cedula = false;
            this.txt_correo.EJ_Decimales = false;
            this.txt_correo.EJ_Dinero = false;
            this.txt_correo.EJ_Mayúsculas = false;
            this.txt_correo.EJ_Requerido = false;
            this.txt_correo.EJ_Saltar = false;
            this.txt_correo.EJ_SoloNumero = false;
            this.txt_correo.EJ_TextoInformativo = null;
            this.txt_correo.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_correo.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_correo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(475, 112);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(215, 23);
            this.txt_correo.TabIndex = 9;
            this.txt_correo.Tag = "";
            // 
            // txt_sApellido
            // 
            this.txt_sApellido.BackColor = System.Drawing.Color.White;
            this.txt_sApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sApellido.EJ_Cedula = false;
            this.txt_sApellido.EJ_Decimales = false;
            this.txt_sApellido.EJ_Dinero = false;
            this.txt_sApellido.EJ_Mayúsculas = false;
            this.txt_sApellido.EJ_Requerido = false;
            this.txt_sApellido.EJ_Saltar = false;
            this.txt_sApellido.EJ_SoloNumero = false;
            this.txt_sApellido.EJ_TextoInformativo = null;
            this.txt_sApellido.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_sApellido.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_sApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sApellido.ForeColor = System.Drawing.Color.Black;
            this.txt_sApellido.Location = new System.Drawing.Point(524, 65);
            this.txt_sApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sApellido.Name = "txt_sApellido";
            this.txt_sApellido.Size = new System.Drawing.Size(166, 23);
            this.txt_sApellido.TabIndex = 5;
            this.txt_sApellido.Tag = "";
            // 
            // txt_pApellido
            // 
            this.txt_pApellido.BackColor = System.Drawing.Color.White;
            this.txt_pApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pApellido.EJ_Cedula = false;
            this.txt_pApellido.EJ_Decimales = false;
            this.txt_pApellido.EJ_Dinero = false;
            this.txt_pApellido.EJ_Mayúsculas = false;
            this.txt_pApellido.EJ_Requerido = true;
            this.txt_pApellido.EJ_Saltar = false;
            this.txt_pApellido.EJ_SoloNumero = false;
            this.txt_pApellido.EJ_TextoInformativo = null;
            this.txt_pApellido.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_pApellido.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_pApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pApellido.ForeColor = System.Drawing.Color.Black;
            this.txt_pApellido.Location = new System.Drawing.Point(352, 65);
            this.txt_pApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pApellido.Name = "txt_pApellido";
            this.txt_pApellido.Size = new System.Drawing.Size(166, 23);
            this.txt_pApellido.TabIndex = 4;
            this.txt_pApellido.Tag = "Primer Apellido";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telefono.EJ_Cedula = false;
            this.txt_telefono.EJ_Decimales = false;
            this.txt_telefono.EJ_Dinero = false;
            this.txt_telefono.EJ_Mayúsculas = false;
            this.txt_telefono.EJ_Requerido = false;
            this.txt_telefono.EJ_Saltar = false;
            this.txt_telefono.EJ_SoloNumero = false;
            this.txt_telefono.EJ_TextoInformativo = null;
            this.txt_telefono.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_telefono.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(212, 112);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(134, 23);
            this.txt_telefono.TabIndex = 7;
            this.txt_telefono.Tag = "";
            // 
            // txt_sNombre
            // 
            this.txt_sNombre.BackColor = System.Drawing.Color.White;
            this.txt_sNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sNombre.EJ_Cedula = false;
            this.txt_sNombre.EJ_Decimales = false;
            this.txt_sNombre.EJ_Dinero = false;
            this.txt_sNombre.EJ_Mayúsculas = false;
            this.txt_sNombre.EJ_Requerido = false;
            this.txt_sNombre.EJ_Saltar = false;
            this.txt_sNombre.EJ_SoloNumero = false;
            this.txt_sNombre.EJ_TextoInformativo = null;
            this.txt_sNombre.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_sNombre.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_sNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sNombre.ForeColor = System.Drawing.Color.Black;
            this.txt_sNombre.Location = new System.Drawing.Point(181, 65);
            this.txt_sNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sNombre.Name = "txt_sNombre";
            this.txt_sNombre.Size = new System.Drawing.Size(166, 23);
            this.txt_sNombre.TabIndex = 3;
            this.txt_sNombre.Tag = "";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.White;
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion.EJ_Cedula = false;
            this.txt_direccion.EJ_Decimales = false;
            this.txt_direccion.EJ_Dinero = false;
            this.txt_direccion.EJ_Mayúsculas = false;
            this.txt_direccion.EJ_Requerido = false;
            this.txt_direccion.EJ_Saltar = false;
            this.txt_direccion.EJ_SoloNumero = false;
            this.txt_direccion.EJ_TextoInformativo = null;
            this.txt_direccion.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_direccion.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(9, 112);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(197, 23);
            this.txt_direccion.TabIndex = 6;
            this.txt_direccion.Tag = "Dirección";
            // 
            // txt_pNombre
            // 
            this.txt_pNombre.BackColor = System.Drawing.Color.White;
            this.txt_pNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pNombre.EJ_Cedula = false;
            this.txt_pNombre.EJ_Decimales = false;
            this.txt_pNombre.EJ_Dinero = false;
            this.txt_pNombre.EJ_Mayúsculas = false;
            this.txt_pNombre.EJ_Requerido = true;
            this.txt_pNombre.EJ_Saltar = false;
            this.txt_pNombre.EJ_SoloNumero = false;
            this.txt_pNombre.EJ_TextoInformativo = null;
            this.txt_pNombre.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_pNombre.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_pNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pNombre.ForeColor = System.Drawing.Color.Black;
            this.txt_pNombre.Location = new System.Drawing.Point(9, 65);
            this.txt_pNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pNombre.Name = "txt_pNombre";
            this.txt_pNombre.Size = new System.Drawing.Size(166, 23);
            this.txt_pNombre.TabIndex = 2;
            this.txt_pNombre.Tag = "Primer Nombre";
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Botones.Controls.Add(this.btn_Salir);
            this.Pnl_Botones.Controls.Add(this.btn_Cancelar);
            this.Pnl_Botones.Controls.Add(this.btn_Grabar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Botones.Location = new System.Drawing.Point(706, 3);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(110, 139);
            this.Pnl_Botones.TabIndex = 16;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(6, 88);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(6, 51);
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
            this.btn_Grabar.Location = new System.Drawing.Point(6, 13);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(99, 35);
            this.btn_Grabar.TabIndex = 15;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_TipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(180, 21);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Size = new System.Drawing.Size(166, 23);
            this.cmb_TipoDoc.TabIndex = 1;
            this.cmb_TipoDoc.Tag = "Tipo de Documento";
            this.cmb_TipoDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // txt_NumDocumento
            // 
            this.txt_NumDocumento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_NumDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumDocumento.EJ_Cedula = true;
            this.txt_NumDocumento.EJ_Decimales = false;
            this.txt_NumDocumento.EJ_Dinero = false;
            this.txt_NumDocumento.EJ_Mayúsculas = false;
            this.txt_NumDocumento.EJ_Requerido = true;
            this.txt_NumDocumento.EJ_Saltar = false;
            this.txt_NumDocumento.EJ_SoloNumero = false;
            this.txt_NumDocumento.EJ_TextoInformativo = null;
            this.txt_NumDocumento.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_NumDocumento.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_NumDocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumDocumento.ForeColor = System.Drawing.Color.Black;
            this.txt_NumDocumento.Location = new System.Drawing.Point(9, 21);
            this.txt_NumDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NumDocumento.Name = "txt_NumDocumento";
            this.txt_NumDocumento.Size = new System.Drawing.Size(166, 23);
            this.txt_NumDocumento.TabIndex = 0;
            this.txt_NumDocumento.Tag = "NÚMERO DE DOCUMENTO";
            this.txt_NumDocumento.Validated += new System.EventHandler(this.txt_NumDocumento_Validated);
            // 
            // tpg_datosUsuario
            // 
            this.tpg_datosUsuario.Controls.Add(this.Cmb_PerfilUsu);
            this.tpg_datosUsuario.Controls.Add(this.panel1);
            this.tpg_datosUsuario.Controls.Add(this.lbl_NombreEmpleado);
            this.tpg_datosUsuario.Controls.Add(this.label12);
            this.tpg_datosUsuario.Controls.Add(this.label13);
            this.tpg_datosUsuario.Controls.Add(this.label15);
            this.tpg_datosUsuario.Controls.Add(this.txt_contraseña2);
            this.tpg_datosUsuario.Controls.Add(this.txt_contraseña1);
            this.tpg_datosUsuario.Location = new System.Drawing.Point(4, 24);
            this.tpg_datosUsuario.Name = "tpg_datosUsuario";
            this.tpg_datosUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_datosUsuario.Size = new System.Drawing.Size(819, 145);
            this.tpg_datosUsuario.TabIndex = 1;
            this.tpg_datosUsuario.Text = "Datos de Usuario";
            this.tpg_datosUsuario.UseVisualStyleBackColor = true;
            // 
            // Cmb_PerfilUsu
            // 
            this.Cmb_PerfilUsu.FormattingEnabled = true;
            this.Cmb_PerfilUsu.Location = new System.Drawing.Point(9, 21);
            this.Cmb_PerfilUsu.Name = "Cmb_PerfilUsu";
            this.Cmb_PerfilUsu.Size = new System.Drawing.Size(166, 23);
            this.Cmb_PerfilUsu.TabIndex = 0; 
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_GrabarUsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(706, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 139);
            this.panel1.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 35);
            this.button3.TabIndex = 42;
            this.button3.Text = "Salir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(6, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 35);
            this.button4.TabIndex = 41;
            this.button4.Text = "Cancelar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_GrabarUsu
            // 
            this.btn_GrabarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GrabarUsu.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_GrabarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GrabarUsu.Image = ((System.Drawing.Image)(resources.GetObject("btn_GrabarUsu.Image")));
            this.btn_GrabarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GrabarUsu.Location = new System.Drawing.Point(6, 13);
            this.btn_GrabarUsu.Name = "btn_GrabarUsu";
            this.btn_GrabarUsu.Size = new System.Drawing.Size(99, 35);
            this.btn_GrabarUsu.TabIndex = 40;
            this.btn_GrabarUsu.Text = "Grabar";
            this.btn_GrabarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GrabarUsu.UseVisualStyleBackColor = true;
            this.btn_GrabarUsu.Click += new System.EventHandler(this.btn_GrabarUsu_Click);
            // 
            // lbl_NombreEmpleado
            // 
            this.lbl_NombreEmpleado.AutoSize = true;
            this.lbl_NombreEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreEmpleado.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_NombreEmpleado.Location = new System.Drawing.Point(182, 22);
            this.lbl_NombreEmpleado.Name = "lbl_NombreEmpleado";
            this.lbl_NombreEmpleado.Size = new System.Drawing.Size(22, 21);
            this.lbl_NombreEmpleado.TabIndex = 25;
            this.lbl_NombreEmpleado.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Verificación Contraseña";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Perfil de Usuario";
            // 
            // txt_contraseña2
            // 
            this.txt_contraseña2.BackColor = System.Drawing.Color.White;
            this.txt_contraseña2.EJ_Cedula = false;
            this.txt_contraseña2.EJ_Decimales = false;
            this.txt_contraseña2.EJ_Dinero = false;
            this.txt_contraseña2.EJ_Mayúsculas = false;
            this.txt_contraseña2.EJ_Requerido = false;
            this.txt_contraseña2.EJ_Saltar = false;
            this.txt_contraseña2.EJ_SoloNumero = false;
            this.txt_contraseña2.EJ_TextoInformativo = null;
            this.txt_contraseña2.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_contraseña2.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_contraseña2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña2.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña2.Location = new System.Drawing.Point(181, 65);
            this.txt_contraseña2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_contraseña2.MaxLength = 20;
            this.txt_contraseña2.Name = "txt_contraseña2";
            this.txt_contraseña2.PasswordChar = '*';
            this.txt_contraseña2.Size = new System.Drawing.Size(166, 25);
            this.txt_contraseña2.TabIndex = 32;
            this.txt_contraseña2.Tag = "";
            this.txt_contraseña2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contraseña2.Validated += new System.EventHandler(this.txt_contraseña2_Validated);
            // 
            // txt_contraseña1
            // 
            this.txt_contraseña1.BackColor = System.Drawing.Color.White;
            this.txt_contraseña1.EJ_Cedula = false;
            this.txt_contraseña1.EJ_Decimales = false;
            this.txt_contraseña1.EJ_Dinero = false;
            this.txt_contraseña1.EJ_Mayúsculas = false;
            this.txt_contraseña1.EJ_Requerido = false;
            this.txt_contraseña1.EJ_Saltar = false;
            this.txt_contraseña1.EJ_SoloNumero = false;
            this.txt_contraseña1.EJ_TextoInformativo = null;
            this.txt_contraseña1.EJ_ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_contraseña1.EJ_ValorMinimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_contraseña1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña1.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña1.Location = new System.Drawing.Point(9, 65);
            this.txt_contraseña1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_contraseña1.MaxLength = 20;
            this.txt_contraseña1.Name = "txt_contraseña1";
            this.txt_contraseña1.PasswordChar = '*';
            this.txt_contraseña1.Size = new System.Drawing.Size(166, 25);
            this.txt_contraseña1.TabIndex = 31;
            this.txt_contraseña1.Tag = "";
            this.txt_contraseña1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dtg_Empleados
            // 
            this.Dtg_Empleados.AllowUserToAddRows = false;
            this.Dtg_Empleados.AllowUserToDeleteRows = false;
            this.Dtg_Empleados.AllowUserToResizeRows = false;
            this.Dtg_Empleados.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colEmpleado,
            this.colDireccion,
            this.colTelefono,
            this.colFechaNac,
            this.colCorreo});
            this.Dtg_Empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dtg_Empleados.Location = new System.Drawing.Point(0, 173);
            this.Dtg_Empleados.Name = "Dtg_Empleados";
            this.Dtg_Empleados.ReadOnly = true;
            this.Dtg_Empleados.RowHeadersVisible = false;
            this.Dtg_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Empleados.Size = new System.Drawing.Size(827, 287);
            this.Dtg_Empleados.TabIndex = 100;
            this.Dtg_Empleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Empleados_CellDoubleClick);
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numeroDocumento";
            this.colNumero.HeaderText = "No. Documento";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 120;
            // 
            // colEmpleado
            // 
            this.colEmpleado.DataPropertyName = "NombreCompleto";
            this.colEmpleado.HeaderText = "Nombre Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 250;
            // 
            // colDireccion
            // 
            this.colDireccion.DataPropertyName = "direccion";
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 130;
            // 
            // colTelefono
            // 
            this.colTelefono.DataPropertyName = "telefono";
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 80;
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "fechaNacimiento";
            this.colFechaNac.HeaderText = "F. Nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Width = 110;
            // 
            // colCorreo
            // 
            this.colCorreo.DataPropertyName = "correo";
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 120;
            // 
            // Frm_AdminEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 493);
            this.Controls.Add(this.Dtg_Empleados);
            this.Controls.Add(this.Tbc_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AdminEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Empleados";
            this.Load += new System.EventHandler(this.Frm_AdminEmpleado_Load);
            this.Tbc_Principal.ResumeLayout(false);
            this.tpg_datosEmpleado.ResumeLayout(false);
            this.tpg_datosEmpleado.PerformLayout();
            this.Pnl_Botones.ResumeLayout(false);
            this.tpg_datosUsuario.ResumeLayout(false);
            this.tpg_datosUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Principal;
        private CajaDeTexto.CajaDeTexto txt_NumDocumento;
        private System.Windows.Forms.TabPage tpg_datosEmpleado;
        private System.Windows.Forms.TabPage tpg_datosUsuario;
       
        private System.Windows.Forms.ComboBox cmb_TipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CajaDeTexto.CajaDeTexto txt_correo;
        private CajaDeTexto.CajaDeTexto txt_sApellido;
        private CajaDeTexto.CajaDeTexto txt_pApellido;
        private CajaDeTexto.CajaDeTexto txt_telefono;
        private CajaDeTexto.CajaDeTexto txt_sNombre;
        private CajaDeTexto.CajaDeTexto txt_direccion;
        private CajaDeTexto.CajaDeTexto txt_pNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fechaNac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private CajaDeTexto.CajaDeTexto txt_contraseña2;
        private CajaDeTexto.CajaDeTexto txt_contraseña1;
        private System.Windows.Forms.Label lbl_NombreEmpleado;
        private System.Windows.Forms.DataGridView Dtg_Empleados;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_GrabarUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.ComboBox Cmb_PerfilUsu;
    }
}