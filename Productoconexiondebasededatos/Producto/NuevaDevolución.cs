using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
	public partial class NuevaDevolución : Form
	{
		public NuevaDevolución()
		{
			InitializeComponent();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			
			DialogResult volver = MessageBox.Show("¿Desea volver al formulario principal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (volver == DialogResult.Yes)
			{
				Producto prod = new Producto();
				prod.Show();
				this.Close();
			}
			
		}
	}
}
