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
    public class D_producto
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        public DataTable MostrarRegistros2(int id_proveedor)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_productocod", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlCmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
        public DataTable BuscarRegistros(string textobuscar)
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("buscar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }
      

        public void InsertarRegistros(E_producto producto)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            
            SqlCmd.Parameters.AddWithValue("@cod_producto", producto.cod_producto);
            SqlCmd.Parameters.AddWithValue("@nombre_producto", producto.nombre_producto);
            SqlCmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
            SqlCmd.Parameters.AddWithValue("@precio_actual", producto.precio_actual);
            SqlCmd.Parameters.AddWithValue("@existencia", producto.existencia);
            SqlCmd.Parameters.AddWithValue("@marca_producto", producto.marca_producto);
            SqlCmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor1);
            SqlCmd.Parameters.AddWithValue("@id_proveedor2", producto.id_proveedor2);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(E_producto producto)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@cod_producto", producto.cod_producto);
            SqlCmd.Parameters.AddWithValue("@nombre_producto", producto.nombre_producto);
            SqlCmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
            SqlCmd.Parameters.AddWithValue("@precio_actual", producto.precio_actual);
            SqlCmd.Parameters.AddWithValue("@existencia", producto.existencia);
            SqlCmd.Parameters.AddWithValue("@marca_producto", producto.marca_producto);
            SqlCmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor1);
            SqlCmd.Parameters.AddWithValue("@id_proveedor2", producto.id_proveedor2);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_producto producto)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@cod_producto", producto.cod_producto);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
