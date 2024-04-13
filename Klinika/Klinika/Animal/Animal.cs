namespace Klinika.Animal
{
    public class Animal
    {
        public int Id { get; private set; }
        private static int _animalCount;
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public string Colour { get; set; }

        public Animal(string name, string species, double weight, string colour)
        {
            Id = ++_animalCount;
            Name = name;
            Species = species;
            Weight = weight;
            Colour = colour;
        }
    }
}