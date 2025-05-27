using Modelo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto
{
    public partial class Tienda : Form
    {
        public Heap heap;
        public ListaEnlazada listaNodos;
        Nodo nodo = new Nodo();
        

        public Tienda()
        {
            InitializeComponent();
            heap = new Heap();

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LlenarHeap();
            heap.LlenarDataGridView(dgvProductos);
        }

        public void LlenarHeap()
        {
            using (SqlConnection conexion = Modelo.Conexion.GetConexion())
            {
                if (conexion == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT \r\n    p.IdProducto,\r\n    p.NomProducto,\r\n    p.IdProveedor,\r\n    p.Precio,\r\n    p.Descuento,\r\n    pr.NomMarca AS NombreMarca\r\nFROM \r\n    Productos p\r\nINNER JOIN \r\n    Proveedores pr\r\nON \r\n    p.IdProveedor = pr.IdProveedor;\r\n";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nodo producto = new Nodo();

                            // lee el IdProducto 
                            producto.ID = Convert.ToInt32(reader["IdProducto"]);
                            producto.Name = reader["NomProducto"].ToString();

                            decimal precio = Convert.ToDecimal(reader["Precio"]);
                            
                            // lee el Descuento 
                            int descuento = 0;
                            if (int.TryParse(reader["Descuento"].ToString(), out int parsedDescuento))
                                descuento = parsedDescuento;

                            decimal precioConDescuento =Math.Round(precio - (precio * descuento / 100),2);
                            


                            producto.Datos = new Dictionary<string, object>()
                            {
                            {"Nombre", reader["NomProducto"].ToString()},
                            {"Marca", reader["NombreMarca"].ToString()},
                            {"Precio", precio},
                            {"Porcentaje de Descuento", descuento},
                            {"Precio Con Descuento", precioConDescuento}
                            };

                            heap.Agregar(producto);
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            heap.LlenarDataGridView(dgvProductos);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string nombre = txtBusqueda.Text.Trim();
                heap.BuscarPorNombre(nombre, dgvProductos);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Por favor, seleccione una cantidad mayor a 0.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar el MessageBox y capturar el resultado
            DialogResult confirmResult = MessageBox.Show(
                $"¿Desea agregar el producto al carrito con cantidad: {nudCantidad.Value}?",
                "Agregar Producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar si el usuario seleccionó "Yes"
            if (confirmResult == DialogResult.Yes)
            {
                

                // Verificar que se haya seleccionado una fila en el DataGridView
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    // Crear un nuevo nodo con los datos seleccionados
                    Nodo nodo = new Nodo
                    {
                        ID = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ID"].Value),
                        Name = dgvProductos.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                        Datos = new Dictionary<string, object>
                {
                    { "Nombre", dgvProductos.SelectedRows[0].Cells["Nombre"].Value },
                    { "Marca", dgvProductos.SelectedRows[0].Cells["Marca"].Value },
                    { "Precio", dgvProductos.SelectedRows[0].Cells["Precio"].Value },
                    { "Porcentaje de Descuento", dgvProductos.SelectedRows[0].Cells["Porcentaje de Descuento"].Value },
                    { "Precio Con Descuento", dgvProductos.SelectedRows[0].Cells["Precio Con Descuento"].Value },
                    { "Cantidad", nudCantidad.Value }
                }
                    };

                    // Agregar el nodo a la lista compartida
                    CarritoData.ListaNodos.AñadirNodo(nodo);
                    nudCantidad.Value = 1; // Resetear la cantidad a 1 después de agregar al carrito

                    MessageBox.Show("Producto agregado al carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para agregar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El producto no fue agregado al carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}
