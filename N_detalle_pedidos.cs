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
    public class N_detalle_pedidos
    {
        readonly D_detalle_pedidos Objdetalle_pedidos = new D_detalle_pedidos();

        public static DataTable MostrarRegistros()
        {
            return new D_detalle_pedidos().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_detalle_pedidos().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_detalle_pedidos detalle_pedidos)
        {
            Objdetalle_pedidos.InsertarRegistros(detalle_pedidos);
        }

        public void EditarRegistros(E_detalle_pedidos detalle_pedidos)
        {
            Objdetalle_pedidos.EditarRegistros(detalle_pedidos);
        }
        public void EliminarRegistros(E_detalle_pedidos detalle_pedidos)
        {
            Objdetalle_pedidos.EliminarRegistros(detalle_pedidos);
        }
    }
}
