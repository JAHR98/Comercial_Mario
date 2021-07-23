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
    public class D_factura
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_factura", conectar)
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
            SqlCommand SqlCmd = new SqlCommand("buscar_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistros(E_factura factura)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@No_factura", factura.No_factura);
            SqlCmd.Parameters.AddWithValue("@fecha", factura.fecha);
            SqlCmd.Parameters.AddWithValue("@cod_termino", factura.cod_termino);
            SqlCmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
            SqlCmd.Parameters.AddWithValue("@cod_empleado", factura.cod_empleado);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(E_factura factura)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();


            SqlCmd.Parameters.AddWithValue("@No_factura", factura.No_factura);
            SqlCmd.Parameters.AddWithValue("@fecha", factura.fecha);
            SqlCmd.Parameters.AddWithValue("@cod_termino", factura.cod_termino);
            SqlCmd.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
            SqlCmd.Parameters.AddWithValue("@cod_empleado", factura.cod_empleado);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_factura factura)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@id_producto", factura.id_producto);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
