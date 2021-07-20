using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Producto
{
	public partial class Producto : Form
	{
	
		public Producto()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{


			DialogResult salir = MessageBox.Show("¿Desea salir del Progroma?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (salir == DialogResult.Yes)
			{
				this.Close();
			}

		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{

			AgregarProducto agregarP = new AgregarProducto();
			agregarP.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			NuevaDevolución devo = new NuevaDevolución();
			devo.Show();

		}

		private void Producto_Load(object sender, EventArgs e)
		{
			conexionbd prueba = new conexionbd();
			prueba.abrir();
		}
	}
}
