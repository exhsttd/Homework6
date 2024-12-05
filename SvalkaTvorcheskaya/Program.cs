using System;
using System.Collections.Generic;
using SvalkaTvorcheskaya.ProjectSvalka.Classes;

// Творческая домашка на тему - свалка. Приведены три вида свалок и примеры процесса их очищения
class Program
{
    static void Main()
    {
        List<AbstraktnayaSvalka> waste = new List<AbstraktnayaSvalka>()
        {
            new PoligonTBO("Полигон ТБО", "Приволжский район"),
            new BioreaktorPoligon("Биореакторный полигон", "Химическая улица"),
            new PoligonPromyshlenny("Полигон промышленных отходов", "Советский район")
        };
    
        foreach (AbstraktnayaSvalka dump in waste) 
        {
            dump.DisplayInfo();
            dump.AcceptWaste(10);
            dump.PrintLocation();
            Console.WriteLine(); 
        }

        // Пример очистки мусора на одной из свалок
        PoligonTBO tboWaste = (PoligonTBO)waste[0]; 
        tboWaste.DropWaste();
    }
}
