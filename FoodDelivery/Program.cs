using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChicken = int.Parse(Console.ReadLine());
            int numberOfFish = int.Parse(Console.ReadLine());
            int numberOfVegetarian = int.Parse(Console.ReadLine());

            double deliveryfee = 2.50;
            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double vegetarianPrice = 8.15;

            double totalChickenCost = numberOfChicken * chickenPrice;
            double totalFishCost = numberOfFish * fishPrice;
            double totalVegetarianCost = numberOfVegetarian * vegetarianPrice;

            double orderCost = totalChickenCost + totalFishCost + totalVegetarianCost;
            double dessertPrice = orderCost * 0.2;

            double totalOrderCost = orderCost + dessertPrice + deliveryfee;

            Console.WriteLine(totalOrderCost);
        }
    }
}
