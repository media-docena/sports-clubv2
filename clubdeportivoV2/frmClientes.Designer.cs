namespace clubdeportivoV2
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblListClientes = new System.Windows.Forms.Label();
            this.dgvListClientes = new System.Windows.Forms.DataGridView();
            this.btnVolverListaClientes = new System.Windows.Forms.Button();
            this.IdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListClientes
            // 
            this.lblListClientes.AutoSize = true;
            this.lblListClientes.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(193)))));
            this.lblListClientes.Location = new System.Drawing.Point(473, 46);
            this.lblListClientes.Name = "lblListClientes";
            this.lblListClientes.Size = new System.Drawing.Size(353, 32);
            this.lblListClientes.TabIndex = 4;
            this.lblListClientes.Text = "LISTADO DE CLIENTES";
            // 
            // dgvListClientes
            // 
            this.dgvListClientes.AllowUserToAddRows = false;
            this.dgvListClientes.AllowUserToDeleteRows = false;
            this.dgvListClientes.AllowUserToOrderColumns = true;
            this.dgvListClientes.AllowUserToResizeColumns = false;
            this.dgvListClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgvListClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCli,
            this.nomCli,
            this.apellidoCli,
            this.dniCli,
            this.telC,
            this.correoC,
            this.tipoCli,
            this.aptoF,
            this.estadoCli});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListClientes.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListClientes.EnableHeadersVisualStyles = false;
            this.dgvListClientes.GridColor = System.Drawing.Color.LightGray;
            this.dgvListClientes.Location = new System.Drawing.Point(27, 121);
            this.dgvListClientes.MultiSelect = false;
            this.dgvListClientes.Name = "dgvListClientes";
            this.dgvListClientes.ReadOnly = true;
            this.dgvListClientes.RowHeadersVisible = false;
            this.dgvListClientes.RowHeadersWidth = 51;
            this.dgvListClientes.RowTemplate.Height = 25;
            this.dgvListClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListClientes.Size = new System.Drawing.Size(1306, 415);
            this.dgvListClientes.TabIndex = 5;
            // 
            // btnVolverListaClientes
            // 
            this.btnVolverListaClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverListaClientes.FlatAppearance.BorderSize = 0;
            this.btnVolverListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverListaClientes.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.btnVolverListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverListaClientes.Image")));
            this.btnVolverListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverListaClientes.Location = new System.Drawing.Point(29, 562);
            this.btnVolverListaClientes.Name = "btnVolverListaClientes";
            this.btnVolverListaClientes.Size = new System.Drawing.Size(265, 63);
            this.btnVolverListaClientes.TabIndex = 23;
            this.btnVolverListaClientes.Text = "VOLVER";
            this.btnVolverListaClientes.UseVisualStyleBackColor = false;
            this.btnVolverListaClientes.Click += new System.EventHandler(this.btnVolverListaClientes_Click);
            // 
            // IdCli
            // 
            this.IdCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCli.FillWeight = 120F;
            this.IdCli.HeaderText = "ID Cliente";
            this.IdCli.MinimumWidth = 6;
            this.IdCli.Name = "IdCli";
            this.IdCli.ReadOnly = true;
            this.IdCli.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nomCli
            // 
            this.nomCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCli.FillWeight = 150F;
            this.nomCli.HeaderText = "Nombre";
            this.nomCli.MinimumWidth = 6;
            this.nomCli.Name = "nomCli";
            this.nomCli.ReadOnly = true;
            this.nomCli.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // apellidoCli
            // 
            this.apellidoCli.FillWeight = 120F;
            this.apellidoCli.HeaderText = "Apellido";
            this.apellidoCli.MinimumWidth = 6;
            this.apellidoCli.Name = "apellidoCli";
            this.apellidoCli.ReadOnly = true;
            // 
            // dniCli
            // 
            this.dniCli.FillWeight = 120F;
            this.dniCli.HeaderText = "DNI";
            this.dniCli.MinimumWidth = 6;
            this.dniCli.Name = "dniCli";
            this.dniCli.ReadOnly = true;
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
            // tipoCli
            // 
            this.tipoCli.HeaderText = "Tipo";
            this.tipoCli.MinimumWidth = 6;
            this.tipoCli.Name = "tipoCli";
            this.tipoCli.ReadOnly = true;
            // 
            // aptoF
            // 
            this.aptoF.HeaderText = "Apto Físico";
            this.aptoF.MinimumWidth = 6;
            this.aptoF.Name = "aptoF";
            this.aptoF.ReadOnly = true;
            // 
            // estadoCli
            // 
            this.estadoCli.HeaderText = "Estado";
            this.estadoCli.MinimumWidth = 6;
            this.estadoCli.Name = "estadoCli";
            this.estadoCli.ReadOnly = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 645);
            this.Controls.Add(this.btnVolverListaClientes);
            this.Controls.Add(this.dgvListClientes);
            this.Controls.Add(this.lblListClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.Text = "VENTANA CLIENTES";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListClientes;
        private System.Windows.Forms.DataGridView dgvListClientes;
        private System.Windows.Forms.Button btnVolverListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn telC;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCli;
    }
}