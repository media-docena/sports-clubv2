using clubdeportivoV2.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubdeportivoV2
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnVolverListaClientes_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Close();
        }

        private void cargarClientes() 
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"select idCliente, nombreC, apellidoC, DNIC, telC, correoC, tipoC, aptoFisico, estadoC " +
                        $"from clientes;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);

                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                // Leemos el resultado de la query ejecutada
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {

                    while (reader.Read()) {

                        int fila = dgvListClientes.Rows.Add();

                        dgvListClientes.Rows[fila].Cells[0].Value = reader.GetInt32(0);
                        dgvListClientes.Rows[fila].Cells[1].Value = reader.GetString(1);
                        dgvListClientes.Rows[fila].Cells[2].Value = reader.GetString(2);
                        dgvListClientes.Rows[fila].Cells[3].Value = reader.GetString(3);
                        dgvListClientes.Rows[fila].Cells[4].Value = reader.GetString(4);
                        dgvListClientes.Rows[fila].Cells[5].Value = reader.GetString(5);
                        dgvListClientes.Rows[fila].Cells[6].Value = reader.GetString(6); // Convertimos el valor booleano a su valor en cadena sí / no
                        dgvListClientes.Rows[fila].Cells[7].Value = Convert.ToBoolean(reader.GetInt32(7)) ? "Sí" : "No";
                        dgvListClientes.Rows[fila].Cells[8].Value = Convert.ToBoolean(reader.GetInt32(8)) ? "Activo" : "Inactivo";

                    }
                }
                else {
                    MessageBox.Show("No existen datos para la carga de la grilla.",
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            /*-------------------------------------------
             * Carga una lista con los clientes registreados
             *-----------------------------------------------*/
            cargarClientes();
        }
    }
}
