namespace clubdeportivoV2
{
    partial class frmAbonoNoSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonoNoSocio));
            this.lblAbonarNoSocio = new System.Windows.Forms.Label();
            this.cboFormaPagoNS = new System.Windows.Forms.ComboBox();
            this.lblFormaPagoNS = new System.Windows.Forms.Label();
            this.lblAstNS = new System.Windows.Forms.Label();
            this.lblCreditoCuotaNS = new System.Windows.Forms.Label();
            this.grpTarjetaNS = new System.Windows.Forms.GroupBox();
            this.lblPromo6NS = new System.Windows.Forms.Label();
            this.lblPromo3NS = new System.Windows.Forms.Label();
            this.rdoCuota6NS = new System.Windows.Forms.RadioButton();
            this.rdoCuota3NS = new System.Windows.Forms.RadioButton();
            this.rdoCuota1NS = new System.Windows.Forms.RadioButton();
            this.btnRegPagoNS = new System.Windows.Forms.Button();
            this.dgvListActividades = new System.Windows.Forms.DataGridView();
            this.btnVolverNoS = new System.Windows.Forms.Button();
            this.btnMenuPS = new System.Windows.Forms.Button();
            this.btnComprob = new System.Windows.Forms.Button();
            this.IdActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpTarjetaNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbonarNoSocio
            // 
            this.lblAbonarNoSocio.AutoSize = true;
            this.lblAbonarNoSocio.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonarNoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblAbonarNoSocio.Location = new System.Drawing.Point(459, 56);
            this.lblAbonarNoSocio.Name = "lblAbonarNoSocio";
            this.lblAbonarNoSocio.Size = new System.Drawing.Size(330, 32);
            this.lblAbonarNoSocio.TabIndex = 6;
            this.lblAbonarNoSocio.Text = "ABONAR ACTIVIDAD";
            // 
            // cboFormaPagoNS
            // 
            this.cboFormaPagoNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagoNS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPagoNS.FormattingEnabled = true;
            this.cboFormaPagoNS.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito"});
            this.cboFormaPagoNS.Location = new System.Drawing.Point(459, 155);
            this.cboFormaPagoNS.Name = "cboFormaPagoNS";
            this.cboFormaPagoNS.Size = new System.Drawing.Size(316, 36);
            this.cboFormaPagoNS.TabIndex = 27;
            this.cboFormaPagoNS.SelectionChangeCommitted += new System.EventHandler(this.cboFormaPagoNS_SelectionChangeCommitted);
            // 
            // lblFormaPagoNS
            // 
            this.lblFormaPagoNS.AutoSize = true;
            this.lblFormaPagoNS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagoNS.Location = new System.Drawing.Point(276, 157);
            this.lblFormaPagoNS.Name = "lblFormaPagoNS";
            this.lblFormaPagoNS.Size = new System.Drawing.Size(144, 28);
            this.lblFormaPagoNS.TabIndex = 26;
            this.lblFormaPagoNS.Text = "Forma de Pago";
            // 
            // lblAstNS
            // 
            this.lblAstNS.AutoSize = true;
            this.lblAstNS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstNS.ForeColor = System.Drawing.Color.Red;
            this.lblAstNS.Location = new System.Drawing.Point(801, 163);
            this.lblAstNS.Name = "lblAstNS";
            this.lblAstNS.Size = new System.Drawing.Size(19, 22);
            this.lblAstNS.TabIndex = 25;
            this.lblAstNS.Text = "*";
            // 
            // lblCreditoCuotaNS
            // 
            this.lblCreditoCuotaNS.AutoSize = true;
            this.lblCreditoCuotaNS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoCuotaNS.ForeColor = System.Drawing.Color.Red;
            this.lblCreditoCuotaNS.Location = new System.Drawing.Point(1218, 105);
            this.lblCreditoCuotaNS.Name = "lblCreditoCuotaNS";
            this.lblCreditoCuotaNS.Size = new System.Drawing.Size(19, 22);
            this.lblCreditoCuotaNS.TabIndex = 32;
            this.lblCreditoCuotaNS.Text = "*";
            this.lblCreditoCuotaNS.Visible = false;
            // 
            // grpTarjetaNS
            // 
            this.grpTarjetaNS.BackColor = System.Drawing.Color.White;
            this.grpTarjetaNS.Controls.Add(this.lblPromo6NS);
            this.grpTarjetaNS.Controls.Add(this.lblPromo3NS);
            this.grpTarjetaNS.Controls.Add(this.rdoCuota6NS);
            this.grpTarjetaNS.Controls.Add(this.rdoCuota3NS);
            this.grpTarjetaNS.Controls.Add(this.rdoCuota1NS);
            this.grpTarjetaNS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTarjetaNS.Location = new System.Drawing.Point(872, 105);
            this.grpTarjetaNS.Name = "grpTarjetaNS";
            this.grpTarjetaNS.Size = new System.Drawing.Size(340, 222);
            this.grpTarjetaNS.TabIndex = 31;
            this.grpTarjetaNS.TabStop = false;
            this.grpTarjetaNS.Text = "Seleccione una opción";
            this.grpTarjetaNS.Visible = false;
            // 
            // lblPromo6NS
            // 
            this.lblPromo6NS.AutoSize = true;
            this.lblPromo6NS.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPromo6NS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo6NS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblPromo6NS.Location = new System.Drawing.Point(52, 157);
            this.lblPromo6NS.Name = "lblPromo6NS";
            this.lblPromo6NS.Size = new System.Drawing.Size(253, 25);
            this.lblPromo6NS.TabIndex = 4;
            this.lblPromo6NS.Text = "10% OFF del total sin interés";
            // 
            // lblPromo3NS
            // 
            this.lblPromo3NS.AutoSize = true;
            this.lblPromo3NS.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPromo3NS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo3NS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblPromo3NS.Location = new System.Drawing.Point(52, 99);
            this.lblPromo3NS.Name = "lblPromo3NS";
            this.lblPromo3NS.Size = new System.Drawing.Size(243, 25);
            this.lblPromo3NS.TabIndex = 3;
            this.lblPromo3NS.Text = "5% OFF del total sin interés";
            // 
            // rdoCuota6NS
            // 
            this.rdoCuota6NS.AutoSize = true;
            this.rdoCuota6NS.Location = new System.Drawing.Point(22, 127);
            this.rdoCuota6NS.Name = "rdoCuota6NS";
            this.rdoCuota6NS.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota6NS.TabIndex = 2;
            this.rdoCuota6NS.TabStop = true;
            this.rdoCuota6NS.Text = "6 cuotas";
            this.rdoCuota6NS.UseVisualStyleBackColor = true;
            // 
            // rdoCuota3NS
            // 
            this.rdoCuota3NS.AutoSize = true;
            this.rdoCuota3NS.Location = new System.Drawing.Point(22, 69);
            this.rdoCuota3NS.Name = "rdoCuota3NS";
            this.rdoCuota3NS.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota3NS.TabIndex = 1;
            this.rdoCuota3NS.TabStop = true;
            this.rdoCuota3NS.Text = "3 cuotas";
            this.rdoCuota3NS.UseVisualStyleBackColor = true;
            // 
            // rdoCuota1NS
            // 
            this.rdoCuota1NS.AutoSize = true;
            this.rdoCuota1NS.Location = new System.Drawing.Point(22, 38);
            this.rdoCuota1NS.Name = "rdoCuota1NS";
            this.rdoCuota1NS.Size = new System.Drawing.Size(95, 27);
            this.rdoCuota1NS.TabIndex = 0;
            this.rdoCuota1NS.TabStop = true;
            this.rdoCuota1NS.Text = "1 cuotas";
            this.rdoCuota1NS.UseVisualStyleBackColor = true;
            // 
            // btnRegPagoNS
            // 
            this.btnRegPagoNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.btnRegPagoNS.FlatAppearance.BorderSize = 0;
            this.btnRegPagoNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegPagoNS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPagoNS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegPagoNS.Location = new System.Drawing.Point(534, 244);
            this.btnRegPagoNS.Name = "btnRegPagoNS";
            this.btnRegPagoNS.Size = new System.Drawing.Size(157, 63);
            this.btnRegPagoNS.TabIndex = 33;
            this.btnRegPagoNS.Text = "REGISTRAR PAGO";
            this.btnRegPagoNS.UseVisualStyleBackColor = false;
            this.btnRegPagoNS.Click += new System.EventHandler(this.btnRegPagoNS_Click);
            // 
            // dgvListActividades
            // 
            this.dgvListActividades.AllowUserToAddRows = false;
            this.dgvListActividades.AllowUserToDeleteRows = false;
            this.dgvListActividades.AllowUserToOrderColumns = true;
            this.dgvListActividades.AllowUserToResizeColumns = false;
            this.dgvListActividades.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgvListActividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListActividades.BackgroundColor = System.Drawing.Color.White;
            this.dgvListActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListActividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListActividades.ColumnHeadersHeight = 28;
            this.dgvListActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdActividad,
            this.nombreA,
            this.cupoM,
            this.cupoD,
            this.precio,
            this.inscrip});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListActividades.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListActividades.EnableHeadersVisualStyles = false;
            this.dgvListActividades.GridColor = System.Drawing.Color.LightGray;
            this.dgvListActividades.Location = new System.Drawing.Point(38, 379);
            this.dgvListActividades.MultiSelect = false;
            this.dgvListActividades.Name = "dgvListActividades";
            this.dgvListActividades.RowHeadersVisible = false;
            this.dgvListActividades.RowHeadersWidth = 51;
            this.dgvListActividades.RowTemplate.Height = 25;
            this.dgvListActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListActividades.Size = new System.Drawing.Size(1266, 324);
            this.dgvListActividades.TabIndex = 34;
            this.dgvListActividades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListActividades_CellValueChanged);
            this.dgvListActividades.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvListActividades_CurrentCellDirtyStateChanged);
            // 
            // btnVolverNoS
            // 
            this.btnVolverNoS.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverNoS.FlatAppearance.BorderSize = 0;
            this.btnVolverNoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverNoS.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverNoS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverNoS.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverNoS.Image")));
            this.btnVolverNoS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverNoS.Location = new System.Drawing.Point(38, 745);
            this.btnVolverNoS.Name = "btnVolverNoS";
            this.btnVolverNoS.Size = new System.Drawing.Size(271, 63);
            this.btnVolverNoS.TabIndex = 35;
            this.btnVolverNoS.Text = "VOLVER";
            this.btnVolverNoS.UseVisualStyleBackColor = false;
            this.btnVolverNoS.Click += new System.EventHandler(this.btnVolverNoS_Click);
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
            this.btnMenuPS.Location = new System.Drawing.Point(1011, 745);
            this.btnMenuPS.Name = "btnMenuPS";
            this.btnMenuPS.Size = new System.Drawing.Size(293, 63);
            this.btnMenuPS.TabIndex = 36;
            this.btnMenuPS.Text = "IR AL MENU";
            this.btnMenuPS.UseVisualStyleBackColor = false;
            this.btnMenuPS.Click += new System.EventHandler(this.btnMenuPS_Click);
            // 
            // btnComprob
            // 
            this.btnComprob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnComprob.FlatAppearance.BorderSize = 0;
            this.btnComprob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprob.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComprob.Location = new System.Drawing.Point(290, 244);
            this.btnComprob.Name = "btnComprob";
            this.btnComprob.Size = new System.Drawing.Size(191, 63);
            this.btnComprob.TabIndex = 37;
            this.btnComprob.Text = "GENERAR COMPROBANTE";
            this.btnComprob.UseVisualStyleBackColor = false;
            this.btnComprob.Visible = false;
            this.btnComprob.Click += new System.EventHandler(this.btnComprob_Click);
            // 
            // IdActividad
            // 
            this.IdActividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdActividad.HeaderText = "ID Actividad";
            this.IdActividad.MinimumWidth = 6;
            this.IdActividad.Name = "IdActividad";
            this.IdActividad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreA
            // 
            this.nombreA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreA.FillWeight = 150F;
            this.nombreA.HeaderText = "Nombre";
            this.nombreA.MinimumWidth = 6;
            this.nombreA.Name = "nombreA";
            this.nombreA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cupoM
            // 
            this.cupoM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cupoM.HeaderText = "Cupo Max.";
            this.cupoM.MinimumWidth = 6;
            this.cupoM.Name = "cupoM";
            // 
            // cupoD
            // 
            this.cupoD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cupoD.HeaderText = "Cupo Disponible";
            this.cupoD.MinimumWidth = 6;
            this.cupoD.Name = "cupoD";
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.FillWeight = 120F;
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            // 
            // inscrip
            // 
            this.inscrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inscrip.HeaderText = "Inscribir";
            this.inscrip.MinimumWidth = 6;
            this.inscrip.Name = "inscrip";
            this.inscrip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inscrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmAbonoNoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 836);
            this.Controls.Add(this.btnComprob);
            this.Controls.Add(this.btnMenuPS);
            this.Controls.Add(this.btnVolverNoS);
            this.Controls.Add(this.dgvListActividades);
            this.Controls.Add(this.btnRegPagoNS);
            this.Controls.Add(this.lblCreditoCuotaNS);
            this.Controls.Add(this.grpTarjetaNS);
            this.Controls.Add(this.cboFormaPagoNS);
            this.Controls.Add(this.lblFormaPagoNS);
            this.Controls.Add(this.lblAstNS);
            this.Controls.Add(this.lblAbonarNoSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbonoNoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA ABONO NO SOCIO";
            this.Load += new System.EventHandler(this.frmAbonoNoSocio_Load);
            this.grpTarjetaNS.ResumeLayout(false);
            this.grpTarjetaNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbonarNoSocio;
        private System.Windows.Forms.ComboBox cboFormaPagoNS;
        private System.Windows.Forms.Label lblFormaPagoNS;
        private System.Windows.Forms.Label lblAstNS;
        private System.Windows.Forms.Label lblCreditoCuotaNS;
        private System.Windows.Forms.GroupBox grpTarjetaNS;
        private System.Windows.Forms.Label lblPromo6NS;
        private System.Windows.Forms.Label lblPromo3NS;
        private System.Windows.Forms.RadioButton rdoCuota6NS;
        private System.Windows.Forms.RadioButton rdoCuota3NS;
        private System.Windows.Forms.RadioButton rdoCuota1NS;
        private System.Windows.Forms.Button btnRegPagoNS;
        private System.Windows.Forms.DataGridView dgvListActividades;
        private System.Windows.Forms.Button btnVolverNoS;
        private System.Windows.Forms.Button btnMenuPS;
        private System.Windows.Forms.Button btnComprob;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inscrip;
    }
}