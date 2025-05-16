using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace proyecto
{
    public partial class Modificación_de_Proveedores : Form
    {
        private ListaEnlazada listaproveedores = new ListaEnlazada();
        private Nodo proveedoractual; //si se agrega
        private bool esModificacion; //si se modifica

        public Modificación_de_Proveedores()
        {
            InitializeComponent();
        }
        public Modificación_de_Proveedores(Nodo proveedor)
        {
            InitializeComponent();
            if (proveedor != null)
            {
                proveedoractual = proveedor;
                cargarDatosProveedor();
                esModificacion = true;

                txtidprove.ReadOnly = true;
                txtidprove.BackColor = Color.LightGray;
                txtidprove.TabStop = false;

            }
        }
        private void cargarDatosProveedor()
        {
            txtidprove.Text = proveedoractual.ID.ToString();
            txtname.Text = proveedoractual.Datos["Nombre"].ToString().Trim() ;
            txtemail.Text = proveedoractual.Datos["Email"].ToString().Trim();
            txttelefono.Text = proveedoractual.Datos["Telefono"].ToString().Trim();
            txtiva.Text = proveedoractual.Datos["RegistroIVA"].ToString().Trim();


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
                if(esModificacion) //si estamos modificando 
                {
                    proveedoractual.ID = id;
                    proveedoractual.Datos = datos;
                    ActualizarEnBD(proveedoractual);
                    MessageBox.Show("Proveedor modificado correctamente");
                }
                else
                {
                    Nodo nuevonod = new Nodo { ID = id, Datos = datos };
                    listaproveedores.AñadirNodo(nuevonod);
                    GuardarEnBD(nuevonod);
                    MessageBox.Show("Proveedor agregado correctamente");
                }

                //Accede al form proveedores dentro del principal admin
                Proveedores prove = (Proveedores)Application.OpenForms["Proveedores"];
                if(prove != null)
                {
                    prove.CargarDatos();
                    prove.ActualizarDatagrid();//actualiza los datos
                    prove.Focus();//trae el form al frente
                }
                this.Close();//cierra el form agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar un proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarEnBD(Nodo proveedor)
        {
            try
            {
                using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo establecer una conexion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string query = "UPDATE Proveedores SET NomMarca = @Nombre, Email = @Email, TelProveedor = @Telefono, RegistroIva = @RegistroIVA WHERE IdProveedor = @ID";
                    using (SqlCommand comandito = new SqlCommand(query, conexion))
                    {
                        // Convertimos los valores a los tipos correctos
                        comandito.Parameters.AddWithValue("@ID", proveedor.ID);
                        comandito.Parameters.AddWithValue("@Nombre", proveedor.Datos["Nombre"].ToString().PadRight(15)); // Asegura que coincida con VARCHAR(15)
                        comandito.Parameters.AddWithValue("@Email", proveedor.Datos["Email"].ToString().PadRight(30)); // Asegura que coincida con VARCHAR(30)
                        comandito.Parameters.AddWithValue("@Telefono", proveedor.Datos["Telefono"].ToString().PadRight(16)); // Asegura que coincida con CHAR(16)
                        comandito.Parameters.AddWithValue("@RegistroIVA", proveedor.Datos["RegistroIVA"].ToString().PadRight(10)); // Asegura que coincida con CHAR(10)

                        int FilasAfectadas = comandito.ExecuteNonQuery();

                        if (FilasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor actualizado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar al proveedor: " + ex.Message);
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
            Proveedores probe = (Proveedores)Application.OpenForms["Proveedores"];

            if(probe != null && !probe.IsDisposed)
            {
                probe.CargarDatos();
                probe.ActualizarDatagrid();
                probe.Show();
                probe.Focus();
            }
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
