using System;

namespace lab5
{
    // Class representing basic information about an animal
    public class BaseInfo
    {
        // Private fields for storing information
        private string _name;
        private int _age;
        private int _weight;
        private int _height;
        private string _gender;
        private string _color;

        // Constructor to initialize the BaseInfo object with provided values
        public BaseInfo(string name,int age, int weight, int height, string gender, string color)
        {
            // Setting values using properties to ensure proper encapsulation
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            Color = color;
        }

        // Public properties with get/set accessors for accessing private fields
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Height { get => _height; set => _height = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Color { get => _color; set => _color = value; }

    }

}
