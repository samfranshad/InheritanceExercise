using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
            var robin = new Bird();

            robin.IsAlive = true;
            robin.Diet = "insects, berries, and earthworms";
            robin.LegNumber = 2;
            robin.MovementMethod = "flight";
            robin.WingSpan = 13.4;
            robin.FeatherColor = "brown and orange";
            robin.BirdSpecies = "American Robin";
            robin.CanFly = true;

            robin.BirdFacts(robin.BirdSpecies, robin.FeatherColor, robin.WingSpan);
            robin.AnimalFacts(robin.Diet, robin.LegNumber, robin.MovementMethod);
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var python = new Reptile();

            python.IsAlive = true;
            python.Diet = "rodents, birds, and lizards";
            python.LegNumber = 0;
            python.MovementMethod = "slither";
            python.BodyLength = 4;
            python.ScaleColor = "brown, yellow, and white";
            python.ReptileSpecies = "Ball Python";
            python.IsCarnivorous = true;

            python.ReptileFacts(python.ReptileSpecies, python.ScaleColor, python.BodyLength);
            python.AnimalFacts(python.Diet, python.LegNumber, python.MovementMethod);

        }
    }
}
