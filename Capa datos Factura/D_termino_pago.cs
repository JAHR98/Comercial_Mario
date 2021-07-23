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
    public class D_termino_pago
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_termino_pago", conectar)
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
            SqlCommand SqlCmd = new SqlCommand("buscar_termino_pago", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void EditarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InsertarRegistros(E_termino_pago termino_pago)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_termino_pago", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@cod_termino", termino_pago.cod_termino);
            SqlCmd.Parameters.AddWithValue("@descripcion", termino_pago.descripcion);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(E_termino_pago termino_pago)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_termino_pago", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@cod_termino", termino_pago.cod_termino);
            SqlCmd.Parameters.AddWithValue("@descripcion", termino_pago.descripcion);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_termino_pago termino_pago)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_termino_pago", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@cod_termino", termino_pago.cod_termino);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
    
