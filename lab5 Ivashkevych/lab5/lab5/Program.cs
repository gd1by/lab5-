using System;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function to print information about animals in the zoo
            void PrintZoo(Zoo zoo)
            {
                for (int i = 0; i < zoo.CountAnimal; i++)
                {
                    Console.WriteLine($"\n\n////////// ID: {i} //////////////");
                    Console.Write(zoo.GetById(i).ToString());
                }
            }
           
            // Creating an object of the Zoo class
            Zoo zoo = new Zoo();
            
            // Creating animals of different types
            Animal reptiles1 = new Reptiles("Reptiles", 25,35,1,"male","red",4,true,false);
            Animal amphibians1 = new Amphibians("Amphibians", 25,35,1,"male","red",TypeOfRebrithing.GILLS,true,false);
            Animal mammal1 = new Mammal("Mammal", 25,35,1,"male","red","forest",false,false);

            // Adding animals to the zoo
            zoo.AddAnimal(reptiles1);
            zoo.AddAnimal(amphibians1);
            zoo.AddAnimal(mammal1);

            // Displaying the initial state of the zoo
            PrintZoo(zoo);
            Console.WriteLine("**********************************");
            Animal forEdit = new Mammal("Mammal", 200, 75, 1, "male", "green", "city", true, false);

            // Editing an animal at a specific index
            zoo.EditAnimal(1, forEdit);
           
            PrintZoo(zoo);
            Console.WriteLine("**********************************");

            // Deleting an animal at a specific index
            zoo.DeleteAnimalById(1);
            
            PrintZoo(zoo);
            Console.WriteLine("**********************************");
        }
    }
}