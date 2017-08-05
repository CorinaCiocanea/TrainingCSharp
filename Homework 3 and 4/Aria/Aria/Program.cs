using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows;
using System.Data;
using System.ComponentModel;

namespace Aria
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileName = "ExempluFormeGeometrice.txt";
            char shapeSeparator = ',';
            string[] allLines = File.ReadAllLines(fileName);
            List<Form> list = new List<Form>();
            foreach (string line in allLines)
            {
                string[] item = line.Split(shapeSeparator);
                switch (item[0])
                {
                    case "circle":
                        {
                            double radius;
                            double.TryParse(item[1], out radius);
                            list.Add(new Circle(radius));

                            break;
                        }
                    case "square":
                        {
                            double side;
                            double.TryParse(item[1], out side);
                            list.Add(new Square(item[0], side));

                            break;
                        }

                    case "rectangle":
                        {
                            double length;
                            double width;
                            double.TryParse(item[1], out length);
                            double.TryParse(item[2], out width);
                            list.Add(new Rectangle(item[0], length, width));

                            break;
                        }
                    case "triangle":
                        {
                            double bSide;
                            double hSide;
                            double.TryParse(item[1], out bSide);
                            double.TryParse(item[2], out hSide);
                            list.Add(new Triangle(item[0], bSide, hSide));

                            break;
                        }

                    default:
                        break;

                }

            }

            foreach (Form form in list)
            {
                Console.WriteLine(string.Format("{0} area is {1}", form.Type, form.GetArea()));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }
    }
}
