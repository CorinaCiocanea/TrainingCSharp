using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeworkConsole
{
    class Solutie
    {
        public static void PrintSolution()
        {
            System.Console.WriteLine("Give file path:");
            string fileName = System.Console.ReadLine();
            List<Shape> shapes = new List<Shape>();

            using (StreamReader reader = new StreamReader(File.Open(fileName, FileMode.Open)))
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    switch (values[0])
                    {
                        case "circle":
                            shapes.Add(new Circle(int.Parse(values[1])));
                            break;
                        case "triangle":
                            shapes.Add(new Triangle(int.Parse(values[1]), int.Parse(values[2])));
                            break;
                        case "square":
                            shapes.Add(new Square(int.Parse(values[1])));
                            break;
                    }
                }
            }
            System.Console.WriteLine();

            System.Console.WriteLine("We found {0} number of shapes", shapes.Count());

            for (int i = 1; i <= shapes.Count(); i++)
            {
                System.Console.WriteLine("Shape with number {0} has area {1}", i, shapes[i - 1].GetArea());
            }

            System.Console.ReadLine();
        }
    }
}
