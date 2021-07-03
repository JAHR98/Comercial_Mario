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
    public class D_proveedor
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_proveedor", conectar)
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
            SqlCommand SqlCmd = new SqlCommand("buscar_proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);
           
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistros(E_proveedor provedor)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@rtn_proveedor", provedor.rtn_proveedor);
            SqlCmd.Parameters.AddWithValue("@nombre_proveedor", provedor.nombre_proveedor);
            SqlCmd.Parameters.AddWithValue("@direccion", provedor.direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", provedor.telefono);
           

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(E_proveedor provedor)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_proveedor", provedor.id_proveedor);
            SqlCmd.Parameters.AddWithValue("@rtn_proveedor", provedor.rtn_proveedor);
            SqlCmd.Parameters.AddWithValue("@nombre_proveedor", provedor.nombre_proveedor);
            SqlCmd.Parameters.AddWithValue("@direccion", provedor.direccion);
            SqlCmd.Parameters.AddWithValue("@telefono", provedor.telefono);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_proveedor proveedor)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_proveedor", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@id_proveedor", proveedor.id_proveedor);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
