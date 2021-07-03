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
    public partial class FrmProveedor : Form
    {
        readonly E_proveedor ObjEntidad = new E_proveedor();
        readonly N_proveedor ObjNegocios = new N_proveedor();
        public FrmProveedor()
        {
            InitializeComponent();
        }
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje + " " + ObjEntidad.nombre_proveedor.ToUpper(), "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCajas()
        {
            tbCodigo.Text = "";
            tbrtn.Text = "";
            tbnombre.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            
            tbCodigo.Focus();
        }

       

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (tbrtn.Text.Trim() != "" && tbnombre.Text.Trim() != "" && tbTelefono.Text.Trim() != "")
            {
                if (Program.Evento == 0)
                {
                    try
                    {

                        ObjEntidad.rtn_proveedor = tbrtn.Text.ToUpper();
                        ObjEntidad.nombre_proveedor=tbnombre.Text.ToUpper();
                        ObjEntidad.direccion = tbDireccion.Text.ToUpper();
                        ObjEntidad.telefono = tbTelefono.Text.ToUpper();
                    
                        ObjNegocios.InsertarRegistros(ObjEntidad);

                        MensajeConfirmacion("Se Inserto Correctamente");
                        Program.Evento = 0;
                        LimpiarCajas();
                        Close();
                    }
                    catch (Exception)
                    {

                        MensajeError("No se Pudo Insertar el Registro");
                        Close();
                    }
                }
                else
                {
                    try
                    {
                        ObjEntidad.id_proveedor = Convert.ToInt32(tbCodigo.Text.ToUpper());
                       
                        ObjEntidad.rtn_proveedor = tbrtn.Text.ToUpper();
                        ObjEntidad.nombre_proveedor = tbnombre.Text.ToUpper();                       
                        ObjEntidad.direccion = tbDireccion.Text.ToUpper();
                        ObjEntidad.telefono = tbTelefono.Text.ToUpper();
                                                     
                        ObjNegocios.EditarRegistros(ObjEntidad);
                        MensajeConfirmacion("Se Modifico Correctamente");
                        Program.Evento = 0;
                        LimpiarCajas();
                        Close();

                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Editar el Registro");
                        //Program.Evento = 0;
                    }
                }
            }
            else
            {
                MensajeError("Llene los campos correspondientes para guardar correctamente");
                //Program.Evento = 0;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
