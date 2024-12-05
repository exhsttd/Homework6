namespace TumakovLabs.TumakovLabs.Classes;

public class Building
{
    // Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
    // высота, этажность, количество квартир, подъездов). Поля сделать закрытыми
    private static int IndividualNum = 0; // в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания
    private readonly int buildingNum; 
    private double height; 
    private int floor; 
    private int flat; 
    private int paradnie; // подъезды
    
    public Building(double height, int floors, int flat, int paradnie)
    {
        // Предусмотреть возможность, чтобы уникальный номер здания генерировался программно
        IndividualNum++;
        this.buildingNum = IndividualNum; 
        this.height = height;
        this.floor = floors;
        this.flat = flat;
        this.paradnie = paradnie;
    }
    
    public void GetBuildingDetails()
    {
        Console.WriteLine($"Номер здания: {buildingNum}");
        Console.WriteLine($"Высота: {height} м");
        Console.WriteLine($"Количество этажей: {floor} этажей");
        Console.WriteLine($"Количество квартир: {flat}");
        Console.WriteLine($"Количество подъездов: {paradnie}");
    }
    
    // Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.:
    public double CalculateFloorHeight()
    {
        if (floor > 0)
        {
            return height / floor;
        }
        else
        {
            throw new InvalidOperationException("Этажность должна быть больше нуля."); 
        }
    }
    
    public int CalculateFlatInParadnie()
    {
        if (paradnie > 0)
        {
            return flat / paradnie;
        }
        else
        {
            throw new InvalidOperationException("Количество подъездов должно быть больше нуля.");
        }
    }
    
    public int CalculateFlatPerFloor()
    {
        if (floor > 0)
        {
            return flat / floor;
        }
        else
        {
            throw new InvalidOperationException("Этажность должна быть больше нуля.");
        }
    }
}
