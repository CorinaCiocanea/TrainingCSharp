using System;

namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1:
            int x = 0;
            int y = x;
            x = 2;
            Console.WriteLine("X is {0}", x);
            Console.WriteLine("Y is {0}", y);

            //Example 2:
            Student s1 = new Student();
            Student s2 = s1;
            s1.Age = 20;
            Console.WriteLine("Student s1 has age {0}", s1.Age);
            Console.WriteLine("Student s2 has age {0}", s2.Age);

            //Example 3:
            Point p = new Point();
            Console.WriteLine("My point {0}, {1}", p.X, p.Y);
            ChangePoint(p);
            Console.WriteLine("My point {0}, {1}", p.X, p.Y);

            //Example 4
            ChangeStudent(s1);
            Console.WriteLine("My student {0}", s1.Age);

            //Example 5:
            ChangeReferencePoint(ref p);
            Console.WriteLine("My point {0}, {1}", p.X, p.Y);
        }

        public static void ChangeStudent(Student myStudent)
        {
            myStudent.Age += 1;
            Console.WriteLine("My student {0}", myStudent.Age);
        }

        public static void ChangePoint(Point myPoint)
        {
            myPoint.X = 21;
            myPoint.Y = 22;
            Console.WriteLine("My point {0}, {1}", myPoint.X, myPoint.Y);
        }

        public static void ChangeReferencePoint(ref Point myPoint)
        {
            myPoint.X = 21;
            myPoint.Y = 22;
            Console.WriteLine("My point {0}, {1}", myPoint.X, myPoint.Y);
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
