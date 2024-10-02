using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }

        public Producto(int ID, string TITILE, int PRICE)
        {
            this.id= ID;
            this.title= TITILE;
            this.price= PRICE;

        }


    }
}
