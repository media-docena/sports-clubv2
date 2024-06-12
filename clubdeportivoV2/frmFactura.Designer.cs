namespace clubdeportivoV2
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.pnlFtop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnVolverRegC = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlCentro1 = new System.Windows.Forms.Panel();
            this.lblFVenc = new System.Windows.Forms.Label();
            this.lblFV = new System.Windows.Forms.Label();
            this.lblTelClub = new System.Windows.Forms.Label();
            this.lblCorreoClub = new System.Windows.Forms.Label();
            this.lblFechaF = new System.Windows.Forms.Label();
            this.lblFechaCuota = new System.Windows.Forms.Label();
            this.lblClienteIdF = new System.Windows.Forms.Label();
            this.lblClienteid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCentro2 = new System.Windows.Forms.Panel();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblConceptoF = new System.Windows.Forms.Label();
            this.lblNomCompleto = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecibi = new System.Windows.Forms.Label();
            this.printFactura = new System.Drawing.Printing.PrintDocument();
            this.lblFP = new System.Windows.Forms.Label();
            this.lblFormaP = new System.Windows.Forms.Label();
            this.pnlFtop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCentro1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCentro2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFtop
            // 
            this.pnlFtop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(248)))), ((int)(((byte)(222)))));
            this.pnlFtop.Controls.Add(this.lblTitulo);
            this.pnlFtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFtop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFtop.ForeColor = System.Drawing.Color.White;
            this.pnlFtop.Location = new System.Drawing.Point(0, 0);
            this.pnlFtop.Name = "pnlFtop";
            this.pnlFtop.Size = new System.Drawing.Size(718, 104);
            this.pnlFtop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(50, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(594, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMPROBANTE DE PAGO";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnVolverRegC);
            this.pnlBottom.Controls.Add(this.btnImprimir);
            this.pnlBottom.Controls.Add(this.lblTotal);
            this.pnlBottom.Controls.Add(this.lblTotalF);
            this.pnlBottom.Controls.Add(this.lblMoneda);
            this.pnlBottom.Controls.Add(this.lblCurrency);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 557);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(718, 130);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnVolverRegC
            // 
            this.btnVolverRegC.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverRegC.FlatAppearance.BorderSize = 0;
            this.btnVolverRegC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverRegC.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverRegC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverRegC.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverRegC.Image")));
            this.btnVolverRegC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverRegC.Location = new System.Drawing.Point(6, 76);
            this.btnVolverRegC.Name = "btnVolverRegC";
            this.btnVolverRegC.Size = new System.Drawing.Size(212, 43);
            this.btnVolverRegC.TabIndex = 22;
            this.btnVolverRegC.Text = "VOLVER";
            this.btnVolverRegC.UseVisualStyleBackColor = false;
            this.btnVolverRegC.Click += new System.EventHandler(this.btnVolverRegC_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(21, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(143, 46);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(497, 67);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "18000";
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.BackColor = System.Drawing.Color.White;
            this.lblTotalF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalF.Location = new System.Drawing.Point(412, 67);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(70, 25);
            this.lblTotalF.TabIndex = 17;
            this.lblTotalF.Text = "Total:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.White;
            this.lblMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoneda.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.Tomato;
            this.lblMoneda.Location = new System.Drawing.Point(497, 24);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(179, 25);
            this.lblMoneda.TabIndex = 16;
            this.lblMoneda.Text = "Pesos argentinos";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.BackColor = System.Drawing.Color.White;
            this.lblCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(395, 24);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(96, 25);
            this.lblCurrency.TabIndex = 15;
            this.lblCurrency.Text = "Moneda";
            // 
            // pnlCentro1
            // 
            this.pnlCentro1.BackColor = System.Drawing.Color.White;
            this.pnlCentro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro1.Controls.Add(this.lblFormaP);
            this.pnlCentro1.Controls.Add(this.lblFP);
            this.pnlCentro1.Controls.Add(this.lblFVenc);
            this.pnlCentro1.Controls.Add(this.lblFV);
            this.pnlCentro1.Controls.Add(this.lblTelClub);
            this.pnlCentro1.Controls.Add(this.lblCorreoClub);
            this.pnlCentro1.Controls.Add(this.lblFechaF);
            this.pnlCentro1.Controls.Add(this.lblFechaCuota);
            this.pnlCentro1.Controls.Add(this.lblClienteIdF);
            this.pnlCentro1.Controls.Add(this.lblClienteid);
            this.pnlCentro1.Controls.Add(this.pictureBox1);
            this.pnlCentro1.Location = new System.Drawing.Point(0, 110);
            this.pnlCentro1.Name = "pnlCentro1";
            this.pnlCentro1.Size = new System.Drawing.Size(718, 242);
            this.pnlCentro1.TabIndex = 2;
            // 
            // lblFVenc
            // 
            this.lblFVenc.AutoSize = true;
            this.lblFVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFVenc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVenc.Location = new System.Drawing.Point(504, 94);
            this.lblFVenc.Name = "lblFVenc";
            this.lblFVenc.Size = new System.Drawing.Size(120, 25);
            this.lblFVenc.TabIndex = 10;
            this.lblFVenc.Text = "12/07/2024";
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFV.Location = new System.Drawing.Point(287, 94);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(202, 25);
            this.lblFV.TabIndex = 9;
            this.lblFV.Text = "Fecha Vencimiento";
            // 
            // lblTelClub
            // 
            this.lblTelClub.AutoSize = true;
            this.lblTelClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelClub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelClub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelClub.Location = new System.Drawing.Point(22, 194);
            this.lblTelClub.Name = "lblTelClub";
            this.lblTelClub.Size = new System.Drawing.Size(147, 25);
            this.lblTelClub.TabIndex = 8;
            this.lblTelClub.Text = "011-256-5261";
            // 
            // lblCorreoClub
            // 
            this.lblCorreoClub.AutoSize = true;
            this.lblCorreoClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCorreoClub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoClub.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCorreoClub.Location = new System.Drawing.Point(22, 161);
            this.lblCorreoClub.Name = "lblCorreoClub";
            this.lblCorreoClub.Size = new System.Drawing.Size(222, 25);
            this.lblCorreoClub.TabIndex = 7;
            this.lblCorreoClub.Text = "info@sportsclub.com";
            // 
            // lblFechaF
            // 
            this.lblFechaF.AutoSize = true;
            this.lblFechaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaF.Location = new System.Drawing.Point(504, 57);
            this.lblFechaF.Name = "lblFechaF";
            this.lblFechaF.Size = new System.Drawing.Size(120, 25);
            this.lblFechaF.TabIndex = 6;
            this.lblFechaF.Text = "12/06/2024";
            // 
            // lblFechaCuota
            // 
            this.lblFechaCuota.AutoSize = true;
            this.lblFechaCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaCuota.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCuota.Location = new System.Drawing.Point(415, 57);
            this.lblFechaCuota.Name = "lblFechaCuota";
            this.lblFechaCuota.Size = new System.Drawing.Size(74, 25);
            this.lblFechaCuota.TabIndex = 5;
            this.lblFechaCuota.Text = "Fecha";
            // 
            // lblClienteIdF
            // 
            this.lblClienteIdF.AutoSize = true;
            this.lblClienteIdF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteIdF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteIdF.Location = new System.Drawing.Point(504, 21);
            this.lblClienteIdF.Name = "lblClienteIdF";
            this.lblClienteIdF.Size = new System.Drawing.Size(48, 25);
            this.lblClienteIdF.TabIndex = 2;
            this.lblClienteIdF.Text = "562";
            // 
            // lblClienteid
            // 
            this.lblClienteid.AutoSize = true;
            this.lblClienteid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteid.Location = new System.Drawing.Point(375, 21);
            this.lblClienteid.Name = "lblClienteid";
            this.lblClienteid.Size = new System.Drawing.Size(114, 25);
            this.lblClienteid.TabIndex = 1;
            this.lblClienteid.Text = "ID Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCentro2
            // 
            this.pnlCentro2.BackColor = System.Drawing.Color.White;
            this.pnlCentro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro2.Controls.Add(this.lblConcepto);
            this.pnlCentro2.Controls.Add(this.lblConceptoF);
            this.pnlCentro2.Controls.Add(this.lblNomCompleto);
            this.pnlCentro2.Controls.Add(this.lblSuma);
            this.pnlCentro2.Controls.Add(this.label1);
            this.pnlCentro2.Controls.Add(this.lblRecibi);
            this.pnlCentro2.Location = new System.Drawing.Point(0, 358);
            this.pnlCentro2.Name = "pnlCentro2";
            this.pnlCentro2.Size = new System.Drawing.Size(718, 193);
            this.pnlCentro2.TabIndex = 3;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.lblConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConcepto.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(22, 126);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(246, 25);
            this.lblConcepto.TabIndex = 14;
            this.lblConcepto.Text = "POR CONCEPTO DE:";
            // 
            // lblConceptoF
            // 
            this.lblConceptoF.AutoSize = true;
            this.lblConceptoF.BackColor = System.Drawing.Color.White;
            this.lblConceptoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConceptoF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoF.Location = new System.Drawing.Point(293, 126);
            this.lblConceptoF.Name = "lblConceptoF";
            this.lblConceptoF.Size = new System.Drawing.Size(258, 25);
            this.lblConceptoF.TabIndex = 13;
            this.lblConceptoF.Text = "Abono mensual de cuota";
            // 
            // lblNomCompleto
            // 
            this.lblNomCompleto.AutoSize = true;
            this.lblNomCompleto.BackColor = System.Drawing.Color.White;
            this.lblNomCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomCompleto.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCompleto.Location = new System.Drawing.Point(206, 32);
            this.lblNomCompleto.Name = "lblNomCompleto";
            this.lblNomCompleto.Size = new System.Drawing.Size(172, 25);
            this.lblNomCompleto.TabIndex = 12;
            this.lblNomCompleto.Text = "Ignacio Santoro";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.BackColor = System.Drawing.Color.White;
            this.lblSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(204, 79);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(292, 25);
            this.lblSuma.TabIndex = 11;
            this.lblSuma.Text = "Dieciocho pesos con 50 ctvs.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "LA SUMA DE:";
            // 
            // lblRecibi
            // 
            this.lblRecibi.AutoSize = true;
            this.lblRecibi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.lblRecibi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecibi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibi.Location = new System.Drawing.Point(22, 32);
            this.lblRecibi.Name = "lblRecibi";
            this.lblRecibi.Size = new System.Drawing.Size(141, 25);
            this.lblRecibi.TabIndex = 9;
            this.lblRecibi.Text = "RECIBI DE:";
            // 
            // printFactura
            // 
            this.printFactura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printFactura_PrintPage);
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFP.Location = new System.Drawing.Point(322, 132);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(167, 25);
            this.lblFP.TabIndex = 11;
            this.lblFP.Text = "Forma de Pago";
            // 
            // lblFormaP
            // 
            this.lblFormaP.AutoSize = true;
            this.lblFormaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormaP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaP.Location = new System.Drawing.Point(504, 132);
            this.lblFormaP.Name = "lblFormaP";
            this.lblFormaP.Size = new System.Drawing.Size(190, 25);
            this.lblFormaP.TabIndex = 12;
            this.lblFormaP.Text = "Tarjeta de crédito";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 687);
            this.Controls.Add(this.pnlCentro2);
            this.Controls.Add(this.pnlCentro1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlFtop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA FACTURA";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlFtop.ResumeLayout(false);
            this.pnlFtop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlCentro1.ResumeLayout(false);
            this.pnlCentro1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCentro2.ResumeLayout(false);
            this.pnlCentro2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFtop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCentro1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClienteid;
        private System.Windows.Forms.Label lblClienteIdF;
        private System.Windows.Forms.Label lblFechaCuota;
        private System.Windows.Forms.Label lblFechaF;
        private System.Windows.Forms.Label lblCorreoClub;
        private System.Windows.Forms.Label lblTelClub;
        private System.Windows.Forms.Label lblFV;
        private System.Windows.Forms.Label lblFVenc;
        private System.Windows.Forms.Panel pnlCentro2;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblConceptoF;
        private System.Windows.Forms.Label lblNomCompleto;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecibi;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblTotalF;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVolverRegC;
        private System.Drawing.Printing.PrintDocument printFactura;
        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.Label lblFormaP;
    }
}