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
    }
}
