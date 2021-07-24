using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devoluciones
{
    public partial class frmdevolucion : Form
    {
        public frmdevolucion()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
             frmNdevolucion form2 = new frmNdevolucion();
            this.Hide();
            form2.ShowDialog();
            this.Show();
            
        }

        private void frmdevolucion_Load(object sender, EventArgs e)
        {

        }
    }
}
