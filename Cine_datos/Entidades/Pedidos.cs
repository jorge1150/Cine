using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_datos
{
    public class Pedidos
    {
        private int idPedido { get; set; }
        private int idPelicula { get; set; }
        private int idProveedor { get; set; }
        private string numeroPedido { get; set; }
        private int cantidadPedido { get; set; }
        private DateTime fechaPedido { get; set; }
        private string estadoPedido { get; set; }
    }
}
