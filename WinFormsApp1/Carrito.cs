using proyecto;
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


namespace Vista
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void MostrarListaEnCarrito()
        {
            // Acceder a la lista compartida
            var listaNodos = CarritoData.ListaNodos;

            if (listaNodos != null && listaNodos.nodos.Count > 0)
            {
                // Llenar el DataGridView con los datos de la lista compartida
                listaNodos.LlenarDataGridView(dgvCarrito);
            }
            else
            {
                MessageBox.Show("El carrito está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas limpiar el carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Limpiar la lista compartida
                    CarritoData.ListaNodos.nodos.Clear();
                    dgvCarrito.Rows.Clear();
                    MessageBox.Show("El carrito ha sido limpiado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblSubtotal.Text = "...";
                    lblDescuentos.Text = "...";
                    lblTotal.Text = "...";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al limpiar el carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarrito.SelectedRows.Count > 0)
                {
                    DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar el producto {dgvCarrito.SelectedRows[0].Cells["Nombre"].Value} del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Obtener el ID del producto seleccionado
                        int idProducto = Convert.ToInt32(dgvCarrito.SelectedRows[0].Cells["ID"].Value);

                        // Eliminar el nodo de la lista compartida
                        CarritoData.ListaNodos.EliminarNodoPorID(idProducto);

                        // Actualizar el DataGridView
                        CarritoData.ListaNodos.LlenarDataGridView(dgvCarrito);

                        // Recalcular el cobro
                        CalcularCobro();

                        MessageBox.Show("Producto eliminado del carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (resultado == DialogResult.No)
                    {
                        MessageBox.Show("El producto no fue eliminado del carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
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

        public void CalcularCobro()
        {
            double total = 0;
            double descuento = 0;
            double subtotal = 0;
            foreach (var nodo in CarritoData.ListaNodos.nodos)
            {
                if (nodo.Datos.ContainsKey("Precio") && nodo.Datos.ContainsKey("Cantidad"))
                {
                    double precio = Convert.ToDouble(nodo.Datos["Precio"]);
                    double cantidad = Convert.ToDouble(nodo.Datos["Cantidad"]);
                    subtotal += Math.Round(precio * cantidad, 2);
                }
            }


            foreach (var nodo in CarritoData.ListaNodos.nodos)
            {
                if (nodo.Datos.ContainsKey("Precio Con Descuento") && nodo.Datos.ContainsKey("Cantidad"))
                {
                    double precioConDescuento = Convert.ToDouble(nodo.Datos["Precio Con Descuento"]);
                    double cantidad = Convert.ToDouble(nodo.Datos["Cantidad"]);
                    total += Math.Round(precioConDescuento * cantidad, 2);
                }
            }

            descuento = Math.Round(subtotal - total, 2);
            lblSubtotal.Text = "$" + subtotal.ToString();
            lblDescuentos.Text = "-$" + descuento.ToString();
            lblTotal.Text = "$" + total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Por favor, agregue productos antes de proceder.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNombre.Text == "" || txtNombre.Text.Length < 7)
            {
                MessageBox.Show("Por favor, ingrese su nombre completo \n Ejemplo: Ana Alejandra Asencio Arias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDireccion.Text == "" || txtDireccion.Text.Length < 10)
            {
                MessageBox.Show("Por favor, ingrese una dirección válida \n Ejemplo: Calle Falsa 123, Ciudad, País", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTarjeta.Text == "" || txtTarjeta.Text.Length < 16)
            {
                MessageBox.Show("Por favor, ingrese un número de tarjeta válido \n Ejemplo: 1234-5678-9012-3456", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCaducidad.Text == "" || txtCaducidad.Text.Length < 5)
            {
                MessageBox.Show("Por favor, ingrese una fecha de caducidad válida \n Ejemplo: 12/2025", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCVV.Text == "" || txtCVV.Text.Length < 3)
            {
                MessageBox.Show("Por favor, ingrese un CVV válido \n Ejemplo: 123", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!VerificarStock())
                {
                    return; // Si hay un problema con el stock, detener el proceso
                }
                try
                {
                    if (CarritoData.ListaNodos.nodos.Count == 0)
                    {
                        MessageBox.Show("El carrito está vacío después de verificar el stock. Por favor, agregue productos antes de proceder.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Aquí puedes agregar la lógica para procesar el pago y finalizar la compra
                    MessageBox.Show("Compra realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizaStock(); // Actualizar el stock de los productos comprados
                    CarritoData.ListaNodos.nodos.Clear(); // Limpiar el carrito después de la compra
                    dgvCarrito.Rows.Clear(); // Limpiar el DataGridView
                    lblSubtotal.Text = "...";
                    lblDescuentos.Text = "...";
                    lblTotal.Text = "...";
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtTarjeta.Text = "";
                    txtCaducidad.Text = "MM/AAAA"; // Restablecer el campo de caducidad
                    txtCVV.Text = ""; // Restablecer el campo de CVV

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerificarStock()
        {
            foreach (var nodo in CarritoData.ListaNodos.nodos)
            {
                if (nodo.Datos.ContainsKey("Cantidad"))
                {
                    int id = nodo.ID;
                    int cantidad = Convert.ToInt32(nodo.Datos["Cantidad"]);
                    int stock = 0;
                    string query = $"SELECT Stock FROM Productos WHERE IdProducto = {id}";
                    using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                    {
                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            try
                            {
                                stock = Convert.ToInt32(command.ExecuteScalar());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al verificar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false; // Detener el proceso si ocurre un error
                            }
                        }
                    }

                    if (stock == 0) // Si no hay stock, detener el proceso
                    {
                        MessageBox.Show($"El producto {nodo.Datos["Nombre"]} no está disponible en stock.\nSerá eliminado del carrito, por favor verificar nuevamente el carrito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarritoData.ListaNodos.EliminarNodoPorID(id);
                        CarritoData.ListaNodos.LlenarDataGridView(dgvCarrito);
                        CalcularCobro();
                        return false; // Indicar que el proceso debe detenerse
                    }

                    if (cantidad > stock)
                    {
                        DialogResult res = MessageBox.Show($"El producto {nodo.Datos["Nombre"]} no tiene suficiente stock\nEl stock disponible es: {stock}\nPresione Yes para actualizar.\nPresione No para eliminar producto.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            nodo.Datos["Cantidad"] = stock;
                            CarritoData.ListaNodos.LlenarDataGridView(dgvCarrito);
                            CalcularCobro();
                            MessageBox.Show("Por favor verifique los productos en el carrito y vuelva a realizar la compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false; // Detener el proceso para que el usuario revise el carrito
                        }
                        else if (res == DialogResult.No)
                        {
                            CarritoData.ListaNodos.EliminarNodoPorID(id);
                            CarritoData.ListaNodos.LlenarDataGridView(dgvCarrito);
                            CalcularCobro();
                            MessageBox.Show("Por favor verifique los productos en el carrito y vuelva a realizar la compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false; // Detener el proceso para que el usuario revise el carrito
                        }
                    }
                }
            }
            return true; // Indicar que todo está bien y el proceso puede continuar
        }

        private void ActualizaStock()
        {
            foreach (var nodo in CarritoData.ListaNodos.nodos)
            {
                if (nodo.Datos.ContainsKey("Cantidad"))
                {
                    int id = nodo.ID;
                    int cantidad = Convert.ToInt32(nodo.Datos["Cantidad"]);
                    int stock = 0;
                    string query = $"SELECT Stock FROM Productos WHERE IdProducto = @IdProducto";
                    using (SqlConnection conexion = Modelo.Conexion.GetConexion())
                    {
                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            command.Parameters.AddWithValue("@IdProducto", id);
                            try
                            {

                                stock = Convert.ToInt32(command.ExecuteScalar());
                                int nuevoStock = stock - cantidad;
                                query = "UPDATE Productos SET Stock = @Stock WHERE IdProducto = @IdProducto";
                                using (SqlCommand updateCommand = new SqlCommand(query, conexion))
                                {
                                    updateCommand.Parameters.AddWithValue("@Stock", nuevoStock);
                                    updateCommand.Parameters.AddWithValue("@IdProducto", id);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al actulizar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }


                }
            }
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;

            // Mostrar los productos del carrito al cargar el formulario
            MostrarListaEnCarrito();
            CalcularCobro();
        }

        private void txtCaducidad_Click(object sender, EventArgs e)
        {
            txtCaducidad.Text = ""; // Limpiar el campo al hacer clic
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
            }
            // Limita la entrada a 3 dígitos
            if (txtCVV.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese más de 3 dígitos
            }
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico o no guion
            }
            if (txtTarjeta.Text.Length >= 19 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese más de 19 caracteres (incluyendo guiones)
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no alfabético o espacio 
            }
        }
    }
}
