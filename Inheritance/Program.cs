using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird()
            {
                CanFly = true,
                HasFeathers = true,
                Age = 5,
                HasBeak = true
            };

            var myReptile = new Reptile()
            {
                HasScales = true,
                LandSea = "Land",
                BodyTemp = "Cold Blood",
                LegCount = 4,
            };


            var myAnimals = new Animal[] { myBird, myReptile };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive {animal.IsAlive}");
                Console.WriteLine($"has these many legs: {animal.LegCount}");

                Console.WriteLine($"it does have eyes: {animal.HasEyes}");
                Console.WriteLine($"Does it live in land,sea or air? {animal.LandSeaAir}");
                Console.WriteLine();



            }


            Console.WriteLine($"it canf fly? {myBird.CanFly} ");
            Console.WriteLine($"it does have feathers? {myBird.HasFeathers}");
            Console.WriteLine($"the age of the bird is {myBird.Age}");
            Console.WriteLine($"it does have a beak? {myBird.HasBeak}");
            Console.WriteLine();

            Console.WriteLine($"It does have scales {myReptile.HasScales}");
            Console.WriteLine($"Does it live in land or sea? {myReptile.LandSea}");
            Console.WriteLine($"what kind is its body temperature? {myReptile.BodyTemp}");
            Console.WriteLine($"How Many Legs does it have  {myReptile.LegCount}");


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
