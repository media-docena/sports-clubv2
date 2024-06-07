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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSociosCuotas));
            this.btnListarSocios = new System.Windows.Forms.Button();
            this.lblListadoSocios = new System.Windows.Forms.Label();
            this.dtpFechaListaSocios = new System.Windows.Forms.DateTimePicker();
            this.lblIngresoFecha = new System.Windows.Forms.Label();
            this.dgvListadoSocios = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverListaSocio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarSocios
            // 
            this.btnListarSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.btnListarSocios.FlatAppearance.BorderSize = 0;
            this.btnListarSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarSocios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarSocios.Location = new System.Drawing.Point(826, 147);
            this.btnListarSocios.Name = "btnListarSocios";
            this.btnListarSocios.Size = new System.Drawing.Size(142, 54);
            this.btnListarSocios.TabIndex = 0;
            this.btnListarSocios.Text = "CONFIRMAR";
            this.btnListarSocios.UseVisualStyleBackColor = false;
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
            this.dtpFechaListaSocios.Location = new System.Drawing.Point(388, 160);
            this.dtpFechaListaSocios.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaListaSocios.Name = "dtpFechaListaSocios";
            this.dtpFechaListaSocios.Size = new System.Drawing.Size(406, 30);
            this.dtpFechaListaSocios.TabIndex = 2;
            // 
            // lblIngresoFecha
            // 
            this.lblIngresoFecha.AutoSize = true;
            this.lblIngresoFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoFecha.Location = new System.Drawing.Point(226, 159);
            this.lblIngresoFecha.Name = "lblIngresoFecha";
            this.lblIngresoFecha.Size = new System.Drawing.Size(137, 28);
            this.lblIngresoFecha.TabIndex = 3;
            this.lblIngresoFecha.Text = "Ingresar Fecha";
            // 
            // dgvListadoSocios
            // 
            this.dgvListadoSocios.AllowUserToAddRows = false;
            this.dgvListadoSocios.AllowUserToDeleteRows = false;
            this.dgvListadoSocios.AllowUserToResizeColumns = false;
            this.dgvListadoSocios.AllowUserToResizeRows = false;
            this.dgvListadoSocios.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoSocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoSocios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListadoSocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvListadoSocios.ColumnHeadersHeight = 61;
            this.dgvListadoSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nombreC,
            this.apellidoC,
            this.telC,
            this.correoC,
            this.fecha,
            this.fechaVenc});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoSocios.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListadoSocios.EnableHeadersVisualStyles = false;
            this.dgvListadoSocios.GridColor = System.Drawing.Color.LightGray;
            this.dgvListadoSocios.Location = new System.Drawing.Point(39, 263);
            this.dgvListadoSocios.MultiSelect = false;
            this.dgvListadoSocios.Name = "dgvListadoSocios";
            this.dgvListadoSocios.ReadOnly = true;
            this.dgvListadoSocios.RowHeadersVisible = false;
            this.dgvListadoSocios.RowHeadersWidth = 51;
            this.dgvListadoSocios.RowTemplate.DividerHeight = 2;
            this.dgvListadoSocios.RowTemplate.Height = 25;
            this.dgvListadoSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoSocios.Size = new System.Drawing.Size(1172, 273);
            this.dgvListadoSocios.TabIndex = 4;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCliente.HeaderText = "ID Cliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // nombreC
            // 
            this.nombreC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreC.FillWeight = 120F;
            this.nombreC.HeaderText = "Nombre";
            this.nombreC.MinimumWidth = 6;
            this.nombreC.Name = "nombreC";
            this.nombreC.ReadOnly = true;
            // 
            // apellidoC
            // 
            this.apellidoC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoC.FillWeight = 120F;
            this.apellidoC.HeaderText = "Apellido";
            this.apellidoC.MinimumWidth = 6;
            this.apellidoC.Name = "apellidoC";
            this.apellidoC.ReadOnly = true;
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
            this.correoC.FillWeight = 150F;
            this.correoC.HeaderText = "Correo";
            this.correoC.MinimumWidth = 6;
            this.correoC.Name = "correoC";
            this.correoC.ReadOnly = true;
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
            // btnVolverListaSocio
            // 
            this.btnVolverListaSocio.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverListaSocio.FlatAppearance.BorderSize = 0;
            this.btnVolverListaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverListaSocio.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverListaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverListaSocio.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverListaSocio.Image")));
            this.btnVolverListaSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverListaSocio.Location = new System.Drawing.Point(1032, 570);
            this.btnVolverListaSocio.Name = "btnVolverListaSocio";
            this.btnVolverListaSocio.Size = new System.Drawing.Size(227, 63);
            this.btnVolverListaSocio.TabIndex = 22;
            this.btnVolverListaSocio.Text = "VOLVER";
            this.btnVolverListaSocio.UseVisualStyleBackColor = false;
            this.btnVolverListaSocio.Click += new System.EventHandler(this.btnVolverListaSocio_Click);
            // 
            // frmSociosCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 645);
            this.Controls.Add(this.btnVolverListaSocio);
            this.Controls.Add(this.dgvListadoSocios);
            this.Controls.Add(this.lblIngresoFecha);
            this.Controls.Add(this.dtpFechaListaSocios);
            this.Controls.Add(this.lblListadoSocios);
            this.Controls.Add(this.btnListarSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSociosCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE CUOTAS DE SOCIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarSocios;
        private System.Windows.Forms.Label lblListadoSocios;
        private System.Windows.Forms.DateTimePicker dtpFechaListaSocios;
        private System.Windows.Forms.Label lblIngresoFecha;
        private System.Windows.Forms.DataGridView dgvListadoSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn telC;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenc;
        private System.Windows.Forms.Button btnVolverListaSocio;
    }
}