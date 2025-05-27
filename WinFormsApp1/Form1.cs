using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Modelo.Conexion conexion;
        public Form1()
        {
            conexion = new Modelo.Conexion();
            InitializeComponent();
            ocultarcontra();
        }



        private void GetInfo()
        {
            using (SqlConnection connection = Modelo.Conexion.GetConexion())
            {

                SqlCommand cmd = new SqlCommand("SELECT Nombre, Contraseña FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña", connection);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        string nombre = reader.GetString(0);
                        string contraseña = reader.GetString(1);

                        if (txtNombre.Text == nombre && txtContraseña.Text == contraseña)
                        {
                            principaladministrador frmAdmin = new principaladministrador();
                            frmAdmin.Show();
                            this.Hide();
                            MessageBox.Show("Bienvenido " + txtNombre.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }

        }

        #region decoracion

        private void ocultarcontra()
        {
            txtContraseña.UseSystemPasswordChar = true;
        }


        #endregion




        #region PANEL TITULO



        private void pnltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //movimiento panel titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btncerrarlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;



        private void btnminimizarlogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion


        private void btninventario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Adverteencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña.", "Adverteencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                GetInfo();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            principalusuario1 Formusuario = new principalusuario1();
            Formusuario.Show();   
            this.Close();
        }
    }
}
