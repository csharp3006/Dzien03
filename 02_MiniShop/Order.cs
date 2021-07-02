using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    /// <summary>
    /// Przechowuje informacje o zamówieniu
    /// </summary>
    class Order
    {
        // typ wyliczeniowy dla statusu zamowienia
        enum OrderStatus
        {
            NewOrder = 10,
            Complete = 20, 
            Confirmed = 30,
            Shipped = 40,
            Returned = 50,
            Cancelled = 60
        }

        private string orderNumber;
        private string customerName;
        private string shipAddress;
        private DateTime orderDate;
        private int discount = 0;
        private OrderStatus status = OrderStatus.NewOrder;
        private List<OrderItem> items = new List<OrderItem>(10); //utworzona pusta lista

        /// <summary>
        /// Czyści listę pozycji zamówienia
        /// </summary>
        /// <returns>True, jeśli udało się usunąć. False - zamówienie w innym statusie niż NewOrder</returns>
        public bool Clear()
        {
            if (status==OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            return false;
        }

        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ProductName.Equals(product.Name)) {
                    return i;
                }
            }
            return result;
        }

        public bool AddProduct(Product product, uint qnty)
        {
            // warunek 
            if (!(status==OrderStatus.NewOrder && qnty>0 && product!=null))
                return false;

            //kontynuuj dodawanie
            //int productIndex = GetProductIndex(product);
            int productIndex = items.FindIndex(x => x.ProductName.Equals(product.Name) );
            if (productIndex == -1)
            {
                items.Add(new OrderItem(product, qnty));
            } else
            {
                items[productIndex].Qnty += qnty;
            }

            return true;
        }

        public bool RemoveProduct(Product product, uint qnty=0)
        {
            // warunek 
            if (!(status == OrderStatus.NewOrder && qnty >= 0 && product != null))
                return false;

            //int productIndex = GetProductIndex(product);
            int productIndex = items.FindIndex(x => x.ProductName.Equals(product.Name));
            if (productIndex == -1) return false; // nie znaleziono produktu

            //zabezpieczenie na okolicznosc podania qnty > niż bieżacy stan dla poz. zamówienia
            if (qnty > items[productIndex].Qnty) return false;

            //usuwanie, gdy qnty rowne 0 lub qnty jest równe bieżacej liczbie produktu w zamówienia
            if (qnty==0 || qnty==items[productIndex].Qnty)
            {
                items.RemoveAt(productIndex);
                return true;
            }

            items[productIndex].Qnty -= qnty;
            return true;
        }
    
        public double CalcTotalAmount()
        {
            double amount = 0.0;
            //foreach (var item in items) { amount += item.Qnty * item.ProductPrice; }
            items.ForEach(x => amount += x.Qnty * x.ProductPrice );
            // aplikacja znizki
            if (discount>0 && discount<100)
            {
                amount *= (100 - discount) / 100.0;
            }
            return amount;
        }

        public void Print()
        {
            Console.WriteLine("Pozycje zamówienia");
            items.ForEach(e => Console.WriteLine("{0,-40}|{1,10}|{2,10:0.00}|{3,12:0.00}",
                    e.ProductName, e.Qnty, e.ProductPrice, e.Qnty * e.ProductPrice) );

            Console.WriteLine("Do zapłaty: {0}", CalcTotalAmount() );
        }
    }
}
