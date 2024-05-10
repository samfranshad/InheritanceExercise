using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common

        public bool IsAlive { get; set; }
        public string Diet { get; set; }
        public int LegNumber { get; set; }
        public string MovementMethod { get; set; }

        public void AnimalFacts(string diet, int legNumber, string movementMethod)
        {
            Console.WriteLine($"Diet: {diet}\nNumber of Legs: {legNumber}\nMethod of Movement: {movementMethod}");
        }


    }
}
