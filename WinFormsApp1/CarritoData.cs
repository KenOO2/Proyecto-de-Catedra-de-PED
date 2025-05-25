using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace proyecto
{
    public static class CarritoData
    {
        // Lista compartida entre los formularios
        public static ListaEnlazada ListaNodos = new ListaEnlazada();
    }

}
