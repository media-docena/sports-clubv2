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
            this.lblSportsClub = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomC = new System.Windows.Forms.Label();
            this.lblApC = new System.Windows.Forms.Label();
            this.lblNSocC = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.btnImprimirCarnet = new System.Windows.Forms.Button();
            this.lblNombreCarnet = new System.Windows.Forms.Label();
            this.lblApellidoCarnet = new System.Windows.Forms.Label();
            this.lblNumeroSocioCarnet = new System.Windows.Forms.Label();
            this.printCarnet = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSportsClub
            // 
            this.lblSportsClub.AutoSize = true;
            this.lblSportsClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportsClub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblSportsClub.Location = new System.Drawing.Point(160, 53);
            this.lblSportsClub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSportsClub.Name = "lblSportsClub";
            this.lblSportsClub.Size = new System.Drawing.Size(193, 29);
            this.lblSportsClub.TabIndex = 6;
            this.lblSportsClub.Text = "SPORTS CLUB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clubdeportivoV2.Properties.Resources.clubdepor_logo;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomC
            // 
            this.lblNomC.AutoSize = true;
            this.lblNomC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomC.Location = new System.Drawing.Point(52, 141);
            this.lblNomC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomC.Name = "lblNomC";
            this.lblNomC.Size = new System.Drawing.Size(60, 17);
            this.lblNomC.TabIndex = 23;
            this.lblNomC.Text = "Nombre:";
            // 
            // lblApC
            // 
            this.lblApC.AutoSize = true;
            this.lblApC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApC.Location = new System.Drawing.Point(52, 174);
            this.lblApC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApC.Name = "lblApC";
            this.lblApC.Size = new System.Drawing.Size(59, 17);
            this.lblApC.TabIndex = 24;
            this.lblApC.Text = "Apellido:";
            // 
            // lblNSocC
            // 
            this.lblNSocC.AutoSize = true;
            this.lblNSocC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSocC.Location = new System.Drawing.Point(52, 208);
            this.lblNSocC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNSocC.Name = "lblNSocC";
            this.lblNSocC.Size = new System.Drawing.Size(113, 17);
            this.lblNSocC.TabIndex = 25;
            this.lblNSocC.Text = "Número de socio:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(195, 95);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(123, 20);
            this.lblCarnet.TabIndex = 26;
            this.lblCarnet.Text = "Carnet de Socio";
            // 
            // btnImprimirCarnet
            // 
            this.btnImprimirCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnImprimirCarnet.FlatAppearance.BorderSize = 0;
            this.btnImprimirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirCarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCarnet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirCarnet.Location = new System.Drawing.Point(283, 223);
            this.btnImprimirCarnet.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimirCarnet.Name = "btnImprimirCarnet";
            this.btnImprimirCarnet.Size = new System.Drawing.Size(92, 29);
            this.btnImprimirCarnet.TabIndex = 27;
            this.btnImprimirCarnet.Text = "IMPRIMIR";
            this.btnImprimirCarnet.UseVisualStyleBackColor = false;
            this.btnImprimirCarnet.Click += new System.EventHandler(this.btnImprimirCarnet_Click);
            // 
            // lblNombreCarnet
            // 
            this.lblNombreCarnet.AutoSize = true;
            this.lblNombreCarnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarnet.Location = new System.Drawing.Point(116, 141);
            this.lblNombreCarnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCarnet.Name = "lblNombreCarnet";
            this.lblNombreCarnet.Size = new System.Drawing.Size(34, 17);
            this.lblNombreCarnet.TabIndex = 28;
            this.lblNombreCarnet.Text = "Juan";
            // 
            // lblApellidoCarnet
            // 
            this.lblApellidoCarnet.AutoSize = true;
            this.lblApellidoCarnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCarnet.Location = new System.Drawing.Point(115, 174);
            this.lblApellidoCarnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCarnet.Name = "lblApellidoCarnet";
            this.lblApellidoCarnet.Size = new System.Drawing.Size(40, 17);
            this.lblApellidoCarnet.TabIndex = 29;
            this.lblApellidoCarnet.Text = "Pérez";
            // 
            // lblNumeroSocioCarnet
            // 
            this.lblNumeroSocioCarnet.AutoSize = true;
            this.lblNumeroSocioCarnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSocioCarnet.Location = new System.Drawing.Point(169, 208);
            this.lblNumeroSocioCarnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroSocioCarnet.Name = "lblNumeroSocioCarnet";
            this.lblNumeroSocioCarnet.Size = new System.Drawing.Size(29, 17);
            this.lblNumeroSocioCarnet.TabIndex = 30;
            this.lblNumeroSocioCarnet.Text = "253";
            // 
            // printCarnet
            // 
            this.printCarnet.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCarnet_PrintPage);
            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(395, 272);
            this.Controls.Add(this.lblNumeroSocioCarnet);
            this.Controls.Add(this.lblApellidoCarnet);
            this.Controls.Add(this.lblNombreCarnet);
            this.Controls.Add(this.btnImprimirCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblNSocC);
            this.Controls.Add(this.lblApC);
            this.Controls.Add(this.lblNomC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSportsClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarnet";
            this.Text = "frmCarnet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSportsClub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomC;
        private System.Windows.Forms.Label lblApC;
        private System.Windows.Forms.Label lblNSocC;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Button btnImprimirCarnet;
        private System.Windows.Forms.Label lblNombreCarnet;
        private System.Windows.Forms.Label lblApellidoCarnet;
        private System.Windows.Forms.Label lblNumeroSocioCarnet;
        private System.Drawing.Printing.PrintDocument printCarnet;
    }
}