using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_producto
    {
        public int cod_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion { get; set; }
        public int precio_actual { get; set; }
        public int existencia { get; set; }
        public string marca_producto { get; set; }
        public int id_proveedor1 { get; set; }
        public int id_proveedor2 { get; set; }
    }
}
