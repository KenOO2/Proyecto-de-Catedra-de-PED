using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Modelo;
using System.Diagnostics;

namespace proyecto
{

    public partial class Inventario : Form
    {
        private ListaEnlazada listaProductos = new ListaEnlazada();
        public Inventario()
        {
            InitializeComponent();

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // crea el nodo nuevo
                int idProducto = int.Parse(txtIDProducto.Text);

                Nodo nuevoProducto = new Nodo();
                nuevoProducto.ID = idProducto;  

                // descuento sobre el precio
                decimal precio = decimal.Parse(txtPrecio.Text);
                int descuento;
                if (!int.TryParse(txtDescuento.Text, out descuento))
                {
                    MessageBox.Show("Por favor ingrese un número válido en el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal precioConDescuento = precio - (precio * descuento / 100);

                nuevoProducto.Datos = new Dictionary<string, object>()
                {
                {"IdProducto", idProducto},  
                {"NomProducto", txtNomProducto.Text},
                {"IdProveedor", int.Parse(txtIDprovee.Text)},
                {"Precio", precio},
                {"Descuento", descuento},
                {"PrecioConDescuento", precioConDescuento}
                };

                //agrega el nodo a la lista enlazada
                listaProductos.AñadirNodo(nuevoProducto);

                //insertar en la base de datos
                InsertarProductoEnBaseDeDatos(idProducto, txtNomProducto.Text, int.Parse(txtIDprovee.Text), precio, descuento);

                //actualiza el datagridview
                listaProductos.LlenarDataGridView(dataGridView1);

                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpia los campos
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InsertarProductoEnBaseDeDatos(int idProducto, string nomProducto, int idProveedor, decimal precio, int descuento)
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Productos (IdProducto, NomProducto, IdProveedor, Precio, Descuento) VALUES (@IdProducto, @NomProducto, @IdProveedor, @Precio, @Descuento)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);  
                    comando.Parameters.AddWithValue("@NomProducto", nomProducto);
                    comando.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Descuento", descuento);

                    comando.ExecuteNonQuery();
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
 
            try
            {
                // validaciones
                if (string.IsNullOrWhiteSpace(txtIDProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtNomProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtIDprovee.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtDescuento.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // convierte los datos 
                string idProducto = txtIDProducto.Text.Trim();
                string nomProducto = txtNomProducto.Text.Trim();
                int idProveedor = int.Parse(txtIDprovee.Text.Trim());
                decimal precio = decimal.Parse(txtPrecio.Text.Trim());
                int descuento = int.Parse(txtDescuento.Text.Trim());

                using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                {
                    string query = @"UPDATE Productos 
                             SET NomProducto = @NomProducto, 
                                 IdProveedor = @IdProveedor, 
                                 Precio = @Precio, 
                                 Descuento = @Descuento
                             WHERE IdProducto = @IdProducto";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NomProducto", nomProducto);
                        comando.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@Descuento", descuento);
                        comando.Parameters.AddWithValue("@IdProducto", idProducto);

                        int filasAfectadas = comando.ExecuteNonQuery();

                       
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            listaProductos.Vaciar();

                            CargarProductosDesdeBaseDeDatos();

                            listaProductos.LlenarDataGridView(dataGridView1);

                            LimpiarCampos();
                        }

                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato incorrecto en alguno de los campos numéricos. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtIDProducto.Clear();
            txtNomProducto.Clear();
            txtIDprovee.Clear();
            txtPrecio.Clear();
            txtDescuento.Clear();
        }


        private void BtnDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdProducto"].Value);
                    int nuevoDescuento;
                    if (!int.TryParse(txtDescuento.Text, out nuevoDescuento))
                    {
                        MessageBox.Show("Por favor ingrese un número válido en el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // edita la lista
                    Nodo producto = listaProductos.BuscarNodoPorID(idProducto);
                    if (producto != null)
                    {
                        // se actualiza el descuento en la lista enlazada
                        producto.Datos["Descuento"] = nuevoDescuento;
                        // se recalcula el precio con el nuevo descuento
                        decimal precio = (decimal)producto.Datos["Precio"];
                        decimal precioConDescuento = precio - (precio * nuevoDescuento / 100);
                        producto.Datos["PrecioConDescuento"] = precioConDescuento;
                    }

                    // se editar la base de datos usando la clase Conexion
                    ActualizarDescuentoEnBaseDeDatos(idProducto, nuevoDescuento);

                    // se actualiza datagridview
                    listaProductos.LlenarDataGridView(dataGridView1);

                    MessageBox.Show("Descuento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ActualizarDescuentoEnBaseDeDatos(int idProducto, int descuento)
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE Productos SET Descuento = @Descuento WHERE IdProducto = @IdProducto";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", idProducto); 
                    comando.Parameters.AddWithValue("@Descuento", descuento);

                    comando.ExecuteNonQuery();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdProducto"].Value);

                    // elimina el producto en la lista 
                    listaProductos.EliminarNodoPorID(idProducto);

                    // elimina el producto en la base 
                    EliminarProductoDeBaseDeDatos(idProducto);

                    // se actualiza datagridview
                    listaProductos.LlenarDataGridView(dataGridView1);

                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void EliminarProductoDeBaseDeDatos(int idProducto)
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);  

                    comando.ExecuteNonQuery();
                }
            }
        }
        
        private void CargarProductosDesdeBaseDeDatos()
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT IdProducto, NomProducto, IdProveedor, Precio, Descuento FROM Productos";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nodo producto = new Nodo();

                            // lee el IdProducto 
                            producto.ID = Convert.ToInt32(reader["IdProducto"]);

                            decimal precio = Convert.ToDecimal(reader["Precio"]);

                            // lee el Descuento 
                            int descuento = 0;
                            if (int.TryParse(reader["Descuento"].ToString(), out int parsedDescuento))
                                descuento = parsedDescuento;

                            decimal precioConDescuento = precio - (precio * descuento / 100);

                            producto.Datos = new Dictionary<string, object>()
                    {
                        {"IdProducto", Convert.ToInt32(reader["IdProducto"])},
                        {"NomProducto", reader["NomProducto"].ToString()},
                        {"IdProveedor", Convert.ToInt32(reader["IdProveedor"])},
                        {"Precio", precio},
                        {"Descuento", descuento},
                        {"PrecioConDescuento", precioConDescuento}
                    };

                            listaProductos.AñadirNodo(producto);
                        }
                    }
                }
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarProductosDesdeBaseDeDatos();
            listaProductos.LlenarDataGridView(dataGridView1);
        }
    }
}
