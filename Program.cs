using System;

namespace HomeAppliancesStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Магазин побутової техніки";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Вітаємо у магазині побутової техніки ---");
            Console.WriteLine("Наявні товари:");
            Console.WriteLine("1. Телевізор Samsung (15000 грн)");
            Console.WriteLine("2. Холодильник Bosch (22000 грн)");
            Console.WriteLine("3. Пральна машина LG (18500 грн)");
            Console.ResetColor();

            double priceTv = 15000.00;
            double priceFridge = 22000.00;
            double priceWasher = 18500.00;

            Console.WriteLine("\nВведіть кількість телевізорів, яку бажаєте придбати:");
            int countTv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість холодильників:");
            int countFridge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість пральних машин:");
            int countWasher = Convert.ToInt32(Console.ReadLine());

            double widthTv = 90; 
            double heightTv = 50; 
            double diagonal = Math.Sqrt(Math.Pow(widthTv, 2) + Math.Pow(heightTv, 2));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nДовідкова інформація: діагональ обраних телевізорів становить " + Math.Round(diagonal, 1) + " см");
            Console.ResetColor();

            double totalSum = (priceTv * countTv) + (priceFridge * countFridge) + (priceWasher * countWasher);

            Random rnd = new Random();
            int discountPercent = rnd.Next(1, 15);
            double discountAmount = totalSum * discountPercent / 100;
            double finalPrice = totalSum - discountAmount;
            double roundedPrice = Math.Round(finalPrice, 2);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Ваше замовлення оброблено.");
            Console.WriteLine("Загальна сума без знижки: " + totalSum + " грн");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваша персональна знижка: " + discountPercent + "%");
            Console.WriteLine("Сума знижки: " + Math.Round(discountAmount, 2) + " грн");
            Console.WriteLine("ДО СПЛАТИ: " + roundedPrice + " грн");
            Console.ResetColor();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Дякуємо за покупку! Натисніть Enter для виходу.");
            Console.ReadLine();
        }
    }
}