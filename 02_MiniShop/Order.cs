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

        public bool AddProduct(Product product, uint qnty)
        {
            return false;
        }

        public bool RemoveProduct(Product product, uint qnty=0)
        {
            return false;
        }
    }
}
