using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaProveedor;
using CapaProveedor;

namespace CapaProveedor;
{
    public class N_Proveedor
{
        readonly D_proveedor Objproveedor = new D_proveedor();

        public static DataTable MostrarProveedor()
        {
            return new D_proveedor().MostrarProveedor();
        }

        public static DataTable BuscarProveedor(string textobuscar)
        {
            return new D_proveedor().BuscarProveedor(textobuscar);
        }
        public void InsertarProveedor(E_proveedor proveedor)
        {
            Objproveedor.InsertarProveedor(proveedor);
        }

        public void EditarProveedor(E_proveedor proveedor)
        {
            ObjProveedor.EditarProveedor(producto);
        }
        public void EliminarProveedor(E_producto proveedor)
        {
            Objproveedor.EliminarProveedor(proveedor);
        }
    }
}

  
