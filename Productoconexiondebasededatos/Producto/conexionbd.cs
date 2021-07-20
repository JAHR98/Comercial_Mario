using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Producto
{
	class conexionbd
	{
		string cadena = "Data Source = DESKTOP\\Q98IL6V;Initial Catalog=Proyecto;Integrated Security = True";

		public SqlConnection conectarbd = new SqlConnection();

		public conexionbd()
		{
			conectarbd.ConnectionString = cadena;
		}

		public void abrir()
		{
			try
			{
				conectarbd.Open();
				Console.WriteLine("Conexion abierta");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al abrir la BD" + ex.Message);
			}


		}
		public void cerrar()
		{
			conectarbd.Close();
		}
	}
}
