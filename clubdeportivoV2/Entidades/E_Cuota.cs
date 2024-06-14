using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Entidades
{
    public class E_Cuota
    {
        public int? Id { get; }
        public DateTime Fecha { get; }
        public double Monto { get; set; }
        public int IdCliente { get; set; }
        public string FormaPago { get; }
        public DateTime FechaVencimiento { get; }
        public bool TienePromo { get; }
        public string Detalle { get; }

        public E_Cuota(DateTime fecha, double monto, int idCliente, string formaPago, DateTime fechaVencimiento, bool tienePromo, string detalle, int? id = null)
        {
            Fecha = fecha;
            Monto = monto;
            IdCliente = idCliente;
            FormaPago = formaPago;
            FechaVencimiento = fechaVencimiento;
            TienePromo = tienePromo;
            Detalle = detalle;
            Id = id;
        }

        private void calcDescuento3Cuotas()
        {
            // Calculamos el descuento de 5% por 3 cuotas
            double descuento = 0.95;
            Monto *= descuento;
        }

        private void calcDescuento6Cuotas()
        {
            // Calculamos el descuento de 10% por 6 cuotas
            double descuento = 0.90;
            Monto *= descuento;
        }

        public void aplicarPromocion(int cantCuotas)
        {
            if(FormaPago.Equals("Tarjeta de crédito") && TienePromo && cantCuotas == 3) 
            {
                calcDescuento3Cuotas();
                return;
            }

            if (FormaPago.Equals("Tarjeta de crédito") && TienePromo && cantCuotas == 6) {
                calcDescuento6Cuotas();
                return;
            }
        }
    }
}
