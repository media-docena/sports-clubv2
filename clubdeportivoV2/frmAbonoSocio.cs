using clubdeportivoV2.Datos;
using clubdeportivoV2.Entidades;
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
    public partial class frmAbonoSocio : Form
    {
       
        public E_Cliente cliente;
        public E_Cuota cuota;
        public frmAbonoSocio()
        {
            InitializeComponent();
        }

        private void btnMenuPS_Click(object sender, EventArgs e)
        {
            // Permite retornar al formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void limpiarCasillas()
        {
            rdoCuota1.Checked = false;
            rdoCuota3.Checked = false;
            rdoCuota6.Checked = false;
            cboFormaPagoS.SelectedItem = null;
        }

        private bool validarRadioButtons()
        {
            /*---------------------------------------------------------
             *  Valida si alguno de los radio buttons fue
             *  seleccionado para la opción de pago Tarjeta de crédito.
             */
            bool fueSeleccionado = false;
            if(rdoCuota1.Checked || rdoCuota3.Checked || rdoCuota6.Checked) {
                fueSeleccionado = true;
            }
            return fueSeleccionado;
        }

        private void btnVolverAbonoS_Click(object sender, EventArgs e)
        {
            /* -----------------------------------------------
             * Nos lleva de retorno al formulario donde validamos
             * al cliente que va a abonar
             * -----------------------------------------------------*/
            frmPreAbono preabono = new frmPreAbono();
            preabono.Show();
            this.Close();
        }

        private void cboFormaPagoS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* ------------------------------------------------------
             *  Hacemos visible las opciones de crédito únicamente cuando 
             *  se selecciona tarjeta de crédito como forma de pago 
             */
            if (cboFormaPagoS.SelectedItem != null && cboFormaPagoS.SelectedItem.ToString() == "Tarjeta de crédito") {
                grpTarjetaS.Visible = true;
                lblCreditoCuotaS.Visible = true;
            }
            else {
                grpTarjetaS.Visible = false;
                lblCreditoCuotaS.Visible = false;
            }
        }

        private DateTime calcDiaHabil(DateTime fecha) 
        {
            /*-----------------------------------------------
             * La funcón retorna el próximo día hábil de la fecha pasada
             */
            while (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday) {
                fecha = fecha.AddDays(1);
            }
            return fecha;
        }

        private void btnRegistrarPagoS_Click(object sender, EventArgs e)
        {
            /*----------------------------------------------------------
             * Validamos que los campos no estén vacíos
             ----------------------------------------------------------*/
            bool rbSeleccionado = validarRadioButtons();
            if (cboFormaPagoS.SelectedItem == null || cboFormaPagoS.SelectedItem.ToString() == "Tarjeta de crédito" &&
                !rbSeleccionado) {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                /*-----------------------------------------
                 * Declaramos y asignamos las varibles necesarias 
                 * para instanciar la cuota que debe abonar el cliente
                 -------------------------------------------------------*/
                int IDCliente = (int)cliente.IdCliente;
                DateTime fecha = DateTime.Now;
                double monto = double.Parse(txtMonto.Text);
                string formaP = cboFormaPagoS.Text;
                DateTime fechaVence = calcDiaHabil(fecha.AddDays(30));
                string detalle = "Abono de cuota mensual";
                bool tienePromo = false;
                int numCuotas;

                /*-----------------------------------------------------
                 * Validamos que la forma de pago elegida desde el formulario 
                 * sea Tarjeta de crédito para aplicar la promo al abono 
                 ---------------------------------------------------------*/
                if (formaP.Equals("Tarjeta de crédito") && rbSeleccionado && rdoCuota3.Checked || rdoCuota6.Checked) {
                    tienePromo = true;
                    numCuotas = rdoCuota3.Checked ? 3 : 6;
                    cuota = new E_Cuota(fecha, monto, IDCliente, formaP, fechaVence, tienePromo, detalle);
                    cliente.abonar(cuota, numCuotas);
                }
                else 
                {
                    cuota = new E_Cuota(fecha, monto, IDCliente, formaP, fechaVence, tienePromo, detalle);
                }

                // instanciamos para usar el método de cuotas
                Cuotas cuotas = new Cuotas();
                string respuesta = cuotas.Abono_Socio(cuota);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero) {
                    if (codigo == 1) {
                        MessageBox.Show("Cliente ya realizó el pago de la cuota a la fecha", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                       btnRegistrarPagoS.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Se registró con éxito el pago de la cuota", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCasillas();
                        btnComprobanteS.Visible = true;
                        btnRegistrarPagoS.Enabled = false;
                        grpTarjetaS.Visible = false;
                        lblCreditoCuotaS.Visible = false;
                    }
                }
            }
        }

        private void btnComprobanteS_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.cliente = cliente;
            factura.cuota = cuota;
            factura.Show();
            this.Close();
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            frmCarnet carnet = new frmCarnet();
            carnet.cliente = cliente;
            carnet.Show();
            this.Close();
        }
    }
}
