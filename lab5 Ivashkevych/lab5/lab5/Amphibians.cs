using System;

namespace lab5
{
    // Enum for different types of rebirthing methods
    public enum TypeOfRebrithing {
        LUNGS, GILLS
    }

    // Class representing Amphibians, inheriting from Animal class
    public class Amphibians:Animal
    {
        // Private fields specific to Amphibians
        private TypeOfRebrithing _typeOfRebrithing;
        private bool _ecosystemThreat;
        private bool _socialBehavior;

        // Constructor for Amphibians
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param age="age"></param>
        /// <param weight="weight"></param>
        /// <param height="height"></param>
        /// <param gender="gender"></param>
        /// <param color="color"></param>
        public Amphibians(string name, int age, int weight, int height, string gender, string color, TypeOfRebrithing _typeOfRebrithing, bool _ecosystemThreat, bool _socialBehavior) : base(name, age, weight, height, gender, color)
        {
            // Assigning specific values to Amphibians properties
            EcosystemThreat = _ecosystemThreat;
            SocialBehavior = _socialBehavior;
            TypeOfRebrithing = _typeOfRebrithing;
        }

        // Public properties with get/set accessors for accessing private fields
        public bool EcosystemThreat { get => _ecosystemThreat; set => _ecosystemThreat = value; }
        public bool SocialBehavior { get => _socialBehavior; set => _socialBehavior = value; }
        public TypeOfRebrithing TypeOfRebrithing { get => _typeOfRebrithing; set => _typeOfRebrithing = value; }

        // Override of ToString method to display Amphibians information
        public override string ToString()
        {
            return $"Name: {BaseInfo.Name}\n Age: {BaseInfo.Age}\n Weight: {BaseInfo.Weight} kg\n Height: {BaseInfo.Height} cm\n Gender: {BaseInfo.Gender}\n Color: {BaseInfo.Color}\n TypeOfRebrithing: {_typeOfRebrithing}\n EcosystemThreat: {_ecosystemThreat}\n SocialBehavior: {_socialBehavior}\n";
        }
    }
}