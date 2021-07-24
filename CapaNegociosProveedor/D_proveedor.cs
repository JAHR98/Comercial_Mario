using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaProveedor;

namespace CapaProveedor
{
    public class Proveedor

    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarProveedor()
        {
            DataTable conexion = new DataTable();
            SqlCommand SqlPrueba = new SqlCommand("Proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter Sqlset = new SqlDataAdapter(SqlCmd);
            set.Fill(DtResultado);

            return SqlPrueba;
        }
        public DataTable BuscarProveedor(string textobuscar)
        {
            DataTable conexion = new DataTable();
            SqlCommand SqlPrueba = new SqlCommand("buscar_Proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter sqlset = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return conexion;
        }

        public void InsertarProveedor(E_producto producto)
        {
            SqlCommand SqlPrueba = new SqlCommand("insertarDetalleProveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
;
            SqlPrueba.Parameters.AddWithValue("@CodigoProveedor", proveedor.codigoProveedor);
            SqlPrueba.Parameters.AddWithValue("@RTN", producto.RTN);
            SqlPrueba.Parameters.AddWithValue("@Telefono", producto.Telefono);
            SqlPrueba.Parameters.AddWithValue("@Descripcion", producto.descrpcion);
            SqlPrueba.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarProveedor(E_proveedor proveedor)
        {

            SqlCommand SqlPrueba = new SqlCommand("editar_proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlPrueba.Parameters.AddWithValue("@No_proveedor", proveedor.No_proveedor);
            SqlPrueba.Parameters.AddWithValue("@RTN", proveedor.RTN);
           


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarProveedor(E_proveedor proveedor)
        {
            SqlCommand SqlPrueba = new SqlCommand("eliminar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@No_proveedor", proveedor.No_proveedor);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
   
