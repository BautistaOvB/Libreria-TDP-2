using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Compra
    {
        public int id_compra { get; set; }
        public DateTime fecha_compra { get; set; }
        public decimal total_compra { get; set; }
        public int id_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
    }
}
