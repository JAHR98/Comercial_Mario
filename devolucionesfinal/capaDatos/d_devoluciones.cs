using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using capaentidad;

namespace capaDatos
{
    public class d_devoluciones
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        public DataTable BuscarRegistros(string textobuscar)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("buscar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@txtbuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistros(edevoluciones devolucion)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_proveedor", devolucion.id_proveedor);
            SqlCmd.Parameters.AddWithValue("@cod_producto", devolucion.cod_producto);
            SqlCmd.Parameters.AddWithValue("@nombre_producto", devolucion.nombre_producto);
            SqlCmd.Parameters.AddWithValue("@fecha", devolucion.fecha);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(edevoluciones devoluciones)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_proveedor", devoluciones.id_proveedor);
            SqlCmd.Parameters.AddWithValue("@cod_producto", devoluciones.cod_producto);
            SqlCmd.Parameters.AddWithValue("@nombre_producto", devoluciones.nombre_producto);
            SqlCmd.Parameters.AddWithValue("@fecha", devoluciones.fecha);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(edevoluciones devolucion)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@fecha", devolucion.id_proveedor);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }


}
}
