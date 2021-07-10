using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_devoluciones
    {
        public DateTime fecha_devolucion { get; set; }
        public int id_producto { get; set; }
        public int id_devolucion { get; set; }
        public int id_proveedor { get; set; }
        public int cod_empleado { get; set; }
    }
}
