namespace clubdeportivoV2
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.picRegC = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblRegC = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.txtTelC = new System.Windows.Forms.TextBox();
            this.txtCorreoC = new System.Windows.Forms.TextBox();
            this.txtDNIC = new System.Windows.Forms.TextBox();
            this.cboTipoC = new System.Windows.Forms.ComboBox();
            this.lblAsterisco1 = new System.Windows.Forms.Label();
            this.lblAsterisco2 = new System.Windows.Forms.Label();
            this.lblAsterisco3 = new System.Windows.Forms.Label();
            this.lblAsterisco4 = new System.Windows.Forms.Label();
            this.lblAsterisco5 = new System.Windows.Forms.Label();
            this.lblAsterisco6 = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblApellidoC = new System.Windows.Forms.Label();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblCorreoC = new System.Windows.Forms.Label();
            this.lblTipoC = new System.Windows.Forms.Label();
            this.btnVolverRegC = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRegC)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegC
            // 
            this.picRegC.Image = ((System.Drawing.Image)(resources.GetObject("picRegC.Image")));
            this.picRegC.Location = new System.Drawing.Point(-1, -1);
            this.picRegC.Name = "picRegC";
            this.picRegC.Size = new System.Drawing.Size(391, 739);
            this.picRegC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegC.TabIndex = 0;
            this.picRegC.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(496, 541);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 63);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(780, 541);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(157, 63);
            this.btnRegistrarCliente.TabIndex = 2;
            this.btnRegistrarCliente.Text = "REGISTRAR";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lblRegC
            // 
            this.lblRegC.AutoSize = true;
            this.lblRegC.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblRegC.Location = new System.Drawing.Point(667, 52);
            this.lblRegC.Name = "lblRegC";
            this.lblRegC.Size = new System.Drawing.Size(357, 32);
            this.lblRegC.TabIndex = 3;
            this.lblRegC.Text = "REGISTRO DE CLIENTE";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreC.Location = new System.Drawing.Point(610, 129);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(371, 30);
            this.txtNombreC.TabIndex = 4;
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoC.Location = new System.Drawing.Point(610, 201);
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(371, 30);
            this.txtApellidoC.TabIndex = 5;
            // 
            // txtTelC
            // 
            this.txtTelC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelC.Location = new System.Drawing.Point(610, 273);
            this.txtTelC.Name = "txtTelC";
            this.txtTelC.Size = new System.Drawing.Size(371, 30);
            this.txtTelC.TabIndex = 6;
            // 
            // txtCorreoC
            // 
            this.txtCorreoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoC.Location = new System.Drawing.Point(610, 347);
            this.txtCorreoC.Name = "txtCorreoC";
            this.txtCorreoC.Size = new System.Drawing.Size(371, 30);
            this.txtCorreoC.TabIndex = 7;
            // 
            // txtDNIC
            // 
            this.txtDNIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIC.Location = new System.Drawing.Point(939, 429);
            this.txtDNIC.Name = "txtDNIC";
            this.txtDNIC.Size = new System.Drawing.Size(238, 30);
            this.txtDNIC.TabIndex = 8;
            // 
            // cboTipoC
            // 
            this.cboTipoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoC.FormattingEnabled = true;
            this.cboTipoC.Location = new System.Drawing.Point(610, 429);
            this.cboTipoC.Name = "cboTipoC";
            this.cboTipoC.Size = new System.Drawing.Size(177, 30);
            this.cboTipoC.TabIndex = 9;
            // 
            // lblAsterisco1
            // 
            this.lblAsterisco1.AutoSize = true;
            this.lblAsterisco1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco1.Location = new System.Drawing.Point(1005, 132);
            this.lblAsterisco1.Name = "lblAsterisco1";
            this.lblAsterisco1.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco1.TabIndex = 10;
            this.lblAsterisco1.Text = "*";
            // 
            // lblAsterisco2
            // 
            this.lblAsterisco2.AutoSize = true;
            this.lblAsterisco2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco2.Location = new System.Drawing.Point(1005, 209);
            this.lblAsterisco2.Name = "lblAsterisco2";
            this.lblAsterisco2.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco2.TabIndex = 11;
            this.lblAsterisco2.Text = "*";
            // 
            // lblAsterisco3
            // 
            this.lblAsterisco3.AutoSize = true;
            this.lblAsterisco3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco3.Location = new System.Drawing.Point(1005, 281);
            this.lblAsterisco3.Name = "lblAsterisco3";
            this.lblAsterisco3.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco3.TabIndex = 12;
            this.lblAsterisco3.Text = "*";
            // 
            // lblAsterisco4
            // 
            this.lblAsterisco4.AutoSize = true;
            this.lblAsterisco4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco4.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco4.Location = new System.Drawing.Point(1005, 355);
            this.lblAsterisco4.Name = "lblAsterisco4";
            this.lblAsterisco4.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco4.TabIndex = 13;
            this.lblAsterisco4.Text = "*";
            // 
            // lblAsterisco5
            // 
            this.lblAsterisco5.AutoSize = true;
            this.lblAsterisco5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco5.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco5.Location = new System.Drawing.Point(814, 437);
            this.lblAsterisco5.Name = "lblAsterisco5";
            this.lblAsterisco5.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco5.TabIndex = 14;
            this.lblAsterisco5.Text = "*";
            // 
            // lblAsterisco6
            // 
            this.lblAsterisco6.AutoSize = true;
            this.lblAsterisco6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco6.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco6.Location = new System.Drawing.Point(1204, 437);
            this.lblAsterisco6.Name = "lblAsterisco6";
            this.lblAsterisco6.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco6.TabIndex = 15;
            this.lblAsterisco6.Text = "*";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(487, 132);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(74, 22);
            this.lblNombreC.TabIndex = 16;
            this.lblNombreC.Text = "Nombre";
            // 
            // lblApellidoC
            // 
            this.lblApellidoC.AutoSize = true;
            this.lblApellidoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoC.Location = new System.Drawing.Point(487, 204);
            this.lblApellidoC.Name = "lblApellidoC";
            this.lblApellidoC.Size = new System.Drawing.Size(81, 22);
            this.lblApellidoC.TabIndex = 17;
            this.lblApellidoC.Text = "Apellido";
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelC.Location = new System.Drawing.Point(488, 276);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(80, 22);
            this.lblTelC.TabIndex = 18;
            this.lblTelC.Text = "Teléfono";
            // 
            // lblCorreoC
            // 
            this.lblCorreoC.AutoSize = true;
            this.lblCorreoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoC.Location = new System.Drawing.Point(495, 350);
            this.lblCorreoC.Name = "lblCorreoC";
            this.lblCorreoC.Size = new System.Drawing.Size(66, 22);
            this.lblCorreoC.TabIndex = 19;
            this.lblCorreoC.Text = "Correo";
            // 
            // lblTipoC
            // 
            this.lblTipoC.AutoSize = true;
            this.lblTipoC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoC.Location = new System.Drawing.Point(488, 432);
            this.lblTipoC.Name = "lblTipoC";
            this.lblTipoC.Size = new System.Drawing.Size(105, 22);
            this.lblTipoC.TabIndex = 20;
            this.lblTipoC.Text = "Tipo cliente";
            // 
            // btnVolverRegC
            // 
            this.btnVolverRegC.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverRegC.FlatAppearance.BorderSize = 0;
            this.btnVolverRegC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverRegC.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverRegC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverRegC.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverRegC.Image")));
            this.btnVolverRegC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverRegC.Location = new System.Drawing.Point(1009, 541);
            this.btnVolverRegC.Name = "btnVolverRegC";
            this.btnVolverRegC.Size = new System.Drawing.Size(242, 63);
            this.btnVolverRegC.TabIndex = 21;
            this.btnVolverRegC.Text = "VOLVER";
            this.btnVolverRegC.UseVisualStyleBackColor = false;
            this.btnVolverRegC.Click += new System.EventHandler(this.btnVolverRegC_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(880, 433);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(44, 22);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 692);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnVolverRegC);
            this.Controls.Add(this.lblTipoC);
            this.Controls.Add(this.lblCorreoC);
            this.Controls.Add(this.lblTelC);
            this.Controls.Add(this.lblApellidoC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblAsterisco6);
            this.Controls.Add(this.lblAsterisco5);
            this.Controls.Add(this.lblAsterisco4);
            this.Controls.Add(this.lblAsterisco3);
            this.Controls.Add(this.lblAsterisco2);
            this.Controls.Add(this.lblAsterisco1);
            this.Controls.Add(this.cboTipoC);
            this.Controls.Add(this.txtDNIC);
            this.Controls.Add(this.txtCorreoC);
            this.Controls.Add(this.txtTelC);
            this.Controls.Add(this.txtApellidoC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblRegC);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.picRegC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.picRegC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegC;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblRegC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.TextBox txtTelC;
        private System.Windows.Forms.TextBox txtCorreoC;
        private System.Windows.Forms.TextBox txtDNIC;
        private System.Windows.Forms.ComboBox cboTipoC;
        private System.Windows.Forms.Label lblAsterisco1;
        private System.Windows.Forms.Label lblAsterisco2;
        private System.Windows.Forms.Label lblAsterisco3;
        private System.Windows.Forms.Label lblAsterisco4;
        private System.Windows.Forms.Label lblAsterisco5;
        private System.Windows.Forms.Label lblAsterisco6;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblApellidoC;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblCorreoC;
        private System.Windows.Forms.Label lblTipoC;
        private System.Windows.Forms.Button btnVolverRegC;
        private System.Windows.Forms.Label lblDNI;
    }
}