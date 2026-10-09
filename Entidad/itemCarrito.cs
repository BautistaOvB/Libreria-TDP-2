using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class ItemCarrito
    {
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Libro.Precio * Cantidad;
    }
}