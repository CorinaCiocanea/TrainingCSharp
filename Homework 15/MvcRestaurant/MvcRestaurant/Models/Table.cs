using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestaurant.Models
{
    public enum Status
    {
        Free,
        Occupied,
        Reserved

    }
    public class Table
    {
        public int TableId { get; set; }
        public int DimensionTable { get; set; }
        public Status Status { get; set; }
        public Coords CoordinatesTable { get; set;}
    }
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}