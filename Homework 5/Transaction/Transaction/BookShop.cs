using System;
using System.Collections.Generic;
using System.Linq;

namespace Transaction
{
    public class BookShop
    {
        List<Book> Books { get; set; }
        const int MAX_TRIES = 3;

        public BookShop()
        {
            Books = new List<Book>();
            Books.Add(new Book() { Author = "Autor 1", Name = "Nume carte 1", Price = 12.5m, Quantity = 2 });
            Books.Add(new Book() { Author = "Autor 2", Name = "Nume carte 2", Price = 22.5m, Quantity = 11 });
            Books.Add(new Book() { Author = "Autor 3", Name = "Nume carte 3", Price = 15.1m, Quantity = 9 });
            Books.Add(new Book() { Author = "Autor 4", Name = "Nume carte 4", Price = 36.8m, Quantity = 22 });
        }

        public void BuyBook(string name, Card card)
        {
            Console.WriteLine();
            Console.WriteLine("--" + name + "--");
            Book selectedBook = Books.FirstOrDefault(item => item.Name == name);
            if (selectedBook == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            int tries = 0;

            while (true)
            {
                try
                {
                    tries++;
                    card.Pay(selectedBook.Price);
                    break;
                }
                catch (ConnectionException ex)
                {
                    Console.WriteLine(ex.Message);

                    if (tries == MAX_TRIES)
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }

            Console.WriteLine("Va mai asteptam!");
        }
    }
}
