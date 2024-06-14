using clubdeportivoV2.Datos;
using clubdeportivoV2.Entidades;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubdeportivoV2
{
    public partial class frmAbonoNoSocio : Form
    {
        public E_Cliente cliente;
        public E_Cuota cuota;
        public E_Actividad actividad;
        public frmAbonoNoSocio()
        {
            InitializeComponent();
        }

        private void btnVolverNoS_Click(object sender, EventArgs e)
        {
            // Retorna a la pantalla de prevalidación del cliente
            frmPreAbono preAbono = new frmPreAbono();
            preAbono.Show();
            this.Close();
        }

        private void btnMenuPS_Click(object sender, EventArgs e)
        {
            // Volvemos al menú principal de la aplicación
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void cboFormaPagoNS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* ------------------------------------------------------
             *  Hacemos visible las opciones de crédito únicamente cuando 
             *  se selecciona tarjeta de crédito como forma de pago 
             -------------------------------------------------------------*/
            if (cboFormaPagoNS.SelectedItem != null && cboFormaPagoNS.SelectedItem.ToString() == "Tarjeta de crédito") {
                grpTarjetaNS.Visible = true;
                lblCreditoCuotaNS.Visible = true;
            }
            else {
                grpTarjetaNS.Visible = false;
                lblCreditoCuotaNS.Visible = false;
            }
        }

        private bool validarRButtons()
        {
            return rdoCuota1NS.Checked || rdoCuota3NS.Checked || rdoCuota6NS.Checked;
        }

        private bool validarCheckboxes()
        {
            // Valida si alguna casilla de la lista de checkboxes fue seleccionada
            foreach (DataGridViewRow fila in dgvListActividades.Rows) {
                // La columna "inscrip" es de tipo DataGridViewCheckBoxColumn
                DataGridViewCheckBoxCell celda = fila.Cells["inscrip"] as DataGridViewCheckBoxCell;
                if (celda != null && celda.Value != null && (bool)celda.Value) {
                    return true;
                }
            }
            return false;
        }

        private void limpiarCasillas()
        {
            rdoCuota1NS.Checked = false;
            rdoCuota3NS.Checked = false;
            rdoCuota6NS.Checked = false;
            cboFormaPagoNS.SelectedItem = null;
        }

        private void limpiarCheckbox()
        {
            // Limpia la columna entera de los checkboxes
            foreach (DataGridViewRow fila in dgvListActividades.Rows) {

                var checkValor = fila.Cells["inscrip"].Value;

                if (checkValor != null && Convert.ToBoolean(checkValor)) {

                    fila.Cells["inscrip"].Value = false;
                }
            }
        }

        private void limpiarGrilla()
        {
            dgvListActividades.Rows.Clear(); // limpia todas las filas
        }

        private void btnRegPagoNS_Click(object sender, EventArgs e)
        {
            /* ---------------------------------------------------
             * La lógica se aplica al hacer click en el botón de registrar 
             * el pago y verifica que ninguna casilla se encuentre vacía
             *-------------------------------------------------------------------*/
            // 
            if (cboFormaPagoNS.SelectedItem == null ||
                cboFormaPagoNS.SelectedItem.ToString() == "Tarjeta de crédito" && !validarRButtons() ||
                !validarCheckboxes()) {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                /*---------------------------------------------
                 * Recorremos las filas del datagridview hasta encontrar la casilla 
                 * seleccionada del checkbox para obtener los datos de las columnas
                 * de su fila
                 *-------------------------------------------------------------------*/
                foreach (DataGridViewRow fila in dgvListActividades.Rows) {

                    bool seleccionada = (bool)fila.Cells["inscrip"].Value;

                    if (seleccionada) {
                        int id = Convert.ToInt32(fila.Cells["IdActividad"].Value);
                        string nombre = fila.Cells["nombreA"].Value?.ToString();
                        int cupoM = Convert.ToInt32(fila.Cells["cupoM"].Value);
                        int cupoD = Convert.ToInt32(fila.Cells["cupoD"].Value);
                        double precio = Convert.ToDouble(fila.Cells["precio"].Value?.ToString());

                        actividad = new E_Actividad(id, nombre, cupoM, cupoD, precio);
                        break;
                    }
                }

                /*-----------------------------------------
                 * Declaramos y asignamos las variables necesarias 
                 * para instanciar la cuota que debe abonar el cliente
                 *-------------------------------------------------------*/
                DateTime fecha = DateTime.Now;
                string formaP = cboFormaPagoNS.Text;
                string detalle = $"Abono de actividad {actividad.Nombre}";
                bool tienePromo = false;
                int numCuotas;

                /*-----------------------------------------------------
                 * Validamos si la forma de pago elegida desde el formulario 
                 * es Tarjeta de crédito para aplicar la promo al abono 
                 ---------------------------------------------------------*/
                if (formaP.Equals("Tarjeta de crédito") && validarRButtons() && rdoCuota3NS.Checked || rdoCuota6NS.Checked) {
                    tienePromo = true;
                    numCuotas = rdoCuota3NS.Checked ? 3 : 6;
                    cuota = new E_Cuota(fecha, actividad.Precio, (int)cliente.IdCliente, formaP, fecha, tienePromo, detalle);
                    cliente.abonar(cuota, numCuotas);
                }
                else {
                    cuota = new E_Cuota(fecha, actividad.Precio, (int)cliente.IdCliente, formaP, fecha, tienePromo, detalle);
                }

                // instanciamos para usar el método de cuotas
                Cuotas cuotas = new Cuotas();
                string respuesta = cuotas.Abono_NoSocio(cuota, actividad);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero) {
                    if (codigo == 1) {
                        MessageBox.Show("Cliente ya realizó el pago de la actividad",
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        limpiarCheckbox();
                    }
                    else if (codigo == 2) {
                        MessageBox.Show("No hay cupo disponible en la actividad seleccionada.",
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiarCheckbox();
                    }
                    else {
                        MessageBox.Show("Se registró con éxito el pago de la cuota", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cliente.agregarActividad(actividad);
                        actividad.agregarInscripto(cliente);
                        actividad.restarCupo();

                        limpiarCasillas();
                        // Hacemos visible el boton para ir a comprobante de pago
                        btnComprob.Visible = true;
                        
                        // Ocultamos el groupbox que contiene las opciones de crédito
                        grpTarjetaNS.Visible = false;
                        lblCreditoCuotaNS.Visible = false;
                        limpiarGrilla();
                        cargarActividades();
                    }
                }
            }
        }

        private void cargarActividades()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try {
                string query;

                query = $"select idActividad, nombreA, cupoMax, cupoDisp, precio " +
                        $"from actividades where estadoA = 1 ;";

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                // Leemos el resultado de la query 
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        int fila = dgvListActividades.Rows.Add();
                        dgvListActividades.Rows[fila].Cells[0].Value = reader.GetInt32(0);
                        dgvListActividades.Rows[fila].Cells[1].Value = reader.GetString(1);
                        dgvListActividades.Rows[fila].Cells[2].Value = reader.GetInt32(2);
                        dgvListActividades.Rows[fila].Cells[3].Value = reader.GetInt32(3);
                        dgvListActividades.Rows[fila].Cells[4].Value = reader.GetFloat(4);
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

        private void frmAbonoNoSocio_Load(object sender, EventArgs e)
        {
            // Realizamos la carga de las actividades a la grilla
            cargarActividades();
        }

        private void dgvListActividades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /* ---------------------------------------------------------
             * Para que el usuario pueda marcar una sola casilla del 
             * checkbox de la columna correspondiente (Es de selección 
             * múltiple por defecto) aplicamos la lógica a continuación
             * ----------------------------------------------------------*/

            var inscripColumna = dgvListActividades.Columns["inscrip"];

            if (inscripColumna != null && e.ColumnIndex == inscripColumna.Index) {

                // Si una casilla es seleccionada desmarca todos el resto de checkboxes de la columna "inscrip"
                if ((bool)dgvListActividades[e.ColumnIndex, e.RowIndex].Value) {
                    foreach (DataGridViewRow fila in dgvListActividades.Rows) {
                        if (fila.Index != e.RowIndex) {
                            fila.Cells["inscrip"].Value = false;
                        }
                    }
                }
            }
        }

        private void dgvListActividades_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            /*------------------------------------------------------------
             * Nos suscribimos a este evento para que actualice el estado
             * de la celda del checkbox cuando el usuario lo marca o desmarca
             * forzando un CommitEdit que a su vez activa el evento CellValueChanged.
             * ---------------------------------------------------------------*/
            if (dgvListActividades.IsCurrentCellDirty) {
                dgvListActividades.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnComprob_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.cliente = cliente;
            factura.cuota = cuota;
            factura.Show();
            this.Close();
        }
    }
}
