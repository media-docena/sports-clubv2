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
    public partial class frmRegistro : Form
    {
        bool aptoFisico; // declaramos la varible para asignarle la opción seleccionada en el formulario.
        public frmRegistro()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            cboTipoC.Items.Add("Socio");
            cboTipoC.Items.Add("No Socio");
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreC.Text == "" || txtApellidoC.Text == "" || txtTelC.Text == ""
                || txtCorreoC.Text == "" || cboTipoC.Text == "" || txtDNIC.Text == "" || !validarRButtons()) {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string respuesta;
                E_Cliente cliente;

                string nombre = txtNombreC.Text;
                string apellido = txtApellidoC.Text;
                string tel = txtTelC.Text;
                string correo = txtCorreoC.Text;
                string tipoCliente = cboTipoC.Text;
                string DNI = txtDNIC.Text;
                bool aptoF = aptoFisico;
                Console.WriteLine(aptoFisico);
                if (tipoCliente.ToLower() == "socio") {
                    cliente = new E_Socio(nombre, apellido, DNI, tel, correo, tipoCliente,aptoF, true);
                }
                else {
                    cliente = new E_No_Socio(nombre, apellido, DNI, tel, correo, tipoCliente,aptoF, true);
                }

                // instanciamos para usar el método dentro de clientes
                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(cliente);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero) {
                    if (codigo == 1) {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Se almacenó con éxito con el codigo Nro  " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCasillas();
                    }
                }
            }
        }

        private void btnVolverRegC_Click(object sender, EventArgs e)
        {
            // Permite retornar al formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void rdoSi_CheckedChanged(object sender, EventArgs e)
        {
            aptoFisico = true;
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            aptoFisico = false;
        }

        private bool validarRButtons() 
        {
            return rdoSi.Checked || rdoNo.Checked;
        }

        private void limpiarCasillas()
        {
            txtNombreC.Text = "";
            txtApellidoC.Text = "";
            txtTelC.Text = "";
            txtCorreoC.Text = "";
            txtDNIC.Text = "";
            cboTipoC.Text = "";
            rdoSi.Checked = false;
            rdoNo.Checked = false;
            txtNombreC.Focus();
        }
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmClientes listaClientes = new frmClientes();
            listaClientes.Show();
            this.Hide();
        }
    }
}
