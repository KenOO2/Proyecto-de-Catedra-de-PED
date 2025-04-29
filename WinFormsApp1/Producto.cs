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
    public class Producto
    {
        public string IdProducto { get; set; }  
        public string Nomproducto { get; set; } 
        public int IdProveedor { get; set; }
        public decimal Precio { get; set; }
        public int Descuento { get; set; }
        public Producto Siguiente { get; set; }

        public Producto(string id, string nombre, int idProveedor, decimal precio, int descuento)
        {
            IdProducto = id;
            Nomproducto = nombre;
            IdProveedor = idProveedor;
            Precio = precio;
            Descuento = descuento;
        }

        public decimal PrecioConDescuento()
        {
            return Precio * (1 - (Descuento / 100m));
        }
    }
}