using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    /// <summary>
    /// Przechowuje informacje o pozycji zamowienia
    /// </summary>
    class OrderItem
    {
        private Product product;
        private uint qnty;

        public OrderItem(Product product, uint qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }
    }
}
