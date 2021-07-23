using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaProducto;
using CapaProdutos;

namespace CapaProductoInv;
{
    public class N_Producto
    {
        readonly D_producto Objfactura = new D_producto();

        public static DataTable MostrarProducto()
        {
            return new D_producto().MostrarProducto();
        }

        public static DataTable BuscarProducto(string textobuscar)
        {
            return new D_producto().BuscarProducto(textobuscar);
        }
        public void InsertarProducto(E_producto producto)
        {
            Objfactura.InsertarProducto(producto);
        }

        public void EditarProducto(E_producto producto)
        {
            Objfactura.EditarProducto(producto);
        }
        public void EliminarProducto(E_producto producto)
        {
            Objfactura.EliminarProducto(producto);
        }
    }
}

  
