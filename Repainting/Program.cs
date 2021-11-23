using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonPrice = 1.50;
            double paintPrice = 14.50;
            double thinnerPrice = 5.00;

            double totalPaintNeeded = paintNeeded + (paintNeeded * 0.10);
            int totalNylonNeeded = nylonNeeded + 2;
            double bags = 0.40;

            double totalNylonPrice = totalNylonNeeded * nylonPrice;
            double totalPaintPrice = totalPaintNeeded * paintPrice;
            double totalThinnerPrice = thinnerNeeded * thinnerPrice;

            double materialsPrice = totalNylonPrice + totalPaintPrice + totalThinnerPrice + bags;
            double workersPrice = (materialsPrice * 0.3) * hoursNeeded;
            double totalSumNeeded = materialsPrice + workersPrice;

            Console.WriteLine(totalSumNeeded);
        }
    }
}
