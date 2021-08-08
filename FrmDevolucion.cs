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
    public partial class FrmDevolucion : Form
    {
        readonly E_factura ObjEntidad = new E_factura();
        readonly N_factura ObjNegocios = new N_factura();
        public FrmDevolucion()
        {
            InitializeComponent();
        }

       

        private void llenarCombobox()
        {


            cbProducto.ValueMember = "cod_producto";
            cbProducto.DisplayMember = "nombre_producto";
            cbProducto.DataSource = N_producto.MostrarRegistros();

        
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(NumCantidad.Text!=""&&NumCantidad.Value!=0)
            {
                try
                {
                    ObjEntidad.existencia = Convert.ToInt32(Convert.ToInt32(txtCantidad.Text) + NumCantidad.Value);
                    ObjEntidad.cod_producto = Convert.ToInt32(cbProducto.SelectedValue);
                    ObjEntidad.no_factura = Convert.ToInt32(lblNumFactura.Text);
                    ObjEntidad.cantidad = 0;
                    ObjNegocios.InsertarDevolucion(ObjEntidad);
                    MensajeConfirmacion("Se Devolvio Correctamente el producto");
                    Close();
                }
                catch (Exception)
                {

                    MensajeError("No se Pudo devolver la factura, porque el producto seleccionado no pertenece a esta factura");
                    Program.Cont = 0;
                    Close();
                }
               
            }
        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            llenarCombobox();
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void cargarDatosProducto()
        {          
                N_factura recuperacion = new N_factura();
                recuperacion.mostrarDatosProducto(Convert.ToInt32(cbProducto.SelectedValue));

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosProducto();
            txtCantidad.Text = E_precioProducto.existenciaProducto.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
