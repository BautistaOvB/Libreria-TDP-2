using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaVenta { get; set; }
        public decimal totalVenta { get; set; }
        public int codMetodoPago { get; set; }
    }
}
