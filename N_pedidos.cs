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
    public class N_pedidos
    {
        readonly D_pedidos Objpedidos = new D_pedidos();

        public static DataTable MostrarRegistros()
        {
            return new D_pedidos().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_pedidos().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_pedidos pedidos)
        {
            Objpedidos.InsertarRegistros(pedidos);
        }

        public void EditarRegistros(E_pedidos pedidos)
        {
            Objpedidos.EditarRegistros(pedidos);
        }
        public void EliminarRegistros(E_pedidos pedidos)
        {
            Objpedidos.EliminarRegistros(pedidos);
        }
    }
}
