using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public class Card
    {
        private decimal amount = 0.0m;
        Random r = new Random();
        public string OwnerName { get; set; }

        public void Transaction()
        {
        }

        public void AddMoney(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Value cannot be negative");
            }

            amount += value;
        }

        public void Pay(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Value cannot be negative");
            }

            if (value > amount)
            {
                throw new InsufficientFundsException("Not enough money");
            }

            if (GetRandomException())
            {
                throw new ConnectionException("Connection error");
            }

            amount -= value;
        }

        private bool GetRandomException()
        {
            int randomValue = r.Next(1, 10);

            if (randomValue % 3 == 0)
                return true;

            return false;
        }

    }
}
