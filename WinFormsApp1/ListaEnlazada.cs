using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public class ListaEnlazada
    {
        public List<Nodo> nodos;

        public ListaEnlazada()
        {
            nodos = new List<Nodo>();
        }

        // Función para llenar el DataGridView

        public void LlenarDataGridView(DataGridView dataGridView1) 
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (nodos.Count > 0)
            {
                // Crear columnas dinámicamente a partir de los datos del primer nodo
                foreach (var clave in nodos[0].Datos.Keys)
                {
                    dataGridView1.Columns.Add(clave, clave);
                }

                // Llenar filas con los datos de los nodos
                foreach (var nodo in nodos)
                {
                    var valores = new List<object>();
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
        public void ActualizarNodoPorID(int id, Dictionary<string, object> nuevosDatos)
        {
            foreach (var nodo in nodos)
            {
                if (nodo.ID == id)
                {
                    nodo.Datos = nuevosDatos;
                    break;
                }
            }
        }

        // Buscar nodo por ID
        public Nodo BuscarNodoPorID(int id)
        {
            return nodos.Find(n => n.ID == id);
        }

        public void Vaciar()
        {
            nodos.Clear();  
        }


    }
}
