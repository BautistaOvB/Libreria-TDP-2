using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set; }
        public string mail { get; set; }
        public string password_hash { get; set; }
        public string username { get; set; }
        public int id_rol { get; set; }
        public string nombre_rol { get; set; } = string.Empty;
    }
}