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
    public class N_termino_pago
    {
        readonly D_termino_pago Objtermino_pago = new D_termino_pago();

        public static DataTable MostrarRegistros()
        {
            return new D_termino_pago().MostrarRegistros();
        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_termino_pago().BuscarRegistros(textobuscar);
        }
        public void InsertarRegistros(E_termino_pago termino_pago)
        {
            Objtermino_pago.InsertarRegistros(termino_pago);
        }

        public void EditarRegistros(E_termino_pago termino_pago)
        {
            Objtermino_pago.EditarRegistros();
        }
        public void EliminarRegistros(E_termino_pago termino_pago)
        {
            Objtermino_pago.EliminarRegistros(termino_pago);
        }
    }
}