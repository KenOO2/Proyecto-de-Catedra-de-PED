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
    public partial class Proveedores : Form
    {
        ListaEnlazada lista = new ListaEnlazada();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificación_de_Proveedores form = new Modificación_de_Proveedores();
            form.Show();
            this.Hide();
        }
        public void ActualizarDataGrid()
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void CargarDatos()
        {
            try
            {
                using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "SELECT IdProveedor, NomMarca, Email, TelProveedor, RegistroIva FROM Proveedores";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Nodo proveedor = new Nodo();

                                // lee el IdProducto 
                                proveedor.ID = Convert.ToInt32(reader["IdProveedor"]);


                                proveedor.Datos = new Dictionary<string, object>()
                    {
                        {"Nombre", reader["NomMarca"].ToString() },
                        {"Email", reader["Email"].ToString()},
                        {"Telefono", reader["TelProveedor"].ToString() },
                       { "RegistroIVA", reader["RegistroIva"] != DBNull.Value ? reader["RegistroIva"].ToString() : "Sin Registro" }
                    };

                                lista.AñadirNodo(proveedor);
                            }
                        }
                    }
                }
                lista.LlenarDataGridView(dataGridView1);
            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;

                    int idProveedor = lista.nodos[indiceSeleccionado].ID;


                    // elimina el producto en la lista 
                    lista.EliminarNodoPorID(idProveedor);

                    // elimina el producto en la base 
                    EliminarDeBD(idProveedor);

                    // se actualiza datagridview
                    lista.LlenarDataGridView(dataGridView1);

                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EliminarDeBD(int idProveedor)
        {
            try
            {
                using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProveedor", idProveedor);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
    }
}
