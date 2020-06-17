using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ch11Ex02
{
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal) =>
            List.Add(newAnimal); // Add comes from System.Collections

        public void Remove(Animal newAnimal) =>
            List.Remove(newAnimal); // Remove comes from System.Collections

        public Animal this[int animalIndex] // Index as to be specified as int, double, whatever... with a variable name represeting a place in memory where the index reference is stored.
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}