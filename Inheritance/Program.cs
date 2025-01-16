using System;
using System.Diagnostics.Contracts;

namespace Inheritance
{
    // Animal class
    public class Animal
    {
        // 4 members common to animals
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        // Constructor for Animal class
        public Animal(string name, int age, string habitat, string diet)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
    }


    // TODO Be sure to follow best practice when creating your class

    public class Bird : Animal
    {
        // 4 members specific to birds
        public string Wingspan { get; set; }
        public string Speed { get; set; }
        public string BeakType { get; set; }
        public string FeatherColor { get; set; }

        // Constructor for the Bird class
        public Bird(string name, int age, string habitat, string diet, string wingspan, string speed, string beakType, string featherColor)
            : base(name, age, habitat, diet)
        {
            Wingspan = wingspan;
            Speed = speed;
            BeakType = beakType;
            FeatherColor = featherColor;
        }
    }

    // Create Reptile class
    public class Reptile : Animal
    {
        // 4 members specific to reptiles
        public string ScaleType { get; set; }
        public bool ColdBlooded { get; set; }
        public int LegCount { get; set; }

        public bool ThreeHeartChamber { get; set; }

        // Constructor for Reptile class
        public Reptile(string name, int age, string habitat, string diet, string scaleType, bool coldBlooded, int legCount, bool threeHeartChamber)
            : base(name, age, habitat, diet)
        {
            ScaleType = scaleType;
            ColdBlooded = coldBlooded;
            LegCount = legCount;
            ThreeHeartChamber = threeHeartChamber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object for Bird class
            Bird bird = new Bird(
                "Eagle", // Type of bird
                5, // Age of bird
                "Mountains", // Habitat of bird
                "Carnivore", // Diet of bird
                "2.3 meters", // Wingspan of bird
                "160 km/h", // Speed of bird
                "Hooked", // Beak type of bird
                "Brown with white head" // Color of bird
                );

            // Bird details being displayed
            Console.WriteLine("Bird Details:");
            Console.WriteLine($"Name: {bird.Name}");
            Console.WriteLine($"Age: {bird.Age}");
            Console.WriteLine($"Habitat: {bird.Habitat}");
            Console.WriteLine($"Diet: {bird.Diet}");
            Console.WriteLine($"Wingspan: {bird.Wingspan}");
            Console.WriteLine($"Flight Speed: {bird.Speed}");
            Console.WriteLine($"Feather Color: {bird.FeatherColor}");


            //Was this okay for me to input this? I googled this part because when I ran my code it looked very cluttered & I wanted it to look organized and readble


            Console.WriteLine($"\n" + new string('-', 30) + "\n");


            // Reptile objects
            Reptile reptile = new Reptile(
                "Crocodile", // Name of reptile
                12, // Age of reptile
                "Rivers and Swamps", // Habitat of reptile
                "Carnivore", // Diet of reptile
                "Tough", // Scale typ of reptile
                true, // Cold-blooded (true)
                4, // Number of legs
                true // Has three heart chamber
                );


            // Reptile details being displayed 
            Console.WriteLine("Reptile Details:");
            Console.WriteLine($"Name: {reptile.Name}");
            Console.WriteLine($"Age: {reptile.Age} years");
            Console.WriteLine($"Habitat: {reptile.Habitat}");
            Console.WriteLine($"Diet: {reptile.Diet}");
            Console.WriteLine($"Scale Type: {reptile.ScaleType}");
            Console.WriteLine($"Cold-blooded: {(reptile.ColdBlooded ? "Yes" : "No")}");
            Console.WriteLine($"Leg Count: {reptile.LegCount}");
            Console.WriteLine($"Three Heart Chamber: {(reptile.ThreeHeartChamber ? "Yes " : "No")}");

        }

    }
}
