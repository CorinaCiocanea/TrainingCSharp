using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcRestaurant.Models
{
    public class SampleData : DropCreateDatabaseAlways<RestaurantEntities>
    {
        protected override void Seed(RestaurantEntities context)
        {
            new List<Table> 
            {
               new Table { DimensionTable = 4, Status=Status.Free },
               new Table { DimensionTable = 2, Status=Status.Occupied },
               new Table { DimensionTable = 6, Status=Status.Reserved },
               new Table { DimensionTable = 4, Status=Status.Occupied },
               new Table { DimensionTable = 8, Status=Status.Reserved },
               new Table { DimensionTable = 2, Status=Status.Free },
               new Table { DimensionTable = 6, Status=Status.Free }
               
            
            
            }.ForEach(a => context.Tables.Add(a));

            new List<Waiter> 
            
            {
                new Waiter { Name = "Jack", NumberEmployee = 5, Coordinator = "Florin" },
                new Waiter { Name = "Jerry", NumberEmployee = 1, Coordinator = "Bontea" },
                new Waiter { Name = "Andre", NumberEmployee = 3, Coordinator = "Florin" },
                new Waiter { Name = "Anton", NumberEmployee = 8, Coordinator = "Bontea" }
            
            }.ForEach(b => context.Waiters.Add(b));
            
            
            //base.Seed(context);
        }
    }
}