using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    class Card
    {
        private decimal amount = -1.123M;
        public string OwnerName { get; set; }
            
       
        
        

        public void AddMoney(decimal value)
        {
            if (value < 0) 
            
               Console.WriteLine("About to throw an InvalidOperationException");
                     throw new InvalidOperationException();
            
            //this.amount = value;
            
            //public int getID()
            //{
            
            //   return amount;
            //}
     
        
        }
        public void Pay(decimal amount)
        { 
            if (amount < 0)
                 {
                      throw new ArgumentNullException("amount");
                  }
               Console.WriteLine(amount);
          
        }


    }
}
