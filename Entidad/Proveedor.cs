using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string cuit { get; set; }
        public string nombre { get; set; }
        public string razon_social { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

    }
}
