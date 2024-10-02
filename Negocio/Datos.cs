using Negocio.Models;

namespace Negocio
{
    internal class Datos
    {
        static public List<Producto> listaProductos = new List<Producto>() { };

        static public void agregar(Producto producto)
        {
            listaProductos.Add(producto);
        }
    }
}