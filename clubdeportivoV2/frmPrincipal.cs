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
    public partial class frmPrincipal : Form
    {
        internal string rol = Datos.Sesion.Rol;
        internal string usuario = Datos.Sesion.Usuario;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalirNav_Click(object sender, EventArgs e)
        {
            // Cierra la ventana de la aplicación
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            // Al hacer click en el botón registrar cliente pasamos
            // a su formulario y ocultamos la ventana principal del menú
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
