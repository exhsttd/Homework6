using System;
using System.Collections.Generic;

namespace SvalkaTvorcheskaya.ProjectSvalka.Classes
{
    public abstract class AbstraktnayaSvalka
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public abstract void DisplayInfo();
        public abstract void AcceptWaste(double weight);

        public void PrintLocation()
        {
            Console.WriteLine($"Свалка расположена в: {Location}");
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    // Класс для полигонов ТБО
    public class PoligonTBO : AbstraktnayaSvalka
    {
        public double TBOWaste { get; private set; } 
        public PoligonTBO(string name, string location)
        {
            Name = name;
            Location = location;
            TBOWaste = 0;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Полигон ТБО: {Name}, его расположение: {Location}, вес твердых бытовых отходов: {TBOWaste} кг");
        }

        public override void AcceptWaste(double weight)
        {
            TBOWaste += weight;
            Console.WriteLine($"Принято {weight} кг твердых бытовых отходов. Текущий вес: {TBOWaste} кг.");
        }

        public double CalculateFee() 
        {
            return TBOWaste * 0.05;
        }

        public void DropWaste() 
        {
            TBOWaste = 0;
            Console.WriteLine("Твердые бытовые отходы очищены");
        }
    }

    // Класс для биореакторных полигонов
    public class BioreaktorPoligon : AbstraktnayaSvalka
    {
        public double OrganicWaste { get; private set; } 
        public BioreaktorPoligon(string name, string location)
        {
            Name = name;
            Location = location;
            OrganicWaste = 0;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Биореакторный полигон: {Name}, его расположение: {Location}, вес органических отходов: {OrganicWaste} кг");
        }

        public override void AcceptWaste(double weight)
        {
            OrganicWaste += weight;
            Console.WriteLine($"Принято {weight} кг органических отходов. Текущий вес: {OrganicWaste} кг.");
        }

        public double CalculateEfficiency() 
        {
            return OrganicWaste * 0.1; 
        }

        public void DropWaste() 
        {
            OrganicWaste = 0;
            Console.WriteLine("Органические отходы очищены");
        }
    }

    // Класс для полигонов промышленных отходов
    public class PoligonPromyshlenny : AbstraktnayaSvalka
    {
        public double IndustrialWaste { get; private set; } 
        public PoligonPromyshlenny(string name, string location)
        {
            Name = name;
            Location = location;
            IndustrialWaste = 0;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Полигон для захоронения промышленных отходов: {Name}, его расположение: {Location}, вес промышленных отходов: {IndustrialWaste} кг");
        }

        public override void AcceptWaste(double weight)
        {
            IndustrialWaste += weight;
            Console.WriteLine($"Принято {weight} кг промышленных отходов. Текущий вес: {IndustrialWaste} кг.");
        }

        public double CalculateFee() 
        {
            return IndustrialWaste * 0.2; 
        }

        public void DropWaste()
        {
            IndustrialWaste = 0;
            Console.WriteLine("Промышленные отходы очищены");
        }
    }
}