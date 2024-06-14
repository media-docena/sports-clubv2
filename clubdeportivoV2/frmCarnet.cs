using clubdeportivoV2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubdeportivoV2
{
    public partial class frmCarnet : Form
    {
        public E_Cliente cliente;
        public frmCarnet()
        {
            InitializeComponent();
        }

        private void printCarnet_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            /* ----------------------------------------------------
           *   Ocultamos los botones que no pertenecen al diseño 
           *   pero si para la funcionalidad
           *   Usamos la propiedad VISIBLE 
           * ----------------------------------------------------*/
            btnImprimirCarnet.Visible = false;
            /* -----------------------------------------
             *  creamos los objetos para la impresion
             * ------------------------------------------*/
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printCarnet_PrintPage);
            pd.Print();
            btnImprimirCarnet.Visible = true; // visualizamos nuevamente el objeto.

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            /* ---------------------------------------
             * asignación de los valores a los datos
             * que muestra cada etiqueta del diseño
             * del carnet
             * ---------------------------------------------*/

            lblNumSocio.Text = cliente.IdCliente.ToString();
            lblTemporada.Text = DateTime.Now.ToString("yyyy");
            lblNombre.Text = cliente.NombreC;
            lblApellido.Text = cliente.ApellidoC;
        }
    }
}
