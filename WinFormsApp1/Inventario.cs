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
                string nombreProducto = txtNomProducto.Text;

                Nodo nuevoProducto = new Nodo();
                nuevoProducto.ID = idProducto;
                //*------------------------------------------------------*
                //Ahora el nodo tiene un atributo bombre y este ya no se coloca en dictionary
                //*----------------------------------------------------------*
                nuevoProducto.Name = nombreProducto;

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
                {"IdProveedor", int.Parse(txtIDprovee.Text)},
                {"Nombre", nombreProducto},
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
                            //*-------------------------------------------------------------*
                            //Actualizamos la lista si se pudo actualizar la bd
                            //Actualizacion de la lista 


                            decimal precioConDescuento = precio - (precio * descuento / 100);
                            Dictionary<string, object> NuevosDatos = new Dictionary<string, object>()
                            {
                            {"IdProveedor", int.Parse(txtIDprovee.Text)},
                            {"Nombre", nomProducto},
                            {"Precio", precio},
                            {"Descuento", descuento},
                            {"PrecioConDescuento", precioConDescuento}
                            };
                            
                            try
                            {
                                listaProductos.ActualizarNodoPorID(Convert.ToInt32(idProducto), nomProducto, NuevosDatos);
                                listaProductos.LlenarDataGridView(dataGridView1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //*------------------------------------------------------------------*


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

        //*--------------------------------------------------------*
        //El anterior boton editar descuento ya no se usara por lo tanto ahora se usa para buscar
        //Editar el diseno a conveniencia si es necesario
        //*--------------------------------------------------------*
        private void BtnDescuento_Click(object sender, EventArgs e)
        {
            //Inserte validaciones de campos aqui
            try
            {
                string id = txtIDProducto.Text;
                string nom = txtNomProducto.Text.Trim();
                if (txtIDProducto.Text != "") //Buscamor por id
                {
                    //Si el campo id esta lleno buscamos por id
                    dataGridView1.Rows.Clear();
                    listaProductos.BuscarNodoPorID(Convert.ToInt32(id), dataGridView1);
                }
                if(txtNomProducto.Text != "")//Buscamos por nombre
                {
                    dataGridView1.Rows.Clear();
                    listaProductos.BuscarNodoPorNombre(nom, dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //*-------------------------------------------------------------------------------------------------------------*
            //Por favor poner un boton para reinicir el DGV y que muestre toda la lista ya que aqui solo muestra el resultado
            //*-------------------------------------------------------------------------------------------------------------*
        }

        //*---------------------------------------------------------------------------*
        //Eliminar este metodo ya que el descuento se manejara con la edicion del producto
        //*------------------------------------------------------------------------------*
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
                            //*---------------------------------------------------*
                            //Ahora el nombre se guarda aparte del dictionary
                            //*----------------------------------------------------*
                            producto.Name = reader["NomProducto"].ToString() ;

                            decimal precio = Convert.ToDecimal(reader["Precio"]);

                            // lee el Descuento 
                            int descuento = 0;
                            if (int.TryParse(reader["Descuento"].ToString(), out int parsedDescuento))
                                descuento = parsedDescuento;

                            decimal precioConDescuento = precio - (precio * descuento / 100);

                            producto.Datos = new Dictionary<string, object>()
                            {
                            {"Nombre", reader["NomProducto"].ToString()},
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
