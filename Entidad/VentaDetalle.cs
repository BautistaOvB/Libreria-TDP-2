using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class VentaDetalle   // ✅ antes era internal → ahora public
    {
        public int id_detalle_venta { get; set; }
        public int id_venta { get; set; }
        public int id_libro { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }

        // Campos del JOIN
        public string ISBN { get; set; }
        public string nombre_libro { get; set; }
    }
}