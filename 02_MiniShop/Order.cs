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
            int productIndex = GetProductIndex(product);
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
            return false;
        }
    }
}
