using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double sneakersPrice = trainingFee - (trainingFee * 0.4);
            double kitPrice = sneakersPrice - (sneakersPrice * 0.2);
            double basketballPrice = kitPrice * 0.25;
            double accessoriesPrice = basketballPrice * 0.2;

            double totalExpenses = trainingFee + sneakersPrice + kitPrice + basketballPrice + accessoriesPrice;

            Console.WriteLine(totalExpenses);
        }
    }
}
