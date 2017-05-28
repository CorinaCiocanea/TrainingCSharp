using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Status
    {
        Free,
        Occupied,
        Reserved

    }
    class Tables
    {
        private string table;
        private int dimension;
        
        public string Table
        {
            get
            {
                return table;
            }
            set
            {
                table = value;
            }
        }
        public int Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                dimension = value;
            }
        }
        
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
