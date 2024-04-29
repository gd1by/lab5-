using System;


namespace lab5
{
    // Class representing Mammals, inheriting from Animal
    public class Mammal : Animal
    {
        // Private fields specific to Mammals
        private string _residence;
        private bool _haveWings;
        private bool _hairy;

        // Constructor for Mammals
        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="gender"></param>
        /// <param name="color"></param>
        public Mammal(string name, int age, int weight, int height, string gender, string color, string _residence, bool _haveWings, bool _hairy) : base(name, age, weight, height, gender, color)
        {
            // Assigning values to Mammals properties
            Residence = _residence;
            HaveWings = _haveWings;
            Hairy = _hairy;
        }

        // Public properties with get/set accessors for accessing private fields
        public string Residence { get => _residence; set => _residence = value; }
        public bool HaveWings { get => _haveWings; set => _haveWings = value; }
        public bool Hairy { get => _hairy; set => _hairy = value; }

        // Override of ToString method to display Mammals information
        public override string ToString()
        {
            return $"Name: {BaseInfo.Name}\n Age: {BaseInfo.Age}\n Weight: {BaseInfo.Weight} kg\n Height: {BaseInfo.Height} cm\n Gender: {BaseInfo.Gender}\n Color: {BaseInfo.Color}\n HaveWings: {_haveWings}\n Hairy: {_hairy}\n Residence: {_residence}\n";
        }
    }
}

