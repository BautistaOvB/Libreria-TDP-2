using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class Libro
    {
        public int id_libro { get; set; }
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public int cod_genero { get; set; }
        public string nombre_genero { get; set; }
    }
}