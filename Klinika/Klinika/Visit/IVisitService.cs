namespace Klinika.Visit;

public interface IVisitService
{
    IEnumerable<Visit> GetVisitsByAnimalId(int animalId);
    Visit AddVisit(Visit visit);
}