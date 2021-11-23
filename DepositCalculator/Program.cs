using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposedSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestPerYear = double.Parse(Console.ReadLine());

            double interest = deposedSum * (interestPerYear / 100);
            double interestPerMonth = interest / 12;
            double totalSum = deposedSum + months * interestPerMonth;

            Console.WriteLine(totalSum);
        }
    }
}
