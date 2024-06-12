namespace clubdeportivoV2
{
    partial class frmPreAbono
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreAbono));
            this.lblPreAbonar = new System.Windows.Forms.Label();
            this.btnConfirmarPreAbono = new System.Windows.Forms.Button();
            this.lblIdPreAbono = new System.Windows.Forms.Label();
            this.lblAsterisco7 = new System.Windows.Forms.Label();
            this.txtIdPreAbono = new System.Windows.Forms.TextBox();
            this.btnVolverPreAbono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPreAbonar
            // 
            this.lblPreAbonar.AutoSize = true;
            this.lblPreAbonar.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreAbonar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblPreAbonar.Location = new System.Drawing.Point(480, 65);
            this.lblPreAbonar.Name = "lblPreAbonar";
            this.lblPreAbonar.Size = new System.Drawing.Size(262, 32);
            this.lblPreAbonar.TabIndex = 4;
            this.lblPreAbonar.Text = "ABONAR CUOTA";
            // 
            // btnConfirmarPreAbono
            // 
            this.btnConfirmarPreAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnConfirmarPreAbono.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPreAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPreAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPreAbono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarPreAbono.Location = new System.Drawing.Point(536, 385);
            this.btnConfirmarPreAbono.Name = "btnConfirmarPreAbono";
            this.btnConfirmarPreAbono.Size = new System.Drawing.Size(157, 63);
            this.btnConfirmarPreAbono.TabIndex = 5;
            this.btnConfirmarPreAbono.Text = "CONFIRMAR";
            this.btnConfirmarPreAbono.UseVisualStyleBackColor = false;
            this.btnConfirmarPreAbono.Click += new System.EventHandler(this.btnConfirmarPreAbono_Click);
            // 
            // lblIdPreAbono
            // 
            this.lblIdPreAbono.AutoSize = true;
            this.lblIdPreAbono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPreAbono.Location = new System.Drawing.Point(271, 236);
            this.lblIdPreAbono.Name = "lblIdPreAbono";
            this.lblIdPreAbono.Size = new System.Drawing.Size(152, 28);
            this.lblIdPreAbono.TabIndex = 19;
            this.lblIdPreAbono.Text = "ID Cliente o DNI";
            // 
            // lblAsterisco7
            // 
            this.lblAsterisco7.AutoSize = true;
            this.lblAsterisco7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco7.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco7.Location = new System.Drawing.Point(841, 245);
            this.lblAsterisco7.Name = "lblAsterisco7";
            this.lblAsterisco7.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco7.TabIndex = 18;
            this.lblAsterisco7.Text = "*";
            // 
            // txtIdPreAbono
            // 
            this.txtIdPreAbono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPreAbono.Location = new System.Drawing.Point(446, 237);
            this.txtIdPreAbono.MaxLength = 9;
            this.txtIdPreAbono.Name = "txtIdPreAbono";
            this.txtIdPreAbono.Size = new System.Drawing.Size(371, 34);
            this.txtIdPreAbono.TabIndex = 17;
            // 
            // btnVolverPreAbono
            // 
            this.btnVolverPreAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverPreAbono.FlatAppearance.BorderSize = 0;
            this.btnVolverPreAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPreAbono.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPreAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverPreAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverPreAbono.Image")));
            this.btnVolverPreAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPreAbono.Location = new System.Drawing.Point(1010, 563);
            this.btnVolverPreAbono.Name = "btnVolverPreAbono";
            this.btnVolverPreAbono.Size = new System.Drawing.Size(242, 63);
            this.btnVolverPreAbono.TabIndex = 22;
            this.btnVolverPreAbono.Text = "VOLVER";
            this.btnVolverPreAbono.UseVisualStyleBackColor = false;
            this.btnVolverPreAbono.Click += new System.EventHandler(this.btnVolverPreAbono_Click);
            // 
            // frmPreAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 645);
            this.Controls.Add(this.btnVolverPreAbono);
            this.Controls.Add(this.lblIdPreAbono);
            this.Controls.Add(this.lblAsterisco7);
            this.Controls.Add(this.txtIdPreAbono);
            this.Controls.Add(this.btnConfirmarPreAbono);
            this.Controls.Add(this.lblPreAbonar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreAbono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA PREVIA A ABONO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreAbonar;
        private System.Windows.Forms.Button btnConfirmarPreAbono;
        private System.Windows.Forms.Label lblIdPreAbono;
        private System.Windows.Forms.Label lblAsterisco7;
        private System.Windows.Forms.TextBox txtIdPreAbono;
        private System.Windows.Forms.Button btnVolverPreAbono;
    }
}