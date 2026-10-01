using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Venta
    {
        public int id_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal total_venta { get; set; }
        public int id_metodo { get; set; }
        public int id_usuario { get; set; }

        // Campos del JOIN
        public string nombre_metodo { get; set; }
        public string nombre_usuario { get; set; }
    }


}