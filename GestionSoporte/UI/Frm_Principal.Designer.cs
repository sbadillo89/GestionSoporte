namespace GestionSoporte.UI
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.spc_Contenedor = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaIni = new System.Windows.Forms.DateTimePicker();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Config = new System.Windows.Forms.Button();
            this.btn_Solicitud = new System.Windows.Forms.Button();
            this.Btn_Equipos = new System.Windows.Forms.Button();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.spc_Interno = new System.Windows.Forms.SplitContainer();
            this.pnl_usuario = new System.Windows.Forms.Panel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.controlPanel1 = new ControlInfo.ControlPanel();
            this.Pnl_Historias = new System.Windows.Forms.Panel();
            this.gbx_Detalles = new System.Windows.Forms.GroupBox();
            this.lbl_FechaIni = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.lbl_usuGenera = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_TipoSolicitud = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Equipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Botones = new System.Windows.Forms.Panel();
            this.Btn_Asignar = new System.Windows.Forms.Button();
            this.Btn_Procesar = new System.Windows.Forms.Button();
            this.Btn_Aplazar = new System.Windows.Forms.Button();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.pnl_msg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Contenedor)).BeginInit();
            this.spc_Contenedor.Panel1.SuspendLayout();
            this.spc_Contenedor.Panel2.SuspendLayout();
            this.spc_Contenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Interno)).BeginInit();
            this.spc_Interno.Panel1.SuspendLayout();
            this.spc_Interno.Panel2.SuspendLayout();
            this.spc_Interno.SuspendLayout();
            this.pnl_usuario.SuspendLayout();
            this.gbx_Detalles.SuspendLayout();
            this.pnl_Botones.SuspendLayout();
            this.pnl_msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc_Contenedor
            // 
            this.spc_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Contenedor.IsSplitterFixed = true;
            this.spc_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.spc_Contenedor.Name = "spc_Contenedor";
            // 
            // spc_Contenedor.Panel1
            // 
            this.spc_Contenedor.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spc_Contenedor.Panel1.Controls.Add(this.label2);
            this.spc_Contenedor.Panel1.Controls.Add(this.label1);
            this.spc_Contenedor.Panel1.Controls.Add(this.Dtp_FechaFin);
            this.spc_Contenedor.Panel1.Controls.Add(this.Dtp_FechaIni);
            this.spc_Contenedor.Panel1.Controls.Add(this.Btn_Salir);
            this.spc_Contenedor.Panel1.Controls.Add(this.Btn_Config);
            this.spc_Contenedor.Panel1.Controls.Add(this.btn_Solicitud);
            this.spc_Contenedor.Panel1.Controls.Add(this.Btn_Equipos);
            this.spc_Contenedor.Panel1.Controls.Add(this.Btn_Consultar);
            this.spc_Contenedor.Panel1.Controls.Add(this.groupBox1);
            // 
            // spc_Contenedor.Panel2
            // 
            this.spc_Contenedor.Panel2.BackColor = System.Drawing.Color.White;
            this.spc_Contenedor.Panel2.Controls.Add(this.spc_Interno);
            this.spc_Contenedor.Size = new System.Drawing.Size(1056, 480);
            this.spc_Contenedor.SplitterDistance = 218;
            this.spc_Contenedor.SplitterWidth = 2;
            this.spc_Contenedor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha Inicial";
            // 
            // Dtp_FechaFin
            // 
            this.Dtp_FechaFin.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaFin.CustomFormat = "yyyy/MM/dd";
            this.Dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_FechaFin.Location = new System.Drawing.Point(111, 33);
            this.Dtp_FechaFin.Name = "Dtp_FechaFin";
            this.Dtp_FechaFin.Size = new System.Drawing.Size(100, 23);
            this.Dtp_FechaFin.TabIndex = 21;
            this.Dtp_FechaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtp_FechaFin_KeyPress);
            // 
            // Dtp_FechaIni
            // 
            this.Dtp_FechaIni.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaIni.CustomFormat = "yyyy/MM/dd";
            this.Dtp_FechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_FechaIni.Location = new System.Drawing.Point(7, 33);
            this.Dtp_FechaIni.Name = "Dtp_FechaIni";
            this.Dtp_FechaIni.Size = new System.Drawing.Size(100, 23);
            this.Dtp_FechaIni.TabIndex = 21;
            this.Dtp_FechaIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtp_FechaIni_KeyPress);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::GestionSoporte.Properties.Resources.logout;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(110, 420);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(101, 56);
            this.Btn_Salir.TabIndex = 20;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            this.Btn_Salir.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Btn_Salir.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Btn_Config
            // 
            this.Btn_Config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Config.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Config.FlatAppearance.BorderSize = 0;
            this.Btn_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Config.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Config.Image = global::GestionSoporte.Properties.Resources.settings2;
            this.Btn_Config.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Config.Location = new System.Drawing.Point(6, 420);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(101, 56);
            this.Btn_Config.TabIndex = 20;
            this.Btn_Config.Text = "Configuraciones";
            this.Btn_Config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Config.UseVisualStyleBackColor = false;
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            this.Btn_Config.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Btn_Config.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btn_Solicitud
            // 
            this.btn_Solicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Solicitud.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Solicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Solicitud.FlatAppearance.BorderSize = 0;
            this.btn_Solicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Solicitud.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Solicitud.Image = global::GestionSoporte.Properties.Resources.comments;
            this.btn_Solicitud.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Solicitud.Location = new System.Drawing.Point(6, 362);
            this.btn_Solicitud.Name = "btn_Solicitud";
            this.btn_Solicitud.Size = new System.Drawing.Size(101, 56);
            this.btn_Solicitud.TabIndex = 20;
            this.btn_Solicitud.Text = "Nueva Solicitud";
            this.btn_Solicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Solicitud.UseVisualStyleBackColor = false;
            this.btn_Solicitud.Click += new System.EventHandler(this.btn_Solicitud_Click);
            this.btn_Solicitud.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btn_Solicitud.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Btn_Equipos
            // 
            this.Btn_Equipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Equipos.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Equipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Equipos.FlatAppearance.BorderSize = 0;
            this.Btn_Equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Equipos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Equipos.Image = global::GestionSoporte.Properties.Resources.monitor;
            this.Btn_Equipos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Equipos.Location = new System.Drawing.Point(110, 362);
            this.Btn_Equipos.Name = "Btn_Equipos";
            this.Btn_Equipos.Size = new System.Drawing.Size(101, 56);
            this.Btn_Equipos.TabIndex = 20;
            this.Btn_Equipos.Text = "Equipos";
            this.Btn_Equipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Equipos.UseVisualStyleBackColor = false;
            this.Btn_Equipos.Click += new System.EventHandler(this.Btn_Equipos_Click);
            this.Btn_Equipos.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Btn_Equipos.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Consultar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Consultar.FlatAppearance.BorderSize = 0;
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.Image = global::GestionSoporte.Properties.Resources.search;
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.Location = new System.Drawing.Point(6, 198);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(205, 32);
            this.Btn_Consultar.TabIndex = 20;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(6, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estados";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(109, 69);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(86, 19);
            this.radioButton6.TabIndex = 23;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Finalizados";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(11, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 19);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Sin Leer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(10, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 19);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Leidos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(11, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(110, 47);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(86, 19);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.Text = "Procesados";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(110, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 19);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.Text = "Asignados";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // spc_Interno
            // 
            this.spc_Interno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Interno.Location = new System.Drawing.Point(0, 0);
            this.spc_Interno.Name = "spc_Interno";
            // 
            // spc_Interno.Panel1
            // 
            this.spc_Interno.Panel1.Controls.Add(this.pnl_usuario);
            this.spc_Interno.Panel1.Controls.Add(this.controlPanel1);
            // 
            // spc_Interno.Panel2
            // 
            this.spc_Interno.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spc_Interno.Panel2.Controls.Add(this.Pnl_Historias);
            this.spc_Interno.Panel2.Controls.Add(this.gbx_Detalles);
            this.spc_Interno.Panel2.Controls.Add(this.pnl_Botones);
            this.spc_Interno.Size = new System.Drawing.Size(836, 480);
            this.spc_Interno.SplitterDistance = 382;
            this.spc_Interno.TabIndex = 0;
            // 
            // pnl_usuario
            // 
            this.pnl_usuario.BackColor = System.Drawing.Color.White;
            this.pnl_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_usuario.Controls.Add(this.btn_cerrarSesion);
            this.pnl_usuario.Controls.Add(this.label7);
            this.pnl_usuario.Controls.Add(this.lbl_perfil);
            this.pnl_usuario.Controls.Add(this.lbl_usuario);
            this.pnl_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_usuario.Location = new System.Drawing.Point(0, 0);
            this.pnl_usuario.Name = "pnl_usuario";
            this.pnl_usuario.Size = new System.Drawing.Size(382, 34);
            this.pnl_usuario.TabIndex = 1;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarSesion.Image")));
            this.btn_cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(354, 0);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(26, 32);
            this.btn_cerrarSesion.TabIndex = 1;
            this.btn_cerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrarSesion.UseVisualStyleBackColor = true;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            this.btn_cerrarSesion.MouseEnter += new System.EventHandler(this.btn_cerrarSesion_MouseEnter);
            this.btn_cerrarSesion.MouseLeave += new System.EventHandler(this.btn_cerrarSesion_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuario actual:";
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Segoe UI Semibold", 7.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_perfil.ForeColor = System.Drawing.Color.Gray;
            this.lbl_perfil.Location = new System.Drawing.Point(109, 17);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(11, 12);
            this.lbl_perfil.TabIndex = 0;
            this.lbl_perfil.Text = "...";
            this.lbl_perfil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.Gray;
            this.lbl_usuario.Location = new System.Drawing.Point(108, 3);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(17, 17);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "...";
            // 
            // controlPanel1
            // 
            this.controlPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel1.AutoScroll = true;
            this.controlPanel1.codigoItemSeleccionado = null;
            this.controlPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlPanel1.Location = new System.Drawing.Point(0, 33);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.Size = new System.Drawing.Size(382, 447);
            this.controlPanel1.TabIndex = 0;
            this.controlPanel1.PasaItemSelecionado += new ControlInfo.ControlPanel.EventPasaItemSeleccionado(this.controlPanel1_PasaItemSelecionado_1);
            // 
            // Pnl_Historias
            // 
            this.Pnl_Historias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Historias.AutoScroll = true;
            this.Pnl_Historias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_Historias.Location = new System.Drawing.Point(0, 223);
            this.Pnl_Historias.Name = "Pnl_Historias";
            this.Pnl_Historias.Size = new System.Drawing.Size(450, 254);
            this.Pnl_Historias.TabIndex = 3;
            // 
            // gbx_Detalles
            // 
            this.gbx_Detalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_Detalles.Controls.Add(this.lbl_FechaIni);
            this.gbx_Detalles.Controls.Add(this.label8);
            this.gbx_Detalles.Controls.Add(this.lbl_Ubicacion);
            this.gbx_Detalles.Controls.Add(this.lbl_usuGenera);
            this.gbx_Detalles.Controls.Add(this.label6);
            this.gbx_Detalles.Controls.Add(this.label10);
            this.gbx_Detalles.Controls.Add(this.lbl_TipoSolicitud);
            this.gbx_Detalles.Controls.Add(this.label5);
            this.gbx_Detalles.Controls.Add(this.lbl_Descripcion);
            this.gbx_Detalles.Controls.Add(this.lbl_Equipo);
            this.gbx_Detalles.Controls.Add(this.label4);
            this.gbx_Detalles.Controls.Add(this.label3);
            this.gbx_Detalles.Location = new System.Drawing.Point(8, 40);
            this.gbx_Detalles.Name = "gbx_Detalles";
            this.gbx_Detalles.Size = new System.Drawing.Size(435, 180);
            this.gbx_Detalles.TabIndex = 2;
            this.gbx_Detalles.TabStop = false;
            this.gbx_Detalles.Text = "Detalles de Solicitud";
            this.gbx_Detalles.Visible = false;
            // 
            // lbl_FechaIni
            // 
            this.lbl_FechaIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FechaIni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaIni.Location = new System.Drawing.Point(317, 157);
            this.lbl_FechaIni.Name = "lbl_FechaIni";
            this.lbl_FechaIni.Size = new System.Drawing.Size(112, 17);
            this.lbl_FechaIni.TabIndex = 1;
            this.lbl_FechaIni.Text = "...";
            this.lbl_FechaIni.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fecha de Generación";
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ubicacion.Location = new System.Drawing.Point(6, 157);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(17, 17);
            this.lbl_Ubicacion.TabIndex = 3;
            this.lbl_Ubicacion.Text = "...";
            // 
            // lbl_usuGenera
            // 
            this.lbl_usuGenera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuGenera.AutoSize = true;
            this.lbl_usuGenera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuGenera.Location = new System.Drawing.Point(67, 157);
            this.lbl_usuGenera.Name = "lbl_usuGenera";
            this.lbl_usuGenera.Size = new System.Drawing.Size(17, 17);
            this.lbl_usuGenera.TabIndex = 3;
            this.lbl_usuGenera.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ubicación";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Usuario Asignado";
            // 
            // lbl_TipoSolicitud
            // 
            this.lbl_TipoSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TipoSolicitud.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoSolicitud.Location = new System.Drawing.Point(157, 39);
            this.lbl_TipoSolicitud.Name = "lbl_TipoSolicitud";
            this.lbl_TipoSolicitud.Size = new System.Drawing.Size(272, 17);
            this.lbl_TipoSolicitud.TabIndex = 0;
            this.lbl_TipoSolicitud.Text = "...";
            this.lbl_TipoSolicitud.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Solicitud";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(6, 96);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(423, 44);
            this.lbl_Descripcion.TabIndex = 0;
            this.lbl_Descripcion.Text = "...";
            // 
            // lbl_Equipo
            // 
            this.lbl_Equipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipo.Location = new System.Drawing.Point(6, 39);
            this.lbl_Equipo.Name = "lbl_Equipo";
            this.lbl_Equipo.Size = new System.Drawing.Size(372, 40);
            this.lbl_Equipo.TabIndex = 0;
            this.lbl_Equipo.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equipo";
            // 
            // pnl_Botones
            // 
            this.pnl_Botones.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Botones.Controls.Add(this.Btn_Asignar);
            this.pnl_Botones.Controls.Add(this.Btn_Procesar);
            this.pnl_Botones.Controls.Add(this.Btn_Aplazar);
            this.pnl_Botones.Controls.Add(this.Btn_Finalizar);
            this.pnl_Botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Botones.Enabled = false;
            this.pnl_Botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_Botones.Name = "pnl_Botones";
            this.pnl_Botones.Size = new System.Drawing.Size(450, 34);
            this.pnl_Botones.TabIndex = 1;
            // 
            // Btn_Asignar
            // 
            this.Btn_Asignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Asignar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Asignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asignar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asignar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Asignar.Image")));
            this.Btn_Asignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Asignar.Location = new System.Drawing.Point(71, 3);
            this.Btn_Asignar.Name = "Btn_Asignar";
            this.Btn_Asignar.Size = new System.Drawing.Size(93, 28);
            this.Btn_Asignar.TabIndex = 0;
            this.Btn_Asignar.Text = "Asignar";
            this.Btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Asignar.UseVisualStyleBackColor = false;
            this.Btn_Asignar.Click += new System.EventHandler(this.Btn_Asignar_Click);
            // 
            // Btn_Procesar
            // 
            this.Btn_Procesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Procesar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Procesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Procesar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Procesar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Procesar.Image")));
            this.Btn_Procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Procesar.Location = new System.Drawing.Point(259, 3);
            this.Btn_Procesar.Name = "Btn_Procesar";
            this.Btn_Procesar.Size = new System.Drawing.Size(93, 28);
            this.Btn_Procesar.TabIndex = 0;
            this.Btn_Procesar.Text = "Procesar";
            this.Btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Procesar.UseVisualStyleBackColor = false;
            this.Btn_Procesar.Click += new System.EventHandler(this.Btn_Procesar_Click);
            // 
            // Btn_Aplazar
            // 
            this.Btn_Aplazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aplazar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Aplazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Aplazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aplazar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aplazar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aplazar.Image")));
            this.Btn_Aplazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aplazar.Location = new System.Drawing.Point(165, 3);
            this.Btn_Aplazar.Name = "Btn_Aplazar";
            this.Btn_Aplazar.Size = new System.Drawing.Size(93, 28);
            this.Btn_Aplazar.TabIndex = 0;
            this.Btn_Aplazar.Text = "Aplazar";
            this.Btn_Aplazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aplazar.UseVisualStyleBackColor = false;
            this.Btn_Aplazar.Click += new System.EventHandler(this.Btn_Aplazar_Click);
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Finalizar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Finalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Finalizar.Image")));
            this.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Finalizar.Location = new System.Drawing.Point(353, 3);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(93, 28);
            this.Btn_Finalizar.TabIndex = 0;
            this.Btn_Finalizar.Text = "Finalizar";
            this.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Finalizar.UseVisualStyleBackColor = false;
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // pnl_msg
            // 
            this.pnl_msg.BackColor = System.Drawing.Color.Transparent;
            this.pnl_msg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_msg.BackgroundImage")));
            this.pnl_msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_msg.Controls.Add(this.button1);
            this.pnl_msg.Location = new System.Drawing.Point(295, 39);
            this.pnl_msg.Name = "pnl_msg";
            this.pnl_msg.Size = new System.Drawing.Size(93, 29);
            this.pnl_msg.TabIndex = 2;
            this.pnl_msg.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 480);
            this.Controls.Add(this.pnl_msg);
            this.Controls.Add(this.spc_Contenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Soporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Resize += new System.EventHandler(this.Frm_Principal_Resize);
            this.spc_Contenedor.Panel1.ResumeLayout(false);
            this.spc_Contenedor.Panel1.PerformLayout();
            this.spc_Contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Contenedor)).EndInit();
            this.spc_Contenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.spc_Interno.Panel1.ResumeLayout(false);
            this.spc_Interno.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Interno)).EndInit();
            this.spc_Interno.ResumeLayout(false);
            this.pnl_usuario.ResumeLayout(false);
            this.pnl_usuario.PerformLayout();
            this.gbx_Detalles.ResumeLayout(false);
            this.gbx_Detalles.PerformLayout();
            this.pnl_Botones.ResumeLayout(false);
            this.pnl_msg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_Contenedor;
        private System.Windows.Forms.SplitContainer spc_Interno;
        private ControlInfo.ControlPanel controlPanel1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Config;
        private System.Windows.Forms.Button btn_Solicitud;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFin;
        private System.Windows.Forms.DateTimePicker Dtp_FechaIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.Button Btn_Aplazar;
        private System.Windows.Forms.Button Btn_Procesar;
        private System.Windows.Forms.Button Btn_Asignar;
        private System.Windows.Forms.Panel pnl_Botones;
        private System.Windows.Forms.GroupBox gbx_Detalles;
        private System.Windows.Forms.Label lbl_FechaIni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_usuGenera;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_TipoSolicitud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Equipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Pnl_Historias;
        private System.Windows.Forms.Button Btn_Equipos;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private System.Windows.Forms.Panel pnl_msg;
        private System.Windows.Forms.Button button1;
    }
}