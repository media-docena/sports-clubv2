﻿namespace clubdeportivoV2
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
            this.btnCarnet = new System.Windows.Forms.Button();
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
            this.btnRegistrarPagoS.Location = new System.Drawing.Point(510, 465);
            this.btnRegistrarPagoS.Name = "btnRegistrarPagoS";
            this.btnRegistrarPagoS.Size = new System.Drawing.Size(157, 63);
            this.btnRegistrarPagoS.TabIndex = 6;
            this.btnRegistrarPagoS.Text = "REGISTRAR PAGO";
            this.btnRegistrarPagoS.UseVisualStyleBackColor = false;
            // 
            // lblFormaPagoS
            // 
            this.lblFormaPagoS.AutoSize = true;
            this.lblFormaPagoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagoS.Location = new System.Drawing.Point(327, 209);
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
            this.lblAsterisco8.Location = new System.Drawing.Point(874, 215);
            this.lblAsterisco8.Name = "lblAsterisco8";
            this.lblAsterisco8.Size = new System.Drawing.Size(19, 22);
            this.lblAsterisco8.TabIndex = 21;
            this.lblAsterisco8.Text = "*";
            // 
            // lblMontoAbonoS
            // 
            this.lblMontoAbonoS.AutoSize = true;
            this.lblMontoAbonoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonoS.Location = new System.Drawing.Point(327, 290);
            this.lblMontoAbonoS.Name = "lblMontoAbonoS";
            this.lblMontoAbonoS.Size = new System.Drawing.Size(72, 28);
            this.lblMontoAbonoS.TabIndex = 23;
            this.lblMontoAbonoS.Text = "Monto";
            // 
            // cboFormaPagoS
            // 
            this.cboFormaPagoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPagoS.FormattingEnabled = true;
            this.cboFormaPagoS.Location = new System.Drawing.Point(510, 207);
            this.cboFormaPagoS.Name = "cboFormaPagoS";
            this.cboFormaPagoS.Size = new System.Drawing.Size(316, 36);
            this.cboFormaPagoS.TabIndex = 24;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(513, 292);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(313, 34);
            this.txtMonto.TabIndex = 25;
            this.txtMonto.Text = " 00.00";
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
            this.btnVolverAbonoS.Size = new System.Drawing.Size(242, 63);
            this.btnVolverAbonoS.TabIndex = 26;
            this.btnVolverAbonoS.Text = "VOLVER";
            this.btnVolverAbonoS.UseVisualStyleBackColor = false;
            // 
            // btnCarnet
            // 
            this.btnCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnCarnet.FlatAppearance.BorderSize = 0;
            this.btnCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarnet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCarnet.Location = new System.Drawing.Point(736, 465);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(157, 63);
            this.btnCarnet.TabIndex = 27;
            this.btnCarnet.Text = "GENERAR CARNET";
            this.btnCarnet.UseVisualStyleBackColor = false;
            // 
            // frmAbonoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 751);
            this.Controls.Add(this.btnCarnet);
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
        private System.Windows.Forms.Button btnCarnet;
    }
}