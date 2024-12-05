namespace TumakovLabs.TumakovLabs.Classes;

public class Building
{
    private static int IndividualNum = 0; 
    private readonly int buildingNum; 
    private double height; 
    private int floor; 
    private int flat; 
    private int paradnie; // подъезды
    
    public Building(double height, int floors, int flat, int paradnie)
    {
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
    
    public double CalculateFloorHeight()
    {
        if (floor > 0)
            return height / floor;
        else
            throw new InvalidOperationException("Этажность должна быть больше нуля.");
    }
    
    public int CalculateFlatInParadnie()
    {
        if (paradnie > 0)
            return flat / paradnie;
        else
            throw new InvalidOperationException("Количество подъездов должно быть больше нуля.");
    }
    
    public int CalculateFlatPerFloor()
    {
        if (floor > 0)
            return flat / floor;
        else
            throw new InvalidOperationException("Этажи не могут быть равны нулю");
    }
}
