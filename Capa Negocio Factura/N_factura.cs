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
    public class N_factura
    {
        readonly D_factura Objfactura = new D_factura();

        public static DataTable MostrarRegistros()
        {
            return new D_factura().MostrarRegistros();
        }
        public static DataTable MostrarRegistros2(int id_cliente)
        {
            return new D_factura().MostrarRegistros2(id_cliente);
        }


        public void MostrarInformacion(int cod_termino)
        {
            Objfactura.MostrarInformacion(cod_termino);
        }
        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_factura().BuscarRegistros(textobuscar);
        }

        public void InsertarRegistros(E_factura factura)
        {
            Objfactura.InsertarRegistros(factura);
        }

        public void EditarRegistros(E_factura factura)
        {
            Objfactura.EditarRegistros(factura);
        }
        public void EliminarRegistros(E_factura factura)
        {
            Objfactura.EliminarRegistros(factura);
        }
    }
}
