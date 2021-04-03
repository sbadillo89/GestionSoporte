namespace GestionSoporte.UI
{
    partial class Frm_Justificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Justificacion));
            this.txt_Justificacion = new System.Windows.Forms.TextBox();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Justificacion
            // 
            this.txt_Justificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Justificacion.Location = new System.Drawing.Point(3, 12);
            this.txt_Justificacion.Multiline = true;
            this.txt_Justificacion.Name = "txt_Justificacion";
            this.txt_Justificacion.Size = new System.Drawing.Size(366, 50);
            this.txt_Justificacion.TabIndex = 0;
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Continuar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continuar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Continuar.Image")));
            this.btn_Continuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Continuar.Location = new System.Drawing.Point(270, 65);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(99, 28);
            this.btn_Continuar.TabIndex = 16;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // Frm_Justificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(374, 96);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.txt_Justificacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Justificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Justificación - Dar de Baja";
            this.Load += new System.EventHandler(this.Frm_Justificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Justificacion;
        private System.Windows.Forms.Button btn_Continuar;
    }
}