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
    public class D_detalle_factura
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_detalle_factura", conectar)
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
            SqlCommand SqlCmd = new SqlCommand("buscar_detalle_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

            return DtResultado;
        }

        public void InsertarRegistros(E_detalle_factura detalle_factura)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_detalle_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@No_factura", detalle_factura.No_factura);
            SqlCmd.Parameters.AddWithValue("@id_producto", detalle_factura.id_producto);
            SqlCmd.Parameters.AddWithValue("@cantidad", detalle_factura.cantidad);
            SqlCmd.Parameters.AddWithValue("@precio_venta", detalle_factura.precio_venta);
            SqlCmd.Parameters.AddWithValue("@precio_unitario", detalle_factura.precio_unitario);
            SqlCmd.Parameters.AddWithValue("@importe", detalle_factura.importe);
            SqlCmd.Parameters.AddWithValue("@ISV", detalle_factura.ISV);
            SqlCmd.Parameters.AddWithValue("@Subtotal", detalle_factura.subtotal);
            SqlCmd.Parameters.AddWithValue("@Total", detalle_factura.total);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EditarRegistros(E_detalle_factura detalle_factura)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_detalle_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@No_factura", detalle_factura.No_factura);
            SqlCmd.Parameters.AddWithValue("@id_producto", detalle_factura.id_producto);
            SqlCmd.Parameters.AddWithValue("@cantidad", detalle_factura.cantidad);
            SqlCmd.Parameters.AddWithValue("@precio_venta", detalle_factura.precio_venta);
            SqlCmd.Parameters.AddWithValue("@precio_unitario", detalle_factura.precio_unitario);
            SqlCmd.Parameters.AddWithValue("@importe", detalle_factura.importe);
            SqlCmd.Parameters.AddWithValue("@ISV", detalle_factura.ISV);
            SqlCmd.Parameters.AddWithValue("@Subtotal", detalle_factura.subtotal);
            SqlCmd.Parameters.AddWithValue("@Total", detalle_factura.total);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
        public void EliminarRegistros(E_detalle_factura detalle_factura)
        {
            SqlCommand SqlCmd = new SqlCommand("eliminar_detalle_factura", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            SqlCmd.Parameters.AddWithValue("@id_producto", detalle_factura.id_producto);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}

    
