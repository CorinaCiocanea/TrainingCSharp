﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
   public class ClassB
    {
       public void B()
       {
           try
           {
               int value = 1 / int.Parse("0");
           }
           catch (DivideByZeroException ex)
           {
               throw ex;
           }
       }
    }
}
