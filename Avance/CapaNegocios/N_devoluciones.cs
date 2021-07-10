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
    public class N_devoluciones
    {
        readonly D_devoluciones ObjDevolucion = new D_devoluciones();

        public static DataTable MostrarRegistros()
        {
            return new D_devoluciones().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_devoluciones().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_devoluciones devoluciones)
        {
            ObjDevolucion.InsertarRegistros(devoluciones);
        }

        public void EditarRegistros(E_devoluciones devoluciones)
        {
            ObjDevolucion.EditarRegistros(devoluciones);
        }
        public void EliminarRegistros(E_devoluciones devoluciones)
        {
            ObjDevolucion.EliminarRegistros(devoluciones);
        }
    }
}
