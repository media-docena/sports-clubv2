namespace clubdeportivoV2
{
    partial class frmAbonoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonoSocio));
            this.lblAbonarCuotaSocio = new System.Windows.Forms.Label();
            this.btnRegistrarPagoS = new System.Windows.Forms.Button();
            this.lblFormaPagoS = new System.Windows.Forms.Label();
            this.lblAsterisco8 = new System.Windows.Forms.Label();
            this.lblMontoAbonoS = new System.Windows.Forms.Label();
            this.cboFormaPagoS = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnVolverAbonoS = new System.Windows.Forms.Button();
            this.btnCarnetS = new System.Windows.Forms.Button();
            this.btnMenuPS = new System.Windows.Forms.Button();
            this.grpTarjetaS = new System.Windows.Forms.GroupBox();
            this.lblPromo6S = new System.Windows.Forms.Label();
            this.lblPromo3S = new System.Windows.Forms.Label();
            this.rdoCuota6 = new System.Windows.Forms.RadioButton();
            this.rdoCuota3 = new System.Windows.Forms.RadioButton();
            this.rdoCuota1 = new System.Windows.Forms.RadioButton();
            this.lblCreditoCuotaS = new System.Windows.Forms.Label();
            this.btnComprobanteS = new System.Windows.Forms.Button();
            this.grpTarjetaS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbonarCuotaSocio
            // 
            this.lblAbonarCuotaSocio.AutoSize = true;
            this.lblAbonarCuotaSocio.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonarCuotaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblAbonarCuotaSocio.Location = new System.Drawing.Point(518, 67);
            this.lblAbonarCuotaSocio.Name = "lblAbonarCuotaSocio";
            this.lblAbonarCuotaSocio.Size = new System.Drawing.Size(262, 32);
            this.lblAbonarCuotaSocio.TabIndex = 5;
            this.lblAbonarCuotaSocio.Text = "ABONAR CUOTA";
            // 
            // btnRegistrarPagoS
            // 
            this.btnRegistrarPagoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnRegistrarPagoS.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPagoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPagoS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPagoS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarPagoS.Location = new System.Drawing.Point(476, 465);
            this.btnRegistrarPagoS.Name = "btnRegistrarPagoS";
            this.btnRegistrarPagoS.Size = new System.Drawing.Size(157, 63);
            this.btnRegistrarPagoS.TabIndex = 6;
            this.btnRegistrarPagoS.Text = "REGISTRAR PAGO";
            this.btnRegistrarPagoS.UseVisualStyleBackColor = false;
            this.btnRegistrarPagoS.Click += new System.EventHandler(this.btnRegistrarPagoS_Click);
            // 
            // lblFormaPagoS
            // 
            this.lblFormaPagoS.AutoSize = true;
            this.lblFormaPagoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagoS.Location = new System.Drawing.Point(293, 209);
            this.lblFormaPagoS.Name = "lblFormaPagoS";
            this.lblFormaPagoS.Size = new System.Drawing.Size(144, 28);
            this.lblFormaPagoS.TabIndex = 22;
            this.lblFormaPagoS.Text = "Forma de Pago";
            // 
            // lblAsterisco8
            // 
            this.lblAsterisco8.AutoSize = true;
            this.lblAsterisco8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco8.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco8.Location = new System.Drawing.Point(818, 215);
            this.lblAsterisco8.Name = "lblAsterisco8";
            this.lblAsterisco8.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco8.TabIndex = 21;
            this.lblAsterisco8.Text = "*";
            // 
            // lblMontoAbonoS
            // 
            this.lblMontoAbonoS.AutoSize = true;
            this.lblMontoAbonoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonoS.Location = new System.Drawing.Point(293, 290);
            this.lblMontoAbonoS.Name = "lblMontoAbonoS";
            this.lblMontoAbonoS.Size = new System.Drawing.Size(72, 28);
            this.lblMontoAbonoS.TabIndex = 23;
            this.lblMontoAbonoS.Text = "Monto";
            // 
            // cboFormaPagoS
            // 
            this.cboFormaPagoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPagoS.FormattingEnabled = true;
            this.cboFormaPagoS.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito"});
            this.cboFormaPagoS.Location = new System.Drawing.Point(476, 207);
            this.cboFormaPagoS.Name = "cboFormaPagoS";
            this.cboFormaPagoS.Size = new System.Drawing.Size(316, 36);
            this.cboFormaPagoS.TabIndex = 24;
            this.cboFormaPagoS.SelectionChangeCommitted += new System.EventHandler(this.cboFormaPagoS_SelectionChangeCommitted);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.LightGray;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(479, 292);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(313, 34);
            this.txtMonto.TabIndex = 25;
            this.txtMonto.Text = " 18000";
            // 
            // btnVolverAbonoS
            // 
            this.btnVolverAbonoS.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverAbonoS.FlatAppearance.BorderSize = 0;
            this.btnVolverAbonoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAbonoS.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAbonoS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverAbonoS.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverAbonoS.Image")));
            this.btnVolverAbonoS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverAbonoS.Location = new System.Drawing.Point(41, 640);
            this.btnVolverAbonoS.Name = "btnVolverAbonoS";
            this.btnVolverAbonoS.Size = new System.Drawing.Size(267, 63);
            this.btnVolverAbonoS.TabIndex = 26;
            this.btnVolverAbonoS.Text = "VOLVER";
            this.btnVolverAbonoS.UseVisualStyleBackColor = false;
            this.btnVolverAbonoS.Click += new System.EventHandler(this.btnVolverAbonoS_Click);
            // 
            // btnCarnetS
            // 
            this.btnCarnetS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnCarnetS.FlatAppearance.BorderSize = 0;
            this.btnCarnetS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarnetS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarnetS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCarnetS.Location = new System.Drawing.Point(668, 465);
            this.btnCarnetS.Name = "btnCarnetS";
            this.btnCarnetS.Size = new System.Drawing.Size(157, 63);
            this.btnCarnetS.TabIndex = 27;
            this.btnCarnetS.Text = "GENERAR CARNET";
            this.btnCarnetS.UseVisualStyleBackColor = false;
            this.btnCarnetS.Visible = false;
            // 
            // btnMenuPS
            // 
            this.btnMenuPS.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuPS.FlatAppearance.BorderSize = 0;
            this.btnMenuPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPS.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnMenuPS.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPS.Image")));
            this.btnMenuPS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPS.Location = new System.Drawing.Point(961, 641);
            this.btnMenuPS.Name = "btnMenuPS";
            this.btnMenuPS.Size = new System.Drawing.Size(293, 63);
            this.btnMenuPS.TabIndex = 28;
            this.btnMenuPS.Text = "IR AL MENU";
            this.btnMenuPS.UseVisualStyleBackColor = false;
            this.btnMenuPS.Click += new System.EventHandler(this.btnMenuPS_Click);
            // 
            // grpTarjetaS
            // 
            this.grpTarjetaS.BackColor = System.Drawing.Color.White;
            this.grpTarjetaS.Controls.Add(this.lblPromo6S);
            this.grpTarjetaS.Controls.Add(this.lblPromo3S);
            this.grpTarjetaS.Controls.Add(this.rdoCuota6);
            this.grpTarjetaS.Controls.Add(this.rdoCuota3);
            this.grpTarjetaS.Controls.Add(this.rdoCuota1);
            this.grpTarjetaS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTarjetaS.Location = new System.Drawing.Point(889, 145);
            this.grpTarjetaS.Name = "grpTarjetaS";
            this.grpTarjetaS.Size = new System.Drawing.Size(340, 222);
            this.grpTarjetaS.TabIndex = 29;
            this.grpTarjetaS.TabStop = false;
            this.grpTarjetaS.Text = "Seleccione una opción";
            this.grpTarjetaS.Visible = false;
            // 
            // lblPromo6S
            // 
            this.lblPromo6S.AutoSize = true;
            this.lblPromo6S.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPromo6S.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo6S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblPromo6S.Location = new System.Drawing.Point(52, 157);
            this.lblPromo6S.Name = "lblPromo6S";
            this.lblPromo6S.Size = new System.Drawing.Size(253, 25);
            this.lblPromo6S.TabIndex = 4;
            this.lblPromo6S.Text = "10% OFF del total sin interés";
            // 
            // lblPromo3S
            // 
            this.lblPromo3S.AutoSize = true;
            this.lblPromo3S.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPromo3S.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo3S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblPromo3S.Location = new System.Drawing.Point(52, 99);
            this.lblPromo3S.Name = "lblPromo3S";
            this.lblPromo3S.Size = new System.Drawing.Size(243, 25);
            this.lblPromo3S.TabIndex = 3;
            this.lblPromo3S.Text = "5% OFF del total sin interés";
            // 
            // rdoCuota6
            // 
            this.rdoCuota6.AutoSize = true;
            this.rdoCuota6.Location = new System.Drawing.Point(22, 127);
            this.rdoCuota6.Name = "rdoCuota6";
            this.rdoCuota6.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota6.TabIndex = 2;
            this.rdoCuota6.TabStop = true;
            this.rdoCuota6.Text = "6 cuotas";
            this.rdoCuota6.UseVisualStyleBackColor = true;
            // 
            // rdoCuota3
            // 
            this.rdoCuota3.AutoSize = true;
            this.rdoCuota3.Location = new System.Drawing.Point(22, 69);
            this.rdoCuota3.Name = "rdoCuota3";
            this.rdoCuota3.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota3.TabIndex = 1;
            this.rdoCuota3.TabStop = true;
            this.rdoCuota3.Text = "3 cuotas";
            this.rdoCuota3.UseVisualStyleBackColor = true;
            // 
            // rdoCuota1
            // 
            this.rdoCuota1.AutoSize = true;
            this.rdoCuota1.Location = new System.Drawing.Point(22, 38);
            this.rdoCuota1.Name = "rdoCuota1";
            this.rdoCuota1.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota1.TabIndex = 0;
            this.rdoCuota1.TabStop = true;
            this.rdoCuota1.Text = "1 cuotas";
            this.rdoCuota1.UseVisualStyleBackColor = true;
            // 
            // lblCreditoCuotaS
            // 
            this.lblCreditoCuotaS.AutoSize = true;
            this.lblCreditoCuotaS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoCuotaS.ForeColor = System.Drawing.Color.Red;
            this.lblCreditoCuotaS.Location = new System.Drawing.Point(1235, 145);
            this.lblCreditoCuotaS.Name = "lblCreditoCuotaS";
            this.lblCreditoCuotaS.Size = new System.Drawing.Size(19, 22);
            this.lblCreditoCuotaS.TabIndex = 30;
            this.lblCreditoCuotaS.Text = "*";
            this.lblCreditoCuotaS.Visible = false;
            // 
            // btnComprobanteS
            // 
            this.btnComprobanteS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnComprobanteS.FlatAppearance.BorderSize = 0;
            this.btnComprobanteS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobanteS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobanteS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprobanteS.Location = new System.Drawing.Point(280, 465);
            this.btnComprobanteS.Name = "btnComprobanteS";
            this.btnComprobanteS.Size = new System.Drawing.Size(157, 63);
            this.btnComprobanteS.TabIndex = 31;
            this.btnComprobanteS.Text = "GENERAR COMPROBANTE";
            this.btnComprobanteS.UseVisualStyleBackColor = false;
            this.btnComprobanteS.Visible = false;
            // 
            // frmAbonoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 751);
            this.Controls.Add(this.btnComprobanteS);
            this.Controls.Add(this.lblCreditoCuotaS);
            this.Controls.Add(this.grpTarjetaS);
            this.Controls.Add(this.btnMenuPS);
            this.Controls.Add(this.btnCarnetS);
            this.Controls.Add(this.btnVolverAbonoS);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cboFormaPagoS);
            this.Controls.Add(this.lblMontoAbonoS);
            this.Controls.Add(this.lblFormaPagoS);
            this.Controls.Add(this.lblAsterisco8);
            this.Controls.Add(this.btnRegistrarPagoS);
            this.Controls.Add(this.lblAbonarCuotaSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA ABONO SOCIO";
            this.grpTarjetaS.ResumeLayout(false);
            this.grpTarjetaS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbonarCuotaSocio;
        private System.Windows.Forms.Button btnRegistrarPagoS;
        private System.Windows.Forms.Label lblFormaPagoS;
        private System.Windows.Forms.Label lblAsterisco8;
        private System.Windows.Forms.Label lblMontoAbonoS;
        private System.Windows.Forms.ComboBox cboFormaPagoS;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnVolverAbonoS;
        private System.Windows.Forms.Button btnCarnetS;
        private System.Windows.Forms.Button btnMenuPS;
        private System.Windows.Forms.GroupBox grpTarjetaS;
        private System.Windows.Forms.RadioButton rdoCuota1;
        private System.Windows.Forms.RadioButton rdoCuota3;
        private System.Windows.Forms.RadioButton rdoCuota6;
        private System.Windows.Forms.Label lblPromo3S;
        private System.Windows.Forms.Label lblPromo6S;
        private System.Windows.Forms.Label lblCreditoCuotaS;
        private System.Windows.Forms.Button btnComprobanteS;
    }
}