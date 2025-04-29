using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Modificación_de_Proveedores : Form
    {
        private ListaEnlazada listaproveedores = new ListaEnlazada();
        public Modificación_de_Proveedores()
        {
            InitializeComponent();
        }

        private void btnagg_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            if (!ValidarNombre(txtname.Text))
            {
                return;
            }
            if (!ValidarEmail(txtemail.Text))
            {
                return;
            }
            if (!ValidarTelefono(txttelefono.Text))
            {
                return;
            }
            if(!Validarlongitud(txtiva.Text))
            {
                return;
            }
            try
            {
                int id = int.Parse(txtidprove.Text);
                string nombre = txtname.Text;
                string email = txtemail.Text;
                string telefono = txttelefono.Text;
                string RegistroIVA = txtiva.Text;

                var datos = new Dictionary<string, object>
                {
                    {"Nombre", nombre },
                    {"Email", email },
                    {"Telefono", telefono},
                    {"RegistroIVA", RegistroIVA}
                };

                Nodo nuevoNodo = new Nodo
                {
                    ID = id,
                    Datos = datos,
                };

                listaproveedores.AñadirNodo(nuevoNodo);
                GuardarEnBD(nuevoNodo);
                MessageBox.Show("Proveedor agregado correctamente");
                Proveedores prove = new Proveedores();
                prove.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar un proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarEnBD(Nodo nodo)
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Proveedores (IdProveedor, NomMarca, Email, TelProveedor, RegistroIva) VALUES (@IdProveedor, @NomMarca, @Email, @TelProveedor, @RegistroIva)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProveedor", nodo.ID);
                    comando.Parameters.AddWithValue("@NomMarca", nodo.Datos["Nombre"]);
                    comando.Parameters.AddWithValue("@Email", nodo.Datos["Email"]);
                    comando.Parameters.AddWithValue("@TelProveedor", nodo.Datos["Telefono"]);
                    comando.Parameters.AddWithValue("@RegistroIva", nodo.Datos["RegistroIVA"]);

                    comando.ExecuteNonQuery();
                }
            }
        }
        private void btnvolver_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtidprove.Text) ||
                string.IsNullOrWhiteSpace(txtiva.Text) ||
                string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txttelefono.Text))
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private bool ValidarNombre(string nombre)
        {
            string patronc = @"^[a-zA-Z\s]+$";

            if (System.Text.RegularExpressions.Regex.IsMatch(nombre, patronc))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Solo se admite letras y espacios en el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void txtidprove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ValidarEmail(string email)
        {
            string jelo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, jelo))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ingrese una direccion de correo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidarTelefono(string numero)
        {
            string kiki = @"^\d{4}-\d{4}$";
            if (System.Text.RegularExpressions.Regex.IsMatch(numero, kiki))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El formato de telefono es xxxx-xxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool Validarlongitud(string texto)
        {
            if(texto.Length < 5)
            {
                MessageBox.Show("Debe tener 5 digitos como minimo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false ;
            }
            return true;
        }
    }
}
