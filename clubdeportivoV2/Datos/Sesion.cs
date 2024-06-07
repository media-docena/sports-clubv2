using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Datos
{
    public static class Sesion
    {
        /*
         Esta clase y sus atributos permiten que tengamos acceso global
         al usuario logueado que maneja el sistema del club
         */
        public static string Usuario { get; set; }
        public static string Rol { get; set; }
    }
}
