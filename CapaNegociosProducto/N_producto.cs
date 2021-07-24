using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaProducto;
using CapaProdutos;

namespace CapaProducto;
{
    public class N_Producto
    {
        readonly D_producto ObjProducto = new D_producto();

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
            ObjProducto.InsertarProducto(producto);
        }

        public void EditarProducto(E_producto producto)
        {
            ObjProducto.EditarProducto(producto);
        }
        public void EliminarProducto(E_producto producto)
        {
            ObjProducto.EliminarProducto(producto);
        }
    }
}

  
