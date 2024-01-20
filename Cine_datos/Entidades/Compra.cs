using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_datos
{
    public class Compra
    {
        private int idCompra { get; set; }
        private int idCliente { get; set; }
        private string codigoCompra { get; set; }
        private DateTime fechaCompra { get; set; }
        private int numeroEntradasCompra { get; set; }
        private decimal valorTotalCompra { get; set; }
        private string estadoCompra { get; set; }
    }
}
