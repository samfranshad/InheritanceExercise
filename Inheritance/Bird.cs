using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public double WingSpan { get; set; }
        public string FeatherColor { get; set; }
        public string BirdSpecies { get; set; }
        public bool CanFly { get; set; }

        public void BirdFacts(string birdSpecies, string featherColor, double wingSpan)
        {
            Console.WriteLine($"{birdSpecies}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Feather Color: {featherColor}\nWing Span: {wingSpan} inches");
        }

    }
}
