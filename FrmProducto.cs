using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        FolderBrowserDialog CarpetaSalida;
        public OpenFileDialog examinar = new OpenFileDialog();
        public OpenFileDialog examinar2 = new OpenFileDialog();
        readonly E_producto ObjEntidad = new E_producto();
        readonly N_producto ObjNegocios = new N_producto();
        public FrmProducto()
        {
            InitializeComponent();
            llenarCombobox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Program.Evento = 0;
            Close();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            if(E_inicioSesion.cargo!=1)
            {
                Numexistencia.Enabled = false;
            }
            guna2ShadowForm1.SetShadowForm(this);
       
        }
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCajas()
        {
            tbCod.Text = "";
            tbdescripcion.Text = "";
            tbmarca.Text = "";
            tbNombre.Text = "";
            cbproveedor1.Text = "";
           
            Numexistencia.Value = 0;
            Numprecio.Value = 0;
            tbCod.Focus();
            

        }

        
        private void llenarCombobox()
        {
            cbproveedor1.DataSource = N_proveedor.MostrarRegistros();
            cbproveedor1.ValueMember = "id_proveedor";
            cbproveedor1.DisplayMember = "nombre_prveedor";
           
        }
        private int generarCod()
        {
            Random  aleatorio = new Random();
            int Num = 0;
            Num = aleatorio.Next(1000, 4000);

            return Num - aleatorio.Next(1, 999);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() != "" && tbmarca.Text.Trim() != "" && cbproveedor1.Text.Trim() != "" && Numexistencia.Value != 0 && Numprecio.Value !=0)
            {
                if (Program.Evento == 0)
                {
                    try
                    {
                        ObjEntidad.nombre_producto = tbNombre.Text.ToUpper();
                        ObjEntidad.marca_producto = tbmarca.Text.ToUpper();
                        ObjEntidad.precio_actual =   Convert.ToInt32(Numprecio.Value);
                        ObjEntidad.id_proveedor1 = Convert.ToInt32(cbproveedor1.SelectedValue);
                        ObjEntidad.existencia = Convert.ToInt32(Numexistencia.Value);
                        ObjEntidad.descripcion = tbdescripcion.Text.ToUpper();

                        ObjEntidad.cod_producto = generarCod();
                    
                  

                        if (examinar2.FileName!="")
                            {
                                FileStream stream = new FileStream(txtnombreimagen.Text, FileMode.Open, FileAccess.Read);

                                //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                                BinaryReader br = new BinaryReader(stream);
                                FileInfo fi = new FileInfo(txtnombreimagen.Text);

                                //Se inicializa un arreglo de Bytes del tamaño de la imagen
                                byte[] binData = new byte[stream.Length];
                                //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                                //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                                stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                                ////Se muetra la imagen obtenida desde el flujo de datos
                                picfotografia.Image = Image.FromStream(stream);

                                ObjEntidad.imagen = binData;
                         }
                            else
                            {
                            FileStream stream = new FileStream(@"C:\Users\pc\Desktop\UNICAH\Desarrollo de Software\Comercial Mario VF\CapaPresentacion\Resources\CM2.png", FileMode.Open, FileAccess.Read);

                            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                            BinaryReader br = new BinaryReader(stream);
                            FileInfo fi = new FileInfo(@"C:\Users\pc\Desktop\UNICAH\Desarrollo de Software\Comercial Mario VF\CapaPresentacion\Resources\CM1.png");

                            //Se inicializa un arreglo de Bytes del tamaño de la imagen
                            byte[] binData = new byte[stream.Length];
                            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                            ////Se muetra la imagen obtenida desde el flujo de datos
                            picfotografia.Image = Image.FromStream(stream);

                            ObjEntidad.imagen = binData;
                            }

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

                        ObjEntidad.nombre_producto = tbNombre.Text.ToUpper();
                        ObjEntidad.marca_producto = tbmarca.Text.ToUpper();
                        ObjEntidad.precio_actual = Convert.ToInt32(Numprecio.Value);
                        ObjEntidad.id_proveedor1 = Convert.ToInt32(cbproveedor1.SelectedValue);
                        ObjEntidad.existencia = Convert.ToInt32(Numexistencia.Value);
                        ObjEntidad.descripcion = tbdescripcion.Text.ToUpper();

                        ObjEntidad.cod_producto = Convert.ToInt32(tbCod.Text.ToUpper());

                        if (examinar2.FileName != "")
                        {
                        
                            FileStream stream = new FileStream(txtnombreimagen.Text, FileMode.Open, FileAccess.Read);

                            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                            BinaryReader br = new BinaryReader(stream);
                            FileInfo fi = new FileInfo(txtnombreimagen.Text);

                            //Se inicializa un arreglo de Bytes del tamaño de la imagen
                            byte[] binData = new byte[stream.Length];
                            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                            ////Se muetra la imagen obtenida desde el flujo de datos
                            picfotografia.Image = Image.FromStream(stream);

                            ObjEntidad.imagen = binData;

                            ObjNegocios.EditarRegistros(ObjEntidad);

                        }
                        else
                        {
                            ObjNegocios.EditarRegistrosSinImagen(ObjEntidad);

                        }
                       
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
              labelimagen.Visible=false;
              txtnombreimagen.Text = examinar.FileName;
            //picfotografia.Image = Image.FromFile(examinar.FileName);
           
          
            Bitmap bmp = new Bitmap(Redimencionar(picfotografia.Image, 100, 100));
            picfotografia.Image = bmp;

            MessageBox.Show("Ahora Seleccione la carpeta donde guardara la imagen seleccionada,\nposteriormente puede eliminarla", "Comercial Mario", MessageBoxButtons.OK);
            CarpetaSalida = new FolderBrowserDialog();
            String nueva;
            String Nombre="";

            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                nueva = CarpetaSalida.SelectedPath+"\\";

                Nombre = Path.GetFileName(examinar.FileName);             
                bmp.Save(nueva + "_thumbCopia" + Nombre, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
          
            if(Nombre!="")
            {
                MessageBox.Show("Ahora volvamos a seleccionar la imagen previamente convertida", "Comercial Mario", MessageBoxButtons.OK);

                examinar2.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
                DialogResult dres2 = examinar2.ShowDialog();
                if (dres2 == DialogResult.Abort)
                    return;
                if (dres2 == DialogResult.Cancel)
                    return;
                labelimagen.Visible = false;
                txtnombreimagen.Text = examinar2.FileName;
                picfotografia.Image = Image.FromFile(examinar2.FileName);
            }
         
        }

        public static Bitmap Redimencionar(Image imagenoriginal, int with, int height)
        {
            //Obtener el tama;i maximo
            var Radio = Math.Max((Double)with / imagenoriginal.Width, (double)height / imagenoriginal.Height);
            //Nuevo ancho nuevo alto segun el radio redimencionado
            var nuevoAncho = (int)(imagenoriginal.Width * Radio);
            var nuevoAlto = (int)(imagenoriginal.Height * Radio);
            //Creamos el Bitmap con los nuevos tama;os
            var ImagenRedimencionada = new Bitmap(nuevoAncho, nuevoAlto);
            //Copiamos la imagen y la convertimos en Bitmap
            Graphics.FromImage(ImagenRedimencionada).DrawImage(imagenoriginal, 0, 0, nuevoAncho, nuevoAlto);
            Bitmap ImagenFinal = new Bitmap(ImagenRedimencionada);
            return ImagenFinal;
        }
    }
}