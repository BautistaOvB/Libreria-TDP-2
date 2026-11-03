using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class MetodoPago
    {
        public int id_metodo { get; set; }
        public string nombre { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
}

