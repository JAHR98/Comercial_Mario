using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_detalle_pedidos
    {
        public int id_pedido { get; set; }
        public string id_producto { get; set; }
        public string fecha_pedido { get; set; }
        public int fecha_entrega { get; set; }
        public string precio_compre { get; set; }
        public string cantidad { get; set; }
        public string estado { get; set; }
    }
}
