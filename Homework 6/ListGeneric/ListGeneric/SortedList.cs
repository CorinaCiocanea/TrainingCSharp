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

       //public void GetMax(T max)
       //{ 

       //    foreach (T item in list)
       //    {
       //        if (item.CompareTo(max) > 0)
       //        {
       //            max = item;
       //        }
             
       //    }
       //   // return max;
       //}

       public int GetMax(Converter<T, int> projection)
       {
          int maxim = int.MinValue;
          foreach (T item in list)
          {
              int value = projection(item);
              if (value > maxim)
              {
                  maxim = value;
              }
          }
          return maxim;
       }

       public int GetMin(Converter<T, int> projection)
       {
           int minim = int.MaxValue;
           foreach (T item in list)
           {
               int value = projection(item);
               if (value > minim)
               {
                   minim = value;
               }
           }
           return minim;
       }
       //public int GetMin(T min, Converter<T, int> projection)
       //{

       //    foreach (T item in list)
       //    {
       //        if (item.CompareTo(min) < 0)
       //        {
       //            min = item;
       //        }
       //    }
       //    return min;
       //}
       //public void SortAsc(T a, T b)
       //{
       //   list.Sort((a, b) => a.CompareTo(b));
       //    return list;
              
       //}
       public IEnumerator<T> GetEnumerator()
       { 
         return list.GetEnumerator();
       }
       

    }
}
