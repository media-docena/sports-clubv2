using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Entidades
{
    public class E_Cliente
    {
        public int? IdCliente { get; }
        public string NombreC { get; }
        public string ApellidoC { get; }
        public string DniC { get; }
        public string TelC { get; }
        public string CorreoC { get; }
        public string TipoC { get; }
        public bool AptoFisico { get; set; }
        public bool EstadoC { get; }

        public E_Cliente(string nombreC, string apellidoC, string dniC,
            string telC, string correoC, string tipoC, bool aptoFisico, bool estadoC, int? idCliente = null)
        {
            NombreC = nombreC;
            ApellidoC = apellidoC;
            DniC = dniC;
            TelC = telC;
            CorreoC = correoC;
            TipoC = tipoC;
            AptoFisico = aptoFisico;
            EstadoC = estadoC;
            IdCliente = idCliente;
        }

        public virtual void abonar(E_Cuota cuota, int numCuotas) 
        {
            cuota.aplicarPromocion(numCuotas);
        }
    }
}
