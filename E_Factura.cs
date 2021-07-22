using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_factura
    {

        public int No_factura { get; set; }
        public string fecha { get; set; }

        public int cod_termino{ get; set; }
   
        public string id_cliente { get; set; }
        public int cod_empleado { get; set; }

        public string id_producto { get; set; }

        public int cantidad { get; set; }
        public string precio_venta { get; set; }

        public int precio_unitario { get; set; }

        public string importe { get; set; }
        public int ISV { get; set; }

        public string subtotal { get; set; }
        public int total { get; set; }
    }
}
