using proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Mostrar los productos del carrito al cargar el formulario
            MostrarListaEnCarrito();
            CalcularCobro();
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
                    txtSubtotal.Text = "0";
                    txtDescuentos.Text = "0";
                    txtTotal.Text = "0";
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

                    int idProducto = Convert.ToInt32(dgvCarrito.SelectedRows[0].Cells["ID"].Value);


                    // elimina el producto en la lista 
                    CarritoData.ListaNodos.EliminarNodoPorID(idProducto);
                    // Actualiza el DataGridView
                    CarritoData.ListaNodos.LlenarDataGridView(dgvCarrito);
                    CalcularCobro();
                    
                    

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
                    total += Math.Round(precioConDescuento * cantidad,2);
                }
            }

            descuento = Math.Round(subtotal - total,2);
            txtSubtotal.Text = subtotal.ToString();
            txtDescuentos.Text = descuento.ToString();
            txtTotal.Text = total.ToString();
        }
    }
}
