using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubdeportivoV2.Datos;
using clubdeportivoV2.Entidades;


namespace clubdeportivoV2
{
    public partial class frmSociosCuotas : Form
    {
        public frmSociosCuotas()
        {
            InitializeComponent();
        }

        private void btnVolverListaSocio_Click(object sender, EventArgs e)
        {
            // Permite retornar al formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void cargarGrilla(string fechaIngresada)
        {
            
            MySqlConnection sqlCon = new MySqlConnection();
            try 
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"select c.idCliente, concat(c.nombreC,' ', c.apellidoC) as nombre, c.telC, " +
                    $"c.correoC,ctas.monto, ctas.fecha, ctas.fechaVence from clientes as c inner " +
                    $"join cuotas as ctas on c.idCliente = ctas.idCliente where c.tipoC = \"Socio\" " +
                    $"and fechaVence = '{fechaIngresada}' order by nombre;";

                // Ejecutamos el comando de la query
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                // Leemos el resultado de la query ejecutada
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                
                if (reader.HasRows) {
                    while (reader.Read()) {
                        int fila = dgvListadoCuotas.Rows.Add();
                        dgvListadoCuotas.Rows[fila].Cells[0].Value = reader.GetInt32(0);
                        dgvListadoCuotas.Rows[fila].Cells[1].Value = reader.GetString(1);
                        dgvListadoCuotas.Rows[fila].Cells[2].Value = reader.GetInt32(2);
                        dgvListadoCuotas.Rows[fila].Cells[3].Value = reader.GetString(3);
                        dgvListadoCuotas.Rows[fila].Cells[4].Value = reader.GetFloat(4);
                        dgvListadoCuotas.Rows[fila].Cells[5].Value = reader.GetDateTime(5).ToString("dd/MM/yyyy");
                        dgvListadoCuotas.Rows[fila].Cells[6].Value = reader.GetDateTime(6).ToString("dd/MM/yyyy");
                    }
                }
                else 
                {
                    MessageBox.Show("No existen datos para la carga de la grilla.", 
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if (sqlCon.State == ConnectionState.Open) 
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnListaSocios_Click(object sender, EventArgs e)
        {
            limpiarGrilla(); // Primero limpiamos la grilla por si existen resultados previos
            
            // Tomamos la fecha que seleccionó el usuario
            DateTime fechaIngresada = dtpFechaListaSocios.Value;
            

            if(fechaIngresada == null) 
            {
                MessageBox.Show("Debe seleccionar una fecha.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                // Pasamos la fecha seleccionada y llamamos a la función cargarGrilla.
                cargarGrilla(fechaIngresada.Date.ToString("yyyy-MM-dd"));
                
            }
        }

        private void limpiarGrilla()
        { 
            dgvListadoCuotas.Rows.Clear(); // limpia todas las filas
        }
    }
}
