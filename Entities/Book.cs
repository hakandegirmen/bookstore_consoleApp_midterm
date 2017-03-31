using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2.Entities
{
    class Book
    {
        private string title;
        private double price;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        //Add necessary properties 

        public Book(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }
    }
}
