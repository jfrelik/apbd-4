namespace Klinika.Animal
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals();
        
        Animal? GetAnimalById(int id);
        
        Animal AddAnimal(Animal animal);
        
        Animal? UpdateAnimal(Animal animal);
        
        Animal? DeleteAnimal(int id);   
    }
}