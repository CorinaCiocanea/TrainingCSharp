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
            List<Whateirs> whateir = new List<Whateirs>();
            {
                new Whateirs { Name = "Tim", Id = 2, Coordinator = "Jim" };
                new Whateirs { Name = "Jack", Id = 5, Coordinator = "Ieremia" };
                new Whateirs { Name = "Jerry", Id = 1, Coordinator = "Anton" };
                new Whateirs { Name = "Andre", Id = 3, Coordinator = "Jan" };
                new Whateirs { Name = "Anton", Id = 8, Coordinator = "Filip" };

            };

            List<Tables> tab = new List<Tables>();
            {
                new Tables { Table = "table1", Dimension = 6 };
                new Tables { Table = "table2", Dimension = 8 };
                new Tables { Table = "table3", Dimension = 4 };
                new Tables { Table = "table4", Dimension = 6 };
                new Tables { Table = "table5", Dimension = 8 };
                new Tables { Table = "table6", Dimension = 6 };
                new Tables { Table = "table7", Dimension = 10 };
                new Tables { Table = "table8", Dimension = 6 };
                new Tables { Table = "table9", Dimension = 10 };
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
