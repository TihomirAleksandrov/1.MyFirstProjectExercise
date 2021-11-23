using System;

namespace MyFirstProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double course = 1.79549;

            double BGN = dollars * course;
            Console.WriteLine(BGN);
        }
    }
}
