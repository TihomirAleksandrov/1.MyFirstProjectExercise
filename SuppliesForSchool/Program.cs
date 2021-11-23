using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double markersPrice = 7.20;
            double cleanerPrice = 1.20;

            double totalPenPrice = pens * penPrice;
            double totalMarkersPrice = markers * markersPrice;
            double totalCleanerPrice = cleaner * cleanerPrice;

            double totalSum = totalCleanerPrice + totalMarkersPrice + totalPenPrice;
            double totalSumWithDiscount = totalSum - (totalSum * (discountPercentage/100));

            Console.WriteLine(totalSumWithDiscount);
        }
    }
}
