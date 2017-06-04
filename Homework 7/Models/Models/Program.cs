using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
           Whateirs coordinator = new Whateirs { Name = "Tim", Id = 2 };
            List<Whateirs> whateir = new List<Whateirs>()
            {
                coordinator,
                new Whateirs { Name = "Jack", Id = 5, Coordinator = "dtor" },
                new Whateirs { Name = "Jerry", Id = 1, Coordinator = "dasds" },
                new Whateirs { Name = "Andre", Id = 3, Coordinator = "dasd" },
                new Whateirs { Name = "Anton", Id = 8, Coordinator = "dsad" }

            };

            List<Tables> tab = new List<Tables>();
            {
                new Tables { Description = "table1", Dimension = 6 };
                new Tables { Description = "table2", Dimension = 8 };
                new Tables { Description = "table3", Dimension = 4 };
                new Tables { Description = "table4", Dimension = 6 };
                new Tables { Description = "table5", Dimension = 8 };
                new Tables { Description = "table6", Dimension = 6 };
                new Tables { Description = "table7", Dimension = 10 };
                new Tables { Description = "table8", Dimension = 6 };
                new Tables { Description = "table9", Dimension = 10 };
            }

            Coords[] coord = new Coords[] 
            { 
              new Coords(1, 0),
              new Coords(0, 1),
              new Coords(-1, 0),
              new Coords(0, -1),
            };

            Status status = Status.Free;
            switch (status)
            { 
                case Status.Free:
                    Console.WriteLine("Table is free");
                    break;
                case Status.Occupied:
                    Console.WriteLine("Table is occupied");
                    break;
                case Status.Reserved:
                    Console.WriteLine("Table is reserved");
                    break;
            }
        }
    }
}
