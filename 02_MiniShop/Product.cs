using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    /// <summary>
    /// Klasa opisująca produkt jednostkowy
    /// </summary>
    class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr = String.Empty; // ""
        private Boolean promo = false;
        private Boolean active = true;

        public Boolean Active
        {
            get { return active; }
        }

        public double Price
        {
            get { return price; }
        }

        public Product(int id, string name, double price, string descr="")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }

        public void SetActive(bool active)
        {
            this.active = active;
        }

        public bool GetActive()
        {
            return active;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", id, name, price);
        }


    }
}
