using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Libreria.Entidad
{
    public class VentaPorVendedor
    {
        public string NombreVendedor { get; set; }
        public decimal TotalVendido { get; set; }
    }

    public class VentaPorCategoria
    {
        public string Categoria { get; set; }
        public decimal TotalVendido { get; set; }
    }

    public class ProductoMasVendido
    {
        public string Categoria { get; set; }
        public string NombreLibro { get; set; }
        public int CantidadVendida { get; set; }
    }
}
