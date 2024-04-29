using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab5
{
    internal class Zoo
    {
        // Array to hold animals in the zoo
        Animal[] arr;

        // Constructor to initialize the zoo with an empty array of animals
        public Zoo()
        {
            arr = new Animal[0];
        }

        // Property to get the count of animals in the zoo
        public int CountAnimal {get => arr.Length;}

        // Method to add a new animal to the zoo
        public void AddAnimal(Animal newAnimal)
        {
            Animal[] tmp = new Animal[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }
            tmp[arr.Length] = newAnimal;    
            arr = tmp;
        }

        // Method to delete an animal from the zoo by its ID
        public void DeleteAnimalById(int id)
        {
            Animal[] tmp = new Animal[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < id)
                {
                    tmp[i] = arr[i];
                }
                if (i > id)
                {
                    tmp[i - 1] = arr[i];
                }
            }
            arr = tmp;
        }


        // Method to edit an existing animal in the zoo by its ID
        public void EditAnimal(int id, Animal animal) {
            if (id >= 0 && id < arr.Length)
            {
                arr[id]=animal;
            }
        }

        // Method to get an animal from the zoo by its ID
        public Animal GetById(int id) { 
            return arr[id];
        }
    }
}
