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
    class D_detalle_pedido
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public void InsertarRegistros(E_detallepedido detallepedido)
        {
            SqlCommand SqlCmd = new SqlCommand("insertear_detalle_pedido", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_pedido", detallepedido.id_pedido);
            SqlCmd.Parameters.AddWithValue("@id_producto", detallepedido.id_producto);
            SqlCmd.Parameters.AddWithValue("@fecha_pedido", detallepedido.fecha_pedido);
            SqlCmd.Parameters.AddWithValue("@fecha_entrega", detallepedido.fecha_entrega);
            SqlCmd.Parameters.AddWithValue("@precio_compra", detallepedido.precio_compre);
            SqlCmd.Parameters.AddWithValue("@cantidad", detallepedido.cantidad);
            SqlCmd.Parameters.AddWithValue("@estado", detallepedido.estado);


            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EditarRegistros(E_detallepedido detallepedido)
        {

            SqlCommand SqlCmd = new SqlCommand("editar_detalle_pedidos", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_pedido", detallepedido.id_pedido);
            SqlCmd.Parameters.AddWithValue("@id_producto", detallepedido.id_producto);
            SqlCmd.Parameters.AddWithValue("@fecha_pedido", detallepedido.fecha_pedido);
            SqlCmd.Parameters.AddWithValue("@fecha_entrega", detallepedido.fecha_entrega);
            SqlCmd.Parameters.AddWithValue("@precio_compra", detallepedido.precio_compre);
            SqlCmd.Parameters.AddWithValue("@cantidad", detallepedido.cantidad);
            SqlCmd.Parameters.AddWithValue("@estado", detallepedido.estado);

            SqlCmd.ExecuteNonQuery();

            conectar.Close();
        }

    }
}
