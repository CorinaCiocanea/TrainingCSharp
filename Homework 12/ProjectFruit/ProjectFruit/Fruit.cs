using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFruit
{
  public abstract class Fruit
    {
        private bool withSeeds = false;
        public string fruitWithSeeds { get; set; }
        public string fruitWithoutSeeds { get; set; }
             

        public Fruit(bool withSeeds)
        {
            this.withSeeds = withSeeds;
        }
        public int getDescription(int[] fruitArray, int key)
        {
            int min = 0;
            int max = fruitArray.Length - 1;
            while (min <= max)
            {
                int m = min + (max - min)/2;
                if (key == fruitArray[m])
                {
                    return m;
                  
                }
                else if (key < fruitArray[m])
                {
                    max = m - 1;
                }
                else
                {
                    min = m + 1;
                }
            
            }
            return -1;
          
        }
        public string isWithSeeds()
        {
            withSeeds = false;
            if (withSeeds == true)
            {
                return fruitWithSeeds;
            }
            else
            {
                return fruitWithoutSeeds;
            }
          
        }
    }
}
