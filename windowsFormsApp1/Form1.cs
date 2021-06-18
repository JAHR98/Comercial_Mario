using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update cliente set NOMBRE CLIENTE= " + textBox2.Text + "'," + "Apellido Cliente= '" + textBox3.Text + "'," + "Identidad Cliente= '" + textBox4.Text + "'," + "RTN Cliente= '" + textBox5.Text + "'," + "Telefono= '" + textBox6.Text + "'," + "Correo Electronico= '" + textBox7.Text + "'," + "where ID Cliente= '" + textBox1.Text + "'";
            MySqlconnection conn = conexion.conexion();
            Conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                leer = comando.ExecuteNonQuery();

                MessageBox.Show("REGISTRO ACTUALIZADO");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR A; ACTUALIZAR" + ex.Message);
            }
            finally
            {
                conn.close();
            }

