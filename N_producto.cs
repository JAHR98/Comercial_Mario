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
   public class N_producto
    {
        readonly D_producto ObjProducto = new D_producto();

        public static DataTable MostrarRegistros()
        {
            return new D_producto().MostrarRegistros();
        }
        public static DataTable MostrarRegistros2(int id_proveedor)
        {
            return new D_producto().MostrarRegistros2(id_proveedor);
        }
        

        public void MostrarInformacion(int cod_producto)
        {
             ObjProducto.MostrarInformacion(cod_producto);
        }
        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_producto().BuscarRegistros(textobuscar);
        }

        public void InsertarRegistros(E_producto producto)
        {
            ObjProducto.InsertarRegistros(producto);
        }

        public void EditarRegistros(E_producto producto)
        {
            ObjProducto.EditarRegistros(producto);
        }
        public void EliminarRegistros(E_producto producto)
        {
            ObjProducto.EliminarRegistros(producto);
        }
    }
}
