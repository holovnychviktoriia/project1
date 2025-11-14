// Головнич Вікторія КН-21

using System;
namespace FarmerMarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceApples = 15.50; 
            double priceMilk = 32.00;   
            double priceEggs = 65.00;   
            Console.WriteLine("================================================");
            Console.WriteLine("   Ласкаво просимо до 'Фермерського магазину'!");
            Console.WriteLine("================================================");
            Console.WriteLine("Наші товари:");
            Console.WriteLine("1. Яблука - " + priceApples + " грн/кг");
            Console.WriteLine("2. Молоко - " + priceMilk + " грн/пляшка");
            Console.WriteLine("3. Яйця (10 шт) - " + priceEggs + " грн/уп");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Введіть кількість яблук (кг): ");
            double qtyApples = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кількість пляшок молока: ");
            int qtyMilk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість упаковок яєць: ");
            int qtyEggs = Convert.ToInt32(Console.ReadLine());
            double totalApples = qtyApples * priceApples;
            double totalMilk = qtyMilk * priceMilk;
            double totalEggs = qtyEggs * priceEggs;
            double finalTotal = totalApples + totalMilk + totalEggs;
            double roundedFinalTotal = Math.Round(finalTotal, 2);
            double testNumber = 9;
            double sqrtResult = Math.Sqrt(testNumber);
            double powResult = Math.Pow(2, 3);
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("           ВАШЕ ЗАМОВЛЕННЯ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Яблука: " + totalApples + " грн");
            Console.WriteLine("Молоко: " + totalMilk + " грн");
            Console.WriteLine("Яйця: " + totalEggs + " грн");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Загальна сума (не округлена): " + finalTotal + " грн");
            Console.WriteLine("ЗАГАЛЬНА СУМА ДО СПЛАТИ (округлена): " + roundedFinalTotal + " грн");
            Console.WriteLine("\n--- Демонстрація Math ---");
            Console.WriteLine("Корінь з " + testNumber + " = " + sqrtResult);
            Console.WriteLine("2 в 3 степені = " + powResult);
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}