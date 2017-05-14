using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.OwnerName = "User 1";
            card.AddMoney(100.5m);

            BookShop shop = new BookShop();
            shop.BuyBook("Nume carte 1", card);
            shop.BuyBook("Nume carte 2", card);
            shop.BuyBook("Nume carte 3", card);
            shop.BuyBook("Nume carte 4", card);
            shop.BuyBook("Nume carte 1", card);
            shop.BuyBook("Nume carte 2", card);
            shop.BuyBook("Nume carte 3", card);

            Console.ReadLine();
        }
    }
}
