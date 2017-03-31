using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Midterm2.Entities;

namespace Midterm2
{
    class BookStore
    {
        static void Main(string[] args)
        {
            Book[] books = availableBooks();                 //get an array of available books:
            ShoppingCart shoppingCart = new ShoppingCart();
            
            bool finish = false;
            do
            {
                System.Console.WriteLine();
                System.Console.Write("Enter your book choice (0 - {0}): ", books.Length - 1);      
                int userSelection = Convert.ToInt32(Console.ReadLine());

                if (userSelection > 4)
                {
                    finish = true;
                   
                }
                else
                {
                    BookOrder bookOrder;
                    System.Console.Write("Enter number of copies to buy: ");
                    int numberOfCopies = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    bookOrder = new BookOrder(books[userSelection] as Book, numberOfCopies);
                    shoppingCart.AddBookOrder(bookOrder);
                    Console.WriteLine(numberOfCopies + " copy of " + "\"" + (books[userSelection] as Book).Title + "\" added to your shopping cart.");      
                }
                //Add your implementations to continuously prompt the user to
                //select a book, specify the number of copies to buy and 
                //add the selected book to the shopping cart as required, until the user entered anything other than 0 - 5.

            } while (!finish);


            System.Console.WriteLine();

            ArrayList ordersInCart = shoppingCart.BookOrders;
            Console.WriteLine("You have placed the following books in your shopping cart:");
            Console.WriteLine();
            double totalPrice = 0.0;
            foreach (BookOrder item in ordersInCart)
            {
                totalPrice += (item.Book.Price) * item.NumOfCopies;
                Console.WriteLine("    " + item.NumOfCopies + " copy (copies) of " + "\"" + item.Book.Title + "\" added to your shopping cart.");
            }
            Console.WriteLine();
            Console.WriteLine("    The total cost is $" + totalPrice);
            Console.WriteLine();
            //Add your implementation to display the books in the shopping cart (the title and number of copies) as required.




            //Add your implementation to invoke method (see below) saveShoppingCart(...) to save the shopping cart. 
            //You will have to complete the implementation of the method saveShoppingCart(...) given below.
            saveShoppingCart(shoppingCart);


            System.Console.WriteLine("You shopping cart has been saved. Press return key to exit the application");
            System.Console.ReadLine();
        }

        private static Book[] availableBooks()
        {
            Book[] books = new Book[5];    
            books[0] = new Book("Object Oriented Programming in C#", 45.5);
            books[1] = new Book("Web Programming in PHP", 24.9);
            books[2] = new Book("ASP.NET Web Application Development", 30.0);
            books[3] = new Book("Java Programming in 21 Days", 37.0);
            books[4] = new Book("Advanced Database Topics", 19.9);

            System.Console.WriteLine(" ---------------------------------------------");
            System.Console.WriteLine(" -    Algonquin College Online Book Store    -");
            System.Console.WriteLine(" ---------------------------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("The following books are available:");
            System.Console.WriteLine();

            int count = 0;
            foreach (Book item in books)
            {
                
                System.Console.WriteLine(count +". " + item.Title + " --- $" + item.Price);
                count++;


            }            
            //Add your implementation to show user the list of available books


            return books; 
        }

        private static void saveShoppingCart(ShoppingCart shoppingCart)
        {
            StreamWriter sw = null;
            try
            {
                if (!Directory.Exists(@"/Users/jj/Desktop/temp/BookStore"))
                {
                    Directory.CreateDirectory(@"/Users/jj/Desktop/temp/BookStore");
                }

                FileStream aFile = new FileStream(@"/Users/jj/Desktop/temp/BookStore/ShoppingCart.txt", FileMode.Create);
                sw = new StreamWriter(aFile);

                ArrayList ordersInCart = shoppingCart.BookOrders;
                foreach (BookOrder item in ordersInCart)
                {
                    sw.WriteLine(item.Book.Title);
                    sw.WriteLine(item.NumOfCopies);                  
                }
                //Add your implementation to create a new file "c:\BookStore\ShoppingCart.txt" and save the shopping cart contents into the file.

            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
                //Add your implementation to handle file IO exception.
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                //Add your implementation to close the file and release resources
            }
        }
    }

  
}
