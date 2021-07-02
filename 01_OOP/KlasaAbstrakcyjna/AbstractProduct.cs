using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    abstract class AbstractProduct
    {
        public abstract void ShowPrice();

        protected String name;
        protected double price;

        public AbstractProduct(String n, double p)
        {
            name = n; price = p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("nazwa: {0}, cena={1}", name, price);
        }
    }
}
