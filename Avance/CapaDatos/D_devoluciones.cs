using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using CapaEntidades;

namespace CapaDatos
{
    public class D_devoluciones
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

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistros(E_devoluciones devoluciones)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@fecha_devolucion", devoluciones.fecha_devolucion);
            SqlCmd.Parameters.AddWithValue("@id_producto", devoluciones.id_producto);
            SqlCmd.Parameters.AddWithValue("@id_devolucion", devoluciones.id_devolucion);
            SqlCmd.Parameters.AddWithValue("@id_proveedor", devoluciones.id_proveedor);
            SqlCmd.Parameters.AddWithValue("@cod_empleado", devoluciones.cod_empleado);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistros(E_devoluciones devoluciones)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@fecha_devolucion", devoluciones.fecha_devolucion);
            SqlCmd.Parameters.AddWithValue("@id_producto", devoluciones.id_producto);
            SqlCmd.Parameters.AddWithValue("@id_devolucion", devoluciones.id_devolucion);
            SqlCmd.Parameters.AddWithValue("@id_proveedor", devoluciones.id_proveedor);
            SqlCmd.Parameters.AddWithValue("@cod_empleado", devoluciones.cod_empleado);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_devoluciones devoluciones)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_devolucion", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@fecha_devolucion", devoluciones.fecha_devolucion);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

    }
}
