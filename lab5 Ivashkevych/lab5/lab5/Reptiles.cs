using System;

namespace lab5
{
    // Class representing Reptiles, inheriting from Animal
    public class Reptiles : Animal
    {
        // Private fields specific to Reptiles
        private int _limbsCount;
        private bool _isVenomous;
        private bool _isNocturnal;

        // Constructor for Reptiles
        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="gender"></param>
        /// <param name="color"></param>
        public Reptiles(string name, int age, int weight, int height, string gender, string color, int _limbsCount, bool _isVenomous, bool _isNocturnal) : base(name,age, weight, height, gender, color)
        {
            // Assigning values to Reptiles properties
            LimbsCount = _limbsCount;
            IsVenomous = _isVenomous;
            IsNocturnal = _isNocturnal;
        }

        // Public properties with get/set accessors for accessing private fields
        public int LimbsCount { get => _limbsCount; set => _limbsCount = value; }
        public bool IsVenomous { get => _isVenomous; set => _isVenomous = value; }
        public bool IsNocturnal { get => _isNocturnal; set => _isNocturnal = value; }

        // Override of ToString method to display Reptiles information
        public override string ToString()
        {
            return $"Name: {BaseInfo.Name}\n Age: {BaseInfo.Age}\n Weight: {BaseInfo.Weight} kg\n Height: {BaseInfo.Height} cm\n Gender: {BaseInfo.Gender}\n Color: {BaseInfo.Color}\n Limbs Count: {LimbsCount}\n Venomous: {IsVenomous}\n Nocturnal: {IsNocturnal}";
        }
    }
}

