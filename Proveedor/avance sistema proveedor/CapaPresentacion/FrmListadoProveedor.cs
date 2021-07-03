using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmListadoProveedor : Form
    {
        readonly E_proveedor ObjEntidad = new E_proveedor();
        readonly N_proveedor ObjNegocio = new N_proveedor();

        public FrmListadoProveedor()
        {
            InitializeComponent();
        }

     
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AccionesTabla()
        {

            DataListado.Columns[0].Visible = false;
          
            DataListado.Columns[1].HeaderText = "RTN Proveedor";
            DataListado.Columns[2].HeaderText = "Nombre Proveedor";
            DataListado.Columns[3].HeaderText = "Direccion";
            DataListado.Columns[4].HeaderText = "Telefono";

        }

        public void MostrarRegistro()
        {
            DataListado.DataSource = N_proveedor.MostrarRegistros();
            AccionesTabla();
        }
        public void BuscarRegistro()
        {
            DataListado.DataSource = N_proveedor.BuscarRegistros(txtBuscar.Text);
        }

        public void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;
                exportarExcel.Cells[1, indicecolumna] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarExcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }

            }
            exportarExcel.Visible = true;

        }
    
      

        private void btnExpExcell_Click(object sender, EventArgs e)
        {
            ExportarDatos(DataListado);
        }

        private void FrmListadoProveedor_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmProveedor nuevoresgistro = new FrmProveedor();
            nuevoresgistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoresgistro.ShowDialog();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            FrmProveedor editarregistros = new FrmProveedor();
            editarregistros.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            

            if (DataListado.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarregistros.tbCodigo.Text = DataListado.CurrentRow.Cells[0].Value.ToString();
                editarregistros.tbrtn.Text = DataListado.CurrentRow.Cells[1].Value.ToString();
                editarregistros.tbnombre.Text = DataListado.CurrentRow.Cells[2].Value.ToString();
                editarregistros.tbDireccion.Text = DataListado.CurrentRow.Cells[3].Value.ToString();
                editarregistros.tbTelefono.Text = DataListado.CurrentRow.Cells[4].Value.ToString();
               
                editarregistros.ShowDialog();
            }
            else
            {
                MensajeError("Selecione la fila a editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataListado.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Eliminar el registro?", "Comercial Mario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.id_proveedor = Convert.ToInt32(DataListado.CurrentRow.Cells[0].Value.ToString());
                    ObjNegocio.EliminarRegistros(ObjEntidad);

                    MensajeConfirmacion("Se elimino Correctamente");
                    MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione el registro a Eliminar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }
    }
}
