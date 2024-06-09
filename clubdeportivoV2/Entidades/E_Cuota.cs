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
        public double Monto { get; }
        public int IdCliente { get; }
        public string FormaPago { get; }
        public DateTime FechaVencimiento { get; }
        public string Detalle { get; }

        public E_Cuota(DateTime fecha, double monto, int idCliente, string formaPago, DateTime fechaVencimiento, string detalle, int? id = null)
        {
            Fecha = fecha;
            Monto = monto;
            IdCliente = idCliente;
            FormaPago = formaPago;
            FechaVencimiento = fechaVencimiento;
            Detalle = detalle;
            Id = id;
        }
    }
}
