using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaProducto;

namespace CapaProducto
{
    public class Producto

    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarProducto()
        {
            DataTable conexion = new DataTable();
            SqlCommand SqlPrueba = new SqlCommand("Producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter Sqlset = new SqlDataAdapter(SqlCmd);
            set.Fill(DtResultado);

            return DtResultado;
        }
        public DataTable BuscarProducto(string textobuscar)
        {
            DataTable conexion = new DataTable();
            SqlCommand SqlPrueba = new SqlCommand("buscar_Producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter sqlset = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return conexion;
        }

        public void InsertarProducto(E_producto producto)
        {
            SqlCommand SqlPrueba = new SqlCommand("insertarDetalleProducto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
;
            SqlPrueba.Parameters.AddWithValue("@CodigoProducto", producto.codigoProducto);
            SqlPrueba.Parameters.AddWithValue("@Producto", producto.producto);
            SqlPrueba.Parameters.AddWithValue("@Descripcion", producto.descripcion);
            SqlPrueba.Parameters.AddWithValue("@Existencia", producto.descrpcion);
            SqlPrueba.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarProducto(E_producto producto)
        {

            SqlCommand SqlPrueba = new SqlCommand("editar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlPrueba.Parameters.AddWithValue("@No_factura", factura.No_factura);
            SqlPrueba.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
            SqlPrueba.Parameters.AddWithValue("@No_factura", factura.No_factura);
            SqlPrueba.Parameters.AddWithValue("@fecha", factura.fecha);
            SqlPrueba.Parameters.AddWithValue("@cod_termino", factura.cod_termino);
            SqlPrueba.Parameters.AddWithValue("@cod_empleado", factura.cod_empleado);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarProducto(E_producto producto)
        {
            SqlCommand SqlPrueba = new SqlCommand("eliminar_producto", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@No_producto", factura.No_factura);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
   
