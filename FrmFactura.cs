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
    public partial class FrmFactura : Form
    {
        readonly E_factura ObjEntidad = new E_factura();
        readonly N_factura ObjNegocios = new N_factura();
        public FrmFactura()
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

        private void FrmFactura_Load(object sender, EventArgs e)
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

                        ObjEntidad.cod_termino = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_producto = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.no_factura = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.fecha_factura = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_cliente = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.cod_empleado = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.cantidad = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.precio_venta = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.precio_unitario = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.importe = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.ISV = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.subtotal = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.total = Convert.ToDateTime(tbproveedor.Text.ToUpper());

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
                        ObjEntidad.cod_termino = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_producto = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.no_factura = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.fecha_factura = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.id_cliente = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.cod_empleado = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.cantidad = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.precio_venta = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.precio_unitario = Convert.ToInt32(tbproveedor.Text.ToUpper());
                        ObjEntidad.importe = Convert.ToInt32(tbCProducto.Text.ToUpper());
                        ObjEntidad.ISV = Convert.ToInt32(tbProduct.Text.ToUpper());
                        ObjEntidad.subtotal = Convert.ToDateTime(tbproveedor.Text.ToUpper());
                        ObjEntidad.total = Convert.ToDateTime(tbproveedor.Text.ToUpper());

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
