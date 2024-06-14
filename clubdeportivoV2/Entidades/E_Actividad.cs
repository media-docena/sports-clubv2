using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Entidades
{
    public class E_Actividad
    {
        public int Id { get; }
        public string Nombre { get; }
        public int CupoMax { get; }
        public int CupoDisp { get; private set; }
        public double Precio { get; }
        public bool? Estado { get; set; }
        public List<E_Cliente> Inscriptos { get; } = new List<E_Cliente>();

        public E_Actividad(int id, string nombre, int cupoMax, int cupoDisp, double precio, bool? estado = null)
        {
            Id = id;
            Nombre = nombre;
            CupoMax = cupoMax;
            CupoDisp = cupoDisp;
            Precio = precio;
            Estado = estado;
        }

        public void agregarInscripto(E_Cliente cliente) 
        {
            Inscriptos.Add(cliente);
        }

        public void restarCupo()
        {
            if(CupoDisp > 0) {
                CupoDisp -= 1;
            }     
        }
    }
}
