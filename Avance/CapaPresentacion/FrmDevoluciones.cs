using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaEntidades;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FrmDevoluciones : Form
    {
        readonly E_devoluciones ObjEntidad = new E_devoluciones();
        readonly N_devoluciones ObjNegocios = new N_devoluciones();
        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje + " " + ObjEntidad.id_producto, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCajas()
        {
            tbproveedor.Text = "";
            tbrtn.Text = "";
            tbCProducto .Text = "";
            tbProduct .Text = "";
            dtpFecha .Text = "";

        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProducto_Click(object sender, EventArgs e)
        {

        }

        private void lbProv_Click(object sender, EventArgs e)
        {

        }

        private void lbProd_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbrtn.Text.Trim() != "" && tbproveedor.Text.Trim() != "" && tbCProducto.Text.Trim() != "")
            {
                if (Program.Evento == 0)
                {
                    try
                    {

                        ObjEntidad.id_proveedor = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_producto = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.id_devolucion = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.fecha_devolucion = Convert.ToDateTime(tbproveedor.Text.ToUpper());

                        ObjNegocios.InsertarRegistros(ObjEntidad);

                        MensajeConfirmacion("Se Inserto Correctamente");
                        Program.Evento = 0;
                        LimpiarCajas();
                        Close();
                    }
                    catch (Exception)
                    {

                        MensajeError("No se Pudo Insertar la Devolucion");
                        Close();
                    }
                }
                else
                {
                    try
                    {
                        ObjEntidad.id_proveedor = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_producto = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.id_devolucion = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.fecha_devolucion = Convert.ToDateTime(tbproveedor.Text.ToUpper());

                        ObjNegocios.EditarRegistros(ObjEntidad);
                        MensajeConfirmacion("Se Modifico Correctamente");
                        Program.Evento = 0;
                        LimpiarCajas();
                        Close();

                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Editar la Devolucion");
                     
                    }
                }
            }
            else
            {
                MensajeError("Llene los campos correspondientes para guardar correctamente");
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
    }
}
