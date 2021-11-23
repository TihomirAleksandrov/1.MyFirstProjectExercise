using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int totalTimeNeeded = numberOfPages / pagesPerHour;
            int totalDaysNeeded = totalTimeNeeded / numberOfDays;

            Console.WriteLine(totalDaysNeeded);
        }
    }
}
