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
using System.Drawing.Printing;

namespace clubdeportivoV2
{
    public partial class frmFactura : Form
    {
        public E_Cuota cuota;
        public E_Cliente cliente;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            /* ---------------------------------------
             * asignación de los valores a los datos
             * que muestra cada etiqueta del diseño
             * del comprobante de pago
             * ---------------------------------------------*/

            lblClienteIdF.Text = cliente.IdCliente.HasValue ? cliente.IdCliente.Value.ToString() : "N/A";
            lblFechaF.Text = cuota.Fecha.ToString("dd/MM/yyyy");
            lblFVenc.Text = cuota.FechaVencimiento.ToString("dd/MM/yyyy");
            lblFormaP.Text = cuota.FormaPago;
            lblNomCompleto.Text = cliente.NombreC + ' ' + cliente.ApellidoC;
            lblSuma.Text = cuota.Monto.ToString() + " pesos argentinos";
            lblConceptoF.Text = cuota.Detalle.Equals("") ? "N/A" : cuota.Detalle;
            lblTotal.Text = cuota.Monto.ToString();
        }

        private void btnVolverRegC_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();

        }

        private void printFactura_PrintPage(object sender, PrintPageEventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          /* ----------------------------------------------------
           *   Ocultamos los botones que no pertenecen al diseño 
           *   pero si para la funcionalidad
           *   Usamos la propiedad VISIBLE 
           * ----------------------------------------------------*/
             btnImprimir.Visible = false;
          /* -----------------------------------------
           *  creamos los objetos para la impresion
           * ------------------------------------------*/
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printFactura_PrintPage);
            pd.Print();
            btnImprimir.Visible = true; // visualizamos nuevamente el objeto.

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }
    }
}
