using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentOfTakenArea = double.Parse(Console.ReadLine());

            int aquariumArea = length * width * height;
            double freeArea = aquariumArea - (aquariumArea * (percentOfTakenArea / 100));
            double areaInLitres = freeArea / 1000;

            Console.WriteLine(areaInLitres);
        }
    }
}
