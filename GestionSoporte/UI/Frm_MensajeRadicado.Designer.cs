namespace GestionSoporte.UI
{
    partial class Frm_MensajeRadicado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MensajeRadicado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Radicado = new System.Windows.Forms.Label();
            this.Btn_continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡ Solicitud generada correctamente !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radicado No.";
            // 
            // lbl_Radicado
            // 
            this.lbl_Radicado.AutoSize = true;
            this.lbl_Radicado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Radicado.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Radicado.Location = new System.Drawing.Point(163, 62);
            this.lbl_Radicado.Name = "lbl_Radicado";
            this.lbl_Radicado.Size = new System.Drawing.Size(56, 25);
            this.lbl_Radicado.TabIndex = 1;
            this.lbl_Radicado.Text = "####";
            // 
            // Btn_continuar
            // 
            this.Btn_continuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_continuar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_continuar.FlatAppearance.BorderSize = 0;
            this.Btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_continuar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_continuar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_continuar.Image")));
            this.Btn_continuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_continuar.Location = new System.Drawing.Point(265, 110);
            this.Btn_continuar.Name = "Btn_continuar";
            this.Btn_continuar.Size = new System.Drawing.Size(93, 28);
            this.Btn_continuar.TabIndex = 1;
            this.Btn_continuar.Text = "Continuar";
            this.Btn_continuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_continuar.UseVisualStyleBackColor = false;
            this.Btn_continuar.Click += new System.EventHandler(this.Btn_continuar_Click);
            // 
            // Frm_MensajeRadicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(365, 146);
            this.Controls.Add(this.Btn_continuar);
            this.Controls.Add(this.lbl_Radicado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MensajeRadicado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_MensajeRadicado";
            this.Load += new System.EventHandler(this.Frm_MensajeRadicado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Radicado;
        private System.Windows.Forms.Button Btn_continuar;
    }
}