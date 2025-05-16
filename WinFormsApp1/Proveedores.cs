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
using Vista;

namespace proyecto
{
    public partial class Proveedores : Form
    {
        ListaEnlazada lista = new ListaEnlazada();
        public Proveedores()
        {
            InitializeComponent();
            ActualizarDatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificación_de_Proveedores form = new Modificación_de_Proveedores();
            form.Show();
            this.Hide();

        }
        public void ActualizarDatagrid()
        {
            if (!this.Visible) // Asegurar que `FormProveedores` ya está visible antes de ejecutar
                return;

            dataGridView1.Rows.Clear(); // Limpiar las filas antes de actualizar

            if (lista.nodos.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var nodo in lista.nodos)
            {
                var fila = new List<object> { nodo.ID };
                fila.AddRange(nodo.Datos.Values);
                dataGridView1.Rows.Add(fila.ToArray());
            }


        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();


        }

        public void CargarDatos()
        {
            try
            {
                lista.nodos.Clear();
                using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "SELECT DISTINCT IdProveedor, NomMarca, Email, TelProveedor, RegistroIva FROM Proveedores";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Nodo proveedor = new Nodo();

                                // lee el IdProducto 
                                proveedor.ID = Convert.ToInt32(reader["IdProveedor"]);
                                proveedor.Name = reader["NomMarca"].ToString();

                                proveedor.Datos = new Dictionary<string, object>()
                    {
                                    {"Nombre", reader["NomMarca"].ToString()  },
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) //verificar que haya una fila seleccionada
            {
                int indiceseleccionado = dataGridView1  .SelectedRows [0].Index;

                if(indiceseleccionado >= 0 && indiceseleccionado < lista.nodos.Count)
                {
                    //obtenes el proveedor seleccionado
                    Nodo proovedorSeleccionado = lista.nodos[indiceseleccionado];


                    //abrimos el form con los datos seleccionados
                    Modificación_de_Proveedores modificar = new Modificación_de_Proveedores(proovedorSeleccionado);
                    modificar.ShowDialog();

                    CargarDatos();
                    ActualizarDatagrid();
                }

  
            }
            else
            {

                MessageBox.Show("Seleccione un proveedor para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }
    }
}
