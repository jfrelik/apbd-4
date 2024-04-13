namespace Klinika.Visit;

public class Visit
{
    public DateTime Date { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }
    
    public Visit(DateTime date, int animalId, string description, double cost)
    {
        Date = date;
        AnimalId = animalId;
        Description = description;
        Cost = cost;
    }
}