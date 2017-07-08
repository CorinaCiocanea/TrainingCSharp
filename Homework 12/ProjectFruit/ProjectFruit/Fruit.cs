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
        public void getDescription(string s)
        {
          
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
