﻿using System.IO;

namespace HomeworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give file path:");
            string fileName = System.Console.ReadLine();

            using (StreamReader reader = new StreamReader(File.Open(fileName, FileMode.Open)))
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                }
            }
        }
    }
}
