using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2.Entities
{
    class BookOrder
    {
        private Book book;
        private int numOfCopies;
  
        //Add necessary properties 

        public BookOrder(Book book, int numOfCopies)
        {
            this.Book = book;
            this.NumOfCopies = numOfCopies;
        }

        public int NumOfCopies
        {
            get
            {
                return numOfCopies;
            }

            set
            {
                numOfCopies = value;
            }
        }

        public Book Book
        {
            get
            {
                return book;
            }

            set
            {
                book = value;
            }
        }
    }
}
