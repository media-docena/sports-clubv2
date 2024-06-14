namespace clubdeportivoV2
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picCarnet = new System.Windows.Forms.PictureBox();
            this.lblNSocio = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblNomSocio = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.printCarnet = new System.Drawing.Printing.PrintDocument();
            this.btnImprimirCarnet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCarnet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(147)))), ((int)(((byte)(150)))));
            this.lblTitulo.Location = new System.Drawing.Point(333, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CARNET DE SOCIO";
            // 
            // picCarnet
            // 
            this.picCarnet.Image = ((System.Drawing.Image)(resources.GetObject("picCarnet.Image")));
            this.picCarnet.Location = new System.Drawing.Point(50, 36);
            this.picCarnet.Name = "picCarnet";
            this.picCarnet.Size = new System.Drawing.Size(219, 182);
            this.picCarnet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCarnet.TabIndex = 1;
            this.picCarnet.TabStop = false;
            // 
            // lblNSocio
            // 
            this.lblNSocio.AutoSize = true;
            this.lblNSocio.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSocio.Location = new System.Drawing.Point(336, 114);
            this.lblNSocio.Name = "lblNSocio";
            this.lblNSocio.Size = new System.Drawing.Size(143, 35);
            this.lblNSocio.TabIndex = 2;
            this.lblNSocio.Text = "N° SOCIO";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(336, 176);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(73, 35);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "AÑO";
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSocio.Location = new System.Drawing.Point(492, 113);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(66, 35);
            this.lblNumSocio.TabIndex = 4;
            this.lblNumSocio.Text = "125";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.Location = new System.Drawing.Point(492, 176);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(83, 35);
            this.lblTemporada.TabIndex = 5;
            this.lblTemporada.Text = "2024";
            // 
            // lblNomSocio
            // 
            this.lblNomSocio.AutoSize = true;
            this.lblNomSocio.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomSocio.Location = new System.Drawing.Point(44, 264);
            this.lblNomSocio.Name = "lblNomSocio";
            this.lblNomSocio.Size = new System.Drawing.Size(136, 35);
            this.lblNomSocio.TabIndex = 6;
            this.lblNomSocio.Text = "NOMBRE";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.Location = new System.Drawing.Point(44, 329);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(153, 35);
            this.lblApe.TabIndex = 7;
            this.lblApe.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(228, 264);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 35);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Leandro";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(228, 329);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(146, 35);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Cardozo";
            // 
            // printCarnet
            // 
            this.printCarnet.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCarnet_PrintPage);
            // 
            // btnImprimirCarnet
            // 
            this.btnImprimirCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.btnImprimirCarnet.FlatAppearance.BorderSize = 0;
            this.btnImprimirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCarnet.Location = new System.Drawing.Point(579, 370);
            this.btnImprimirCarnet.Name = "btnImprimirCarnet";
            this.btnImprimirCarnet.Size = new System.Drawing.Size(143, 46);
            this.btnImprimirCarnet.TabIndex = 20;
            this.btnImprimirCarnet.Text = "IMPRIMIR";
            this.btnImprimirCarnet.UseVisualStyleBackColor = false;
            this.btnImprimirCarnet.Click += new System.EventHandler(this.btnImprimirCarnet_Click);
            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimirCarnet);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNomSocio);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.lblNumSocio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblNSocio);
            this.Controls.Add(this.picCarnet);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA CARNET";
            this.Load += new System.EventHandler(this.frmCarnet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCarnet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picCarnet;
        private System.Windows.Forms.Label lblNSocio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblNomSocio;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Drawing.Printing.PrintDocument printCarnet;
        private System.Windows.Forms.Button btnImprimirCarnet;
    }
}