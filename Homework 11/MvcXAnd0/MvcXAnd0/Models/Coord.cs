using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcXAnd0.Models
{
    public enum CoordX
    {
     a = 0,
      b = 1,
      c = 2
    };
    public enum CoordY
    {
        a = 0,
        b = 1,
        c = 2
    };
    public enum Player
    {
      X,
      O
    }
    public class Coord
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public Player? Player { get; set; }
       
    }
}