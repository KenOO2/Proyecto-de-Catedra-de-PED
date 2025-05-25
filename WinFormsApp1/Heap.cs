using proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Heap
    {
        private List<Nodo> heap;

        public Heap()
        {
            heap = new List<Nodo>();
        }

        // Agrega un nodo al heap y lo ordena
        public void Agregar(Nodo nuevoNodo)
        {
            if (!nuevoNodo.Datos.TryGetValue("Porcentaje de Descuento", out var descuento) || !(descuento is int))
            {
                throw new ArgumentException("El nodo no tiene un campo 'Porcentaje de Descuento' válido.");
            }

            heap.Add(nuevoNodo);
            OrdenarHeap();
        }

        // Busca un nodo por nombre
        public void BuscarPorNombre(string nombre, DataGridView dgv)
        {
            // Buscar el nodo por nombre
            var nodoEncontrado = heap.Find(nodo => nodo.Name.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            // Limpiar el DataGridView
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            if (nodoEncontrado == null)
            {
                MessageBox.Show($"No se encontró ningún nodo con el nombre '{nombre}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear columnas basadas en las claves del Dictionary
            dgv.Columns.Add("ID", "ID");
            foreach (var clave in nodoEncontrado.Datos.Keys)
            {
                dgv.Columns.Add(clave, clave);
            }

            // Agregar los datos del nodo encontrado al DataGridView
            var fila = new List<object> { nodoEncontrado.ID };
            foreach (var clave in nodoEncontrado.Datos.Keys)
            {
                fila.Add(nodoEncontrado.Datos[clave]);
            }

            dgv.Rows.Add(fila.ToArray());
        }


        // Obtiene todos los nodos ordenados por descuento (de mayor a menor)
        public List<Nodo> ObtenerNodosOrdenados()
        {
            return new List<Nodo>(heap);
        }

        public void LlenarDataGridView(DataGridView dgv)
        {
            // Limpiar el DataGridView
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            int count = ObtenerNodosOrdenados().Count;
            List<Nodo> nodosOrdenados = ObtenerNodosOrdenados();

            if (count == 0)
            {
                MessageBox.Show("El heap está vacío. Asegúrate de llenarlo antes de mostrar los datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener las claves del Dictionary del primer nodo para crear las columnas
            var primerNodo = nodosOrdenados.FirstOrDefault();
            if (primerNodo != null)
            {
                dgv.Columns.Add("ID", "ID");
                foreach (var clave in primerNodo.Datos.Keys)
                {
                    dgv.Columns.Add(clave, clave);
                }
            }

            // Llenar el DataGridView con los datos de los nodos
            foreach (var nodo in nodosOrdenados)
            {
                var fila = new List<object> { nodo.ID};

                foreach (var clave in nodo.Datos.Keys)
                {
                    fila.Add(nodo.Datos[clave]);
                }

                dgv.Rows.Add(fila.ToArray());
            }
        }


        // Ordena el heap en función del descuento (de mayor a menor)
        private void OrdenarHeap()
        {
            heap.Sort((nodo1, nodo2) => ObtenerDescuento(nodo2).CompareTo(ObtenerDescuento(nodo1)));
        }

        // Obtiene el valor del descuento de un nodo
        private int ObtenerDescuento(Nodo nodo)
        {
            return nodo.Datos.TryGetValue("Porcentaje de Descuento", out var descuento) && descuento is int
                ? (int)descuento
                : throw new InvalidOperationException("El nodo no tiene un campo 'Porcentaje de Descuento' válido.");
        }
    }

}
