using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoAPI
    {
        public List<Producto> getAll()
        {
            Datos.agregar(new Producto (1,"2",5));
            return Datos.listaProductos;
        }
        public Producto getById(int id)
        {
            return new Producto(1, "2", 3);
        }
        public void update(Producto producto) {}
        public void delete(int id) { }
        public Producto post (Producto producto)
        {
            Datos.agregar(producto);
            return producto;
        }
    }
}
