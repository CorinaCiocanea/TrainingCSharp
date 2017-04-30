using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConsole
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return side * side;
        }
    }

    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : Shape
    {
        private int baseLenght;
        private int height;
        public Triangle(int baseLenght, int height)
        {
            this.baseLenght = baseLenght;
            this.height = height;
        }
        public override double GetArea()
        {
            return height * baseLenght/2;
        }
    }
}
