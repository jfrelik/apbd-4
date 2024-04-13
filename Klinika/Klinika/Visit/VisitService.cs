namespace Klinika.Visit;

public class VisitService: IVisitService
{
    private List<Visit> _visits = new List<Visit>();
    
    public VisitService()
    {
        _visits.Add(new Visit(new DateTime(2021, 1, 1), 1, "First visit", 100));
        _visits.Add(new Visit(new DateTime(2021, 1, 2), 1, "Second visit", 200));
        _visits.Add(new Visit(new DateTime(2021, 1, 3), 2, "First visit", 150));
    }
    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId)
    {
        return _visits.FindAll(x => x.AnimalId == animalId);
    }
    
    public Visit AddVisit(Visit visit)
    {
        _visits.Add(visit);
        return visit;
    }
}