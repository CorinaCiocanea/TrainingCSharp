using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListGeneric
{
   public class SortedList<T> where T : IComparable
    {
      
       public List<T> list = new List<T>();
       public int n;
   
       public void Add(T item)
       {
           list.Add(item);
       }

       public T GetMax()
       {
           T max = default(T);
           foreach (T item in list)
           {
               if (item.CompareTo(max) > 0)
               {
                   max = item;
               }

           }
            return max;
       }

       public T GetMin()
       {
           T min = default(T);
           foreach (T item in list)
           {
               if (item.CompareTo(min) < 0)
               {
                   min = item;
               }

           }
           return min;
       }

       public IEnumerable<T> GetItems(Direction direction)
       {
           if (direction == Direction.Asc)
           {
               list.Sort((a, b) => a.CompareTo(b));
           }
           else
           {
               list.Sort((a, b) => (-1) * a.CompareTo(b));
           }
           return list;
       }


       public IEnumerator<T> GetEnumerator()
       {
           return list.GetEnumerator();
       }
       

    }
   public enum Direction
   { 
     Asc,
     Desc
   }
}
