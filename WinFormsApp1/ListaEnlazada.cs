using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto
{
    public class ListaEnlazada : IEnumerable<Nodo>
    {
        public List<Nodo> nodos { get; private set; } = new List<Nodo>();

        public ListaEnlazada()
        {
            nodos = new List<Nodo>();
        }

        // Implementación de IEnumerable<Nodo>
        public IEnumerator<Nodo> GetEnumerator()
        {
            return nodos.GetEnumerator();
        }

        // Implementación explícita de IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Función para llenar el DataGridView
        public void LlenarDataGridView(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (nodos.Count > 0)
            {
                // Agregar columnas para ID y Name
                dataGridView1.Columns.Add("ID", "ID");

                // Agregar columnas dinámicas a partir del diccionario Datos
                foreach (var clave in nodos[0].Datos.Keys)
                {
                    dataGridView1.Columns.Add(clave, clave);
                }

                // Llenar filas con los datos de los nodos
                foreach (var nodo in nodos)
                {
                    var valores = new List<object>
                    {
                        nodo.ID, // Agregar el ID
                    };

                    foreach (var valor in nodo.Datos.Values)
                    {
                        valores.Add(valor);
                    }

                    dataGridView1.Rows.Add(valores.ToArray());
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía. No hay datos para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Añadir nodo
        public void AñadirNodo(Nodo nuevoNodo)
        {
            nodos.Add(nuevoNodo);
        }

        // Eliminar nodo por ID
        public void EliminarNodoPorID(int id)
        {
            nodos.RemoveAll(n => n.ID == id);
        }

        // Actualizar nodo por ID
        public void ActualizarNodoPorID(int id, string name, Dictionary<string, object> nuevosDatos)
        {
            foreach (var nodo in nodos)
            {
                if (nodo.ID == id)
                {
                    nodo.Name = name;
                    nodo.Datos = nuevosDatos;
                    break;
                }
            }
        }

        // Buscar nodo por ID
        public void BuscarNodoPorID(int id, DataGridView dgv)
        {
            // Limpiar filas previas para mostrar solo el nodo encontrado
            dgv.Rows.Clear();

            Nodo nodo = nodos.Find(n => n.ID == id);
            if (nodo != null && dgv != null)
            {
                var valores = new List<object>
                {
                    nodo.ID, // Agregar el ID
                };

                // Extraer los valores del diccionario y asegurarse de que coincidan con las columnas existentes
                foreach (var clave in nodo.Datos.Keys)
                {
                    valores.Add(nodo.Datos[clave]);
                }

                // Agregar una nueva fila con los valores del nodo encontrado
                dgv.Rows.Add(valores.ToArray());
            }
            else
            {
                MessageBox.Show("Nodo no encontrado o DataGridView es nulo.");
            }
        }

        // Buscar nodo por Nombre
        public void BuscarNodoPorNombre(string nombre, DataGridView dgv)
        {
            // Limpiar filas previas para mostrar solo el nodo encontrado
            dgv.Rows.Clear();

            Nodo nodo = nodos.Find(n => n.Name == nombre);

            if (nodo != null && dgv != null)
            {
                var valores = new List<object>
                {
                    nodo.ID, // Agregar el ID
                };

                // Extraer los valores del diccionario y asegurarse de que coincidan con las columnas existentes
                foreach (var clave in nodo.Datos.Keys)
                {
                    valores.Add(nodo.Datos[clave]);
                }

                // Agregar una nueva fila con los valores del nodo encontrado
                dgv.Rows.Add(valores.ToArray());
            }
            else
            {
                MessageBox.Show("Nodo no encontrado o DataGridView es nulo.");
            }
        }

        // Vaciar la lista
        public void Vaciar()
        {
            nodos.Clear();
        }
    }
}

