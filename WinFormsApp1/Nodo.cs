using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace proyecto
{
    public class Nodo
    {
        public int ID { get; set; }  // ID ahora es de tipo int
        public Dictionary<string, object> Datos { get; set; }

        public Nodo(int id, Dictionary<string, object> datos)
        {
            ID = id;
            Datos = datos;
        }

        public Nodo()
        {
            Datos = new Dictionary<string, object>();
        }

    }
}
