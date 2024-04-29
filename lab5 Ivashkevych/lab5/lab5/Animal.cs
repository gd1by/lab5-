using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Animal
    {
        // Field to hold base information about the animal
        public BaseInfo BaseInfo;

        // Constructor to initialize the Animal with basic information
        public Animal(string name, int age, int weight, int height, string gender, string color)
        {
            // Creating a BaseInfo object with provided parameters
            BaseInfo = new BaseInfo(name, age, weight, height, gender, color);
        }

        // Method to retrieve the base information of the animal
        public BaseInfo GetBaseInfo() { 
            return BaseInfo;
        }
    }
}
