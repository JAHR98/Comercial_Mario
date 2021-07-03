using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;
using CapaEntidades;
namespace CapaNegocios
{
   public class N_proveedor
    {
        readonly D_proveedor ObjProveedor = new D_proveedor();

        public static DataTable MostrarRegistros()
        {
            return new D_proveedor().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_proveedor().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_proveedor proveedor)
        {
            ObjProveedor.InsertarRegistros(proveedor);
        }

        public void EditarRegistros(E_proveedor proveedor)
        {
            ObjProveedor.EditarRegistros(proveedor);
        }
        public void EliminarRegistros(E_proveedor proveedor)
        {
            ObjProveedor.EliminarRegistros(proveedor);
        }
    }
}
