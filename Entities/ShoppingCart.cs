using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Midterm2.Entities
{
    class ShoppingCart
    {
        private ArrayList bookOrders;

        //Add necessary properties 

        public ShoppingCart()
        {
            BookOrders = new ArrayList();
        }

        public ArrayList BookOrders
        {
            get
            {
                return bookOrders;
            }

            set
            {
                bookOrders = value;
            }
        }

        public void AddBookOrder(BookOrder order)
        {
            BookOrders.Add(order);
            //Add your implementation to add the book order to the book order list.

        }
    }
}
