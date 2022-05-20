using System;

namespace vn_mode_csharp_dz12
{
    class Program
    {
        static void Main(string[] args)
        {
            float rub = 1000;
            float usd = 200;
            float eur = 100;
            float rubToUsd = 0.0135f;
            float usdToRub = 71;
            float rubToEur = 0.0123f;
            float eurToRub = 78;
            float usdToEur = 0.91f;
            float eurToUsd = 1.14f;
            float currencyCount;
            string userInput;

            Console.WriteLine($"Добро пожаловать в наш конвертер валют!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваш баланс:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"RUB = {rub}\nUSD = {usd}\nEUR = {eur}");
            Console.WriteLine("Если вы хотите обменять рубли на доллары введите 1: ");
            Console.WriteLine("Если вы хотите обменять доллары на рубли введите 2: ");
            Console.WriteLine("Если вы хотите обменять рубли на евро введите 3: ");
            Console.WriteLine("Если вы хотите обменять евро на рубли введите 4: ");
            Console.WriteLine("Если вы хотите обменять доллары на евро введите 5: ");
            Console.WriteLine("Если вы хотите обменять евро на доллары введите 6: ");
            Console.WriteLine("Если вы хотите выйти введите 0: ");
            userInput = Console.ReadLine();

            while (userInput != "0")
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Сколько вы хотите обменять рублей на доллары?");
                        userInput = Console.ReadLine();
                        if (rub >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * rubToUsd;
                            rub -= Convert.ToSingle(userInput);
                            usd += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно рублей для обмена.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Сколько вы хотите обменять долларов на рубли?");
                        userInput = Console.ReadLine();
                        if (usd >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * usdToRub;
                            usd -= Convert.ToSingle(userInput);
                            rub += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно долларов для обмена.");

                        }
                        break;
                    case "3":
                        Console.WriteLine("Сколько вы хотите обменять рублей на евро?");
                        userInput = Console.ReadLine();
                        if (rub >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * rubToEur;
                            rub -= Convert.ToSingle(userInput);
                            eur += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно рублей для обмена.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Сколько вы хотите обменять евро на рубли?");
                        userInput = Console.ReadLine();
                        if (eur >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * eurToRub;
                            eur -= Convert.ToSingle(userInput);
                            rub += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно евро для обмена.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Сколько вы хотите обменять долларов на евро?");
                        userInput = Console.ReadLine();
                        if (usd >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * usdToEur;
                            usd -= Convert.ToSingle(userInput);
                            eur += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно долларов для обмена.");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Сколько вы хотите обменять евро на дооллары?");
                        userInput = Console.ReadLine();
                        if (eur >= Convert.ToSingle(userInput))
                        {
                            currencyCount = Convert.ToSingle(userInput) * eurToUsd;
                            eur -= Convert.ToSingle(userInput);
                            usd += currencyCount;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Успешно!");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine("У вас недостаточно евро для обмена.");

                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели несуществующую команду. Попробуйте ещё раз: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        userInput = Console.ReadLine();
                        break;

                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваш баланс:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"RUB = {rub}\nUSD = {usd}\nEUR = {eur}");
                Console.WriteLine("Если вы хотите обменять рубли на доллары введите 1: ");
                Console.WriteLine("Если вы хотите обменять доллары на рубли введите 2: ");
                Console.WriteLine("Если вы хотите обменять рубли на евро введите 3: ");
                Console.WriteLine("Если вы хотите обменять евро на рубли введите 4: ");
                Console.WriteLine("Если вы хотите обменять доллары на евро введите 5: ");
                Console.WriteLine("Если вы хотите обменять евро на доллары введите 6: ");
                Console.WriteLine("Если вы хотите выйти введите 0: ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Вы вышли из нашего конвертера. До свидания.");
        }
    }
}
