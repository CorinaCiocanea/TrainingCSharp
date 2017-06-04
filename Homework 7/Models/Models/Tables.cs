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
     public class Tables
    {
        private string description;
        private int dimension;
        private Status status;
        private Coords Coordinates;

        public Status Status
        {
            get 
            {
                return status;
            }
            set
            {
                status = value;
            }
        
        }
        
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
