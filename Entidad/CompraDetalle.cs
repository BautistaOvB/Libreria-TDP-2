using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class CompraDetalle
    {
        public int id_detalle_compra { get; set; }
        public int id_compra { get; set; }
        public int id_libro { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }
        public string nombre_libro { get; set; }
        public string isbn_libro { get; set; }
    }
}
