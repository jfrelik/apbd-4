namespace Klinika.Animal
{
    public class AnimalService : IAnimalService
    {
        private List<Animal> _animals = new List<Animal>();

        public AnimalService()
        {
            _animals.Add(new Animal("Rex", "Dog", 20, "Brown"));
            _animals.Add(new Animal("Milo", "Cat", 5, "White"));
            _animals.Add(new Animal("Buddy", "Dog", 15, "Black"));
            _animals.Add(new Animal("Luna", "Cat", 4, "Grey"));
        }


        public IEnumerable<Animal> GetAnimals()
        {
            return _animals;
        }

        public Animal? GetAnimalById(int id)
        {
            var animal = _animals.Find(x => x.Id == id);

            return animal ?? null;
        }

        public Animal AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            return animal;
        }

        public Animal? UpdateAnimal(Animal animal)
        {
            var animalToUpdate = _animals.Find(x => x.Id == animal.Id);

            if (animalToUpdate == null) return null;

            animalToUpdate.Name = animal.Name;
            animalToUpdate.Species = animal.Species;
            animalToUpdate.Weight = animal.Weight;
            animalToUpdate.Colour = animal.Colour;

            return animalToUpdate;
        }

        public Animal? DeleteAnimal(int id)
        {
            var animalToDelete = _animals.FirstOrDefault(x => x.Id == id);
            if (animalToDelete == null) return null;

            _animals.Remove(animalToDelete);
            return animalToDelete;
        }
    }
}