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
            if (cboFormaPagoS.SelectedItem != null && cboFormaPagoS.SelectedItem.ToString() == "Tarjeta de crédito") {
                grpTarjetaS.Visible = true;
                lblCreditoCuotaS.Visible = true;
            }
            else {
                grpTarjetaS.Visible = false;
                lblCreditoCuotaS.Visible = false;
            }
        }

        private void btnRegistrarPagoS_Click(object sender, EventArgs e)
        {
            /*----------------------------------------------------------
             * Validamos que los campos no estén vacíos
             ----------------------------------------------------------*/
            bool rbSeleccionado = validarRadioButtons();
            if (cboFormaPagoS.SelectedItem == null || cboFormaPagoS.SelectedItem.ToString() == "Tarjeta de crédito" &&
                !rbSeleccionado) 
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
