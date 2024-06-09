namespace clubdeportivoV2
{
    partial class frmSociosCuotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSociosCuotas));
            this.btnListaSocios = new System.Windows.Forms.Button();
            this.lblListadoSocios = new System.Windows.Forms.Label();
            this.dtpFechaListaSocios = new System.Windows.Forms.DateTimePicker();
            this.lblIngresoFecha = new System.Windows.Forms.Label();
            this.dgvListadoCuotas = new System.Windows.Forms.DataGridView();
            this.btnVolverListaSocio = new System.Windows.Forms.Button();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaSocios
            // 
            this.btnListaSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.btnListaSocios.FlatAppearance.BorderSize = 0;
            this.btnListaSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaSocios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListaSocios.Location = new System.Drawing.Point(804, 133);
            this.btnListaSocios.Name = "btnListaSocios";
            this.btnListaSocios.Size = new System.Drawing.Size(142, 54);
            this.btnListaSocios.TabIndex = 0;
            this.btnListaSocios.Text = "CONFIRMAR";
            this.btnListaSocios.UseVisualStyleBackColor = false;
            this.btnListaSocios.Click += new System.EventHandler(this.btnListaSocios_Click);
            // 
            // lblListadoSocios
            // 
            this.lblListadoSocios.AutoSize = true;
            this.lblListadoSocios.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoSocios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblListadoSocios.Location = new System.Drawing.Point(274, 54);
            this.lblListadoSocios.Name = "lblListadoSocios";
            this.lblListadoSocios.Size = new System.Drawing.Size(683, 32);
            this.lblListadoSocios.TabIndex = 1;
            this.lblListadoSocios.Text = "LISTADO DE SOCIOS CON CUOTAS A VENCER";
            // 
            // dtpFechaListaSocios
            // 
            this.dtpFechaListaSocios.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaListaSocios.CustomFormat = "  dd / MM / yyyy";
            this.dtpFechaListaSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaListaSocios.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaListaSocios.Location = new System.Drawing.Point(464, 146);
            this.dtpFechaListaSocios.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaListaSocios.Name = "dtpFechaListaSocios";
            this.dtpFechaListaSocios.Size = new System.Drawing.Size(292, 30);
            this.dtpFechaListaSocios.TabIndex = 2;
            // 
            // lblIngresoFecha
            // 
            this.lblIngresoFecha.AutoSize = true;
            this.lblIngresoFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoFecha.Location = new System.Drawing.Point(291, 144);
            this.lblIngresoFecha.Name = "lblIngresoFecha";
            this.lblIngresoFecha.Size = new System.Drawing.Size(137, 28);
            this.lblIngresoFecha.TabIndex = 3;
            this.lblIngresoFecha.Text = "Ingresar Fecha";
            // 
            // dgvListadoCuotas
            // 
            this.dgvListadoCuotas.AllowUserToAddRows = false;
            this.dgvListadoCuotas.AllowUserToDeleteRows = false;
            this.dgvListadoCuotas.AllowUserToOrderColumns = true;
            this.dgvListadoCuotas.AllowUserToResizeColumns = false;
            this.dgvListadoCuotas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgvListadoCuotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoCuotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoCuotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListadoCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nombreC,
            this.telC,
            this.correoC,
            this.abono,
            this.fecha,
            this.fechaVenc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoCuotas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoCuotas.EnableHeadersVisualStyles = false;
            this.dgvListadoCuotas.GridColor = System.Drawing.Color.LightGray;
            this.dgvListadoCuotas.Location = new System.Drawing.Point(39, 235);
            this.dgvListadoCuotas.MultiSelect = false;
            this.dgvListadoCuotas.Name = "dgvListadoCuotas";
            this.dgvListadoCuotas.ReadOnly = true;
            this.dgvListadoCuotas.RowHeadersVisible = false;
            this.dgvListadoCuotas.RowHeadersWidth = 51;
            this.dgvListadoCuotas.RowTemplate.Height = 25;
            this.dgvListadoCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCuotas.Size = new System.Drawing.Size(1266, 318);
            this.dgvListadoCuotas.TabIndex = 4;
            // 
            // btnVolverListaSocio
            // 
            this.btnVolverListaSocio.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverListaSocio.FlatAppearance.BorderSize = 0;
            this.btnVolverListaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverListaSocio.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverListaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverListaSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverListaSocio.Image")));
            this.btnVolverListaSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverListaSocio.Location = new System.Drawing.Point(1105, 584);
            this.btnVolverListaSocio.Name = "btnVolverListaSocio";
            this.btnVolverListaSocio.Size = new System.Drawing.Size(240, 63);
            this.btnVolverListaSocio.TabIndex = 22;
            this.btnVolverListaSocio.Text = "VOLVER";
            this.btnVolverListaSocio.UseVisualStyleBackColor = false;
            this.btnVolverListaSocio.Click += new System.EventHandler(this.btnVolverListaSocio_Click);
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreC
            // 
            this.nombreC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreC.FillWeight = 180F;
            this.nombreC.HeaderText = "Nombre";
            this.nombreC.MinimumWidth = 6;
            this.nombreC.Name = "nombreC";
            this.nombreC.ReadOnly = true;
            this.nombreC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // telC
            // 
            this.telC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telC.FillWeight = 120F;
            this.telC.HeaderText = "Teléfono";
            this.telC.MinimumWidth = 6;
            this.telC.Name = "telC";
            this.telC.ReadOnly = true;
            // 
            // correoC
            // 
            this.correoC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoC.FillWeight = 250F;
            this.correoC.HeaderText = "Correo";
            this.correoC.MinimumWidth = 6;
            this.correoC.Name = "correoC";
            this.correoC.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abono.HeaderText = "Abonó";
            this.abono.MinimumWidth = 6;
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.FillWeight = 120F;
            this.fecha.HeaderText = "Fecha Último Pago ";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // fechaVenc
            // 
            this.fechaVenc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaVenc.FillWeight = 120F;
            this.fechaVenc.HeaderText = "Fecha Vencimiento";
            this.fechaVenc.MinimumWidth = 6;
            this.fechaVenc.Name = "fechaVenc";
            this.fechaVenc.ReadOnly = true;
            // 
            // frmSociosCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 668);
            this.Controls.Add(this.btnVolverListaSocio);
            this.Controls.Add(this.dgvListadoCuotas);
            this.Controls.Add(this.lblIngresoFecha);
            this.Controls.Add(this.dtpFechaListaSocios);
            this.Controls.Add(this.lblListadoSocios);
            this.Controls.Add(this.btnListaSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSociosCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE CUOTAS DE SOCIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaSocios;
        private System.Windows.Forms.Label lblListadoSocios;
        private System.Windows.Forms.DateTimePicker dtpFechaListaSocios;
        private System.Windows.Forms.Label lblIngresoFecha;
        private System.Windows.Forms.DataGridView dgvListadoCuotas;
        private System.Windows.Forms.Button btnVolverListaSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn telC;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenc;
    }
}