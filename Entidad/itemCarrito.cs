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
        public decimal Subtotal
        {
            get { return Cantidad * Libro.Precio; }
        }

        // El PrecioUnitario se obtiene directo del Libro
        public decimal PrecioUnitario
        {
            get { return Libro.Precio; }
        }
        
        
    }
}