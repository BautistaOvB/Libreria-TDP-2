using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string Cuit { get; set; }
        public string nombre { get; set; }
        public string Direccion { get; set; }
        public string telefono { get; set; }

    }
}
