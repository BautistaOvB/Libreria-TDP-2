using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public string numero_telefono { get; set; }

    }
}
