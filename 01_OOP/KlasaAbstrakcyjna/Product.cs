using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    class Product : AbstractProduct
    {
        private String barcode;
        public Product(String name, double price, String barcode) : base(name, price)
        {
            this.barcode = barcode;
        }

        public override void ShowPrice()
        {
            Console.WriteLine("cena produkt={0}", price);
        }
    }
}
