using System;
using TumakovLabs.TumakovLabs.Classes;

namespace Laba
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
        }

        static void Task1()
        {
            Console.WriteLine("Упражнение 7.1-3");
            BankAcc.Account account = new BankAcc.Account(6789123.00m, BankAcc.Type.Текущий);
            account.GetAccountDetails();

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1) Положить деньги на счет");
            Console.WriteLine("2) Снять деньги со счета");

            string choice = Console.ReadLine()!;

            if (choice == "1")
            {
                Console.Write("Введите сумму для пополнения: ");
                decimal addmoney;
                while (!decimal.TryParse(Console.ReadLine(), out addmoney) || addmoney <= 0)
                {
                    Console.Write("Введите сумму больше нуля: ");
                }
                account.Money(addmoney);
            }
            else if (choice == "2")
            {
                Console.Write("Введите сумму для снятия: ");
                decimal dropmoney;
                while (!decimal.TryParse(Console.ReadLine(), out dropmoney) || dropmoney <= 0)
                {
                    Console.Write("Введите сумму больше нуля: ");
                }
                account.Drop(dropmoney);
            }
            else
            {
                Console.WriteLine("Нет такого варианта!");
            }
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.WriteLine("Домашнее задание 7.1");
            Building building1 = new Building(50.0, 30, 150, 6);
            Building building2 = new Building(100.0, 30, 150, 10);
            Building[] buildings = new Building[] { building1, building2 };
            foreach (Building building in buildings)
            {
                building.GetBuildingDetails();

                Console.WriteLine($"Высота этажа: {building.CalculateFloorHeight()} метров");
                Console.WriteLine($"Квартир в подъезде: {building.CalculateFlatInParadnie()}");
                Console.WriteLine($"Квартир на этаже: {building.CalculateFlatPerFloor()}");
            }
        }
    }
}

    