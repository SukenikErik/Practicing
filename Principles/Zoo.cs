using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    internal class Zoo
    {
        List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void ShowAnimals() { 
            foreach (Animal animal in _animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public void Feed()
        {
            foreach(Animal animal in _animals)
            {
                animal.Eat();
            }
        }
    }
}
