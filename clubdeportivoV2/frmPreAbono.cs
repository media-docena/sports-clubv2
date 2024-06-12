using clubdeportivoV2.Datos;
using clubdeportivoV2.Entidades;
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
    public partial class frmPreAbono : Form
    {
        /**---------------------------------------------------
        * Creamos las propiedas del cliente para instanciarlo y pasarlo
        * al formulario del abono correspondiente según su tipo socio/no_socio.
        */

        public int Id_c { get; set; }
        public string Nombre_c { get; set; }
        public string Apellido_c { get; set; }
        public string DNI_c { get; set; }
        public string Tel_c { get; set; }
        public string Correo_c { get; set; }
        public string Tipo_c { get; set; }
        public bool AptoFisico_c { get; set; }
        public bool Estado_c { get; set; }

        public frmPreAbono()
        {
            InitializeComponent();
        }

        private E_Cliente ValidarCliente(int identificacion)
        {
            /* ---------------------------------------------
             * Primero validamos que el cliente que va a abonar
             * efectivamente existe y de acuerdo a su tipo lo instanciamos y pasamos
             * a su modelo de pago correspondiente.
             * ------------------------------------------------ */
            E_Cliente cliente = null;

            MySqlConnection sqlCon = new MySqlConnection();
            try {

                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"select idCliente, nombreC, apellidoC, DNIC, telC, correoC, tipoC, aptoFisico, estadoC " +
                        $"from clientes where idCliente = {identificacion} or DNIC = {identificacion};";


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                // Leemos el resultado de la query ejecutada
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    // Sabemos que en el caso afirmativo retorna una sola fila
                    reader.Read();
                    /*-------------------------------------------------------------
                    * Asignamos los valores que traemos de la bd a los atributos del
                    * formulario 
                    **/
                    Id_c = reader.GetInt32(0);
                    Nombre_c = reader.GetString(1);
                    Apellido_c = reader.GetString(2);
                    DNI_c = reader.GetString(3);
                    Tel_c = reader.GetString(4);
                    Correo_c = reader.GetString(5);
                    Tipo_c = reader.GetString(6);
                    AptoFisico_c = reader.GetBoolean(7);
                    Estado_c = reader.GetBoolean(8);

                    // Chequemos el tipo de cliente 
                    if (Tipo_c.ToLower().Equals("socio")) {
                        
                        cliente = new E_Socio(Nombre_c, Apellido_c, DNI_c, Tel_c, 
                            Correo_c, Tipo_c, AptoFisico_c, Estado_c, Id_c);
                    }
                    else 
                    { 
                        cliente = new E_No_Socio(Nombre_c, Apellido_c, DNI_c, Tel_c,
                            Correo_c, Tipo_c, AptoFisico_c, Estado_c, Id_c);
                    }
                    
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
            return cliente;
        }

        private void btnConfirmarPreAbono_Click(object sender, EventArgs e)
        {
            frmAbonoSocio formAbonoSocio = new frmAbonoSocio();
            int identificacion;

            // Validamos que la entrada no esté vacía sea numérica
            if (txtIdPreAbono.Text.Trim() != "" && Int32.TryParse(txtIdPreAbono.Text.Trim(), out identificacion)) {
                formAbonoSocio.cliente = ValidarCliente(identificacion);
                /**
                 * Chequeamos si el cliente es socio y pasamos
                 * a su formulario de pago
                 */
                if (formAbonoSocio.cliente != null && formAbonoSocio.cliente.TipoC.ToLower().Equals("socio")) {
                    formAbonoSocio.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("No existen datos del cliente ingresado.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Limpiamos la casilla
                    txtIdPreAbono.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("Debe completar el dato requerido de identificación. (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnVolverPreAbono_Click(object sender, EventArgs e)
        {
            // Permite retornar al formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }
    }
}
