using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Entidades
{
    public class E_No_Socio : E_Cliente
    {
        public E_No_Socio(string nombreC, string apellidoC, string dniC, string telC,
                          string correoC, string tipoC, bool aptoFisico, bool estadoC, int? idCliente = null) : base(nombreC,
                          apellidoC, dniC, telC, correoC, tipoC, aptoFisico, estadoC, idCliente)
        { }
    }
}
