using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using CapaEntidades;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class FrmRecuperacionContra : Form
    {
        public FrmRecuperacionContra()
        {
            InitializeComponent();
        }
        private void mensajeError(String mensaje)
        {
            MessageBox.Show(mensaje,"Comercial Mario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Perfecto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {

            if (txtUsuarioCorreo.Text != "")
            {
                N_InicioSesion recuperacion = new N_InicioSesion();

                var validarDatos = recuperacion.recuperacionCorreo(txtUsuarioCorreo.Text);
                if (validarDatos == true)
                {
                    string contraseña = E_RecuperacionCorreo.contraseña;
                    string mensaje = string.Empty;
                    //Creando el correo electronico
                    string destinatario = E_RecuperacionCorreo.correo_empleado;
                    string remitente = "ronyfunez1212@gmail.com";
                    string asunto = "Contraseña Comercial Mario:";
                    string cuerpoDelMesaje = "Hola, "+E_RecuperacionCorreo.usuario+" Su  contraseña de inicio de sesion de Comercial Mario es:" + " " + contraseña;
                    MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("cmrclmario@gmail.com", "comercialm2021");

                    try
                    {
                        Task.Run(() =>
                        {

                            smtp.Send(ms);
                            ms.Dispose();
                          
                            MessageBox.Show("Se ha enviado su contraseña a su direccion de Correo "+E_RecuperacionCorreo.correo_empleado+" sirvase revisar su bandeja de entrada");
                          
                        }
                        );

                        MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
                        btnClose.Enabled = false;
                        lblFRecuperacionContra.Visible = false;
                        btnVerificar.Visible = false;
                        lblIngresesuAntiguacontraseña.Visible = false;
                        lblIngresesuAntiguacontraseña.Visible = true;
                        txtAntiguaCont.Visible = true;
                        lblNuevacontraseña.Visible = true;
                        txtnuevaContrase.Visible = true;
                        lblConfirmeSuNuevaContra.Visible = true;
                        txtConfirmeSuNuevaContra.Visible = true;
                        btnGUARDAR.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
                    }


                }

                else
                {
                    mensajeError("No existe un correo oh usuario con estos datos");
                    txtUsuarioCorreo.Focus();
                }
            }
            else
            {
                mensajeError("Porfavor Ingrese su usuario oh correo");
                txtUsuarioCorreo.Focus();
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {           
            FrmLogin Login = new FrmLogin();
            Close();
            Login.Show();

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if(txtAntiguaCont.Text!="")
            {
                if(txtAntiguaCont.Text== E_RecuperacionCorreo.contraseña)
                {
                    if (txtnuevaContrase.Text != "" && txtConfirmeSuNuevaContra.Text != "")
                    {
                        if (txtnuevaContrase.Text == txtConfirmeSuNuevaContra.Text)
                        {
                            try
                            {
                                N_InicioSesion editar = new N_InicioSesion();
                                editar.EditarRegistros(E_RecuperacionCorreo.usuario, txtnuevaContrase.Text);
                                MensajeConfirmacion("Se Modifico Correctamente " + E_RecuperacionCorreo.usuario + " " + txtnuevaContrase.Text + " Vuelva a iniciar sesion");
                                FrmLogin Login = new FrmLogin();
                                Close();
                                Login.Show();

                            }
                            catch (Exception)
                            {
                                mensajeError("No se Pudo Editar el Registro");

                            }

                        }
                        else
                        {
                            mensajeError("Porfavor confirme correctamente su nueva Contraseña ");
                            txtConfirmeSuNuevaContra.Focus();
                        }
                    }
                    else
                    {
                        mensajeError("Porfavor introduzca una nueva Contraseña");
                    }
                }
                else
                {
                    mensajeError("La antigua Contraseña no coincide");
                    txtAntiguaCont.Focus();
                }
            }
            else
            {
                mensajeError("Porfavor Ingrese su antigua Contraseña");
            txtAntiguaCont.Focus();
            }
              

        }

        private void FrmRecuperacionContra_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
