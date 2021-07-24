using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capaDatos;
using capaentidad;

namespace capaNegocio
{
    public class n_devolucion
    {
        readonly d_devoluciones ObjDevolucion = new d_devoluciones();
    }
    public static DataTable MostrarRegistros() {
        return new d_devoluciones().MostrarRegistros();

    }

    public static DataTable BuscarRegistros()
    {
        return new d_devoluciones().BuscarRegistros(txtbuscar);

    }

    public static DataTable insertarRegistros(edevoluciones devoluciones)
    {
        ObjDevolucion.insertarRegistros(devoluciones);

    }

    public void EditarRegistros(edevoluciones devoluciones)
    {
        ObjDevolucion.EditarRegistros(devoluciones);
    }

    public void EliminarRegistros(edevoluciones devoluciones)
    {
        ObjDevolucion.EliminarRegistros(devoluciones);
    }

}

}
