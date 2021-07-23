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
    public class N_detalle_factura
    {
        readonly D_detalle_factura Objdetalle_factura = new D_detalle_factura();

        public static DataTable MostrarRegistros()
        {
            return new D_detalle_factura().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_detalle_factura().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_detalle_factura detalle_factura)
        {
            Objdetalle_factura.InsertarRegistros(detalle_factura);
        }

        public void EditarRegistros(E_detalle_factura detalle_factura)
        {
            Objdetalle_factura.EditarRegistros(detalle_factura);
        }
        public void EliminarRegistros(E_detalle_factura detalle_factura)
        {
            Objdetalle_factura.EliminarRegistros(detalle_factura);
        }
    }
}

