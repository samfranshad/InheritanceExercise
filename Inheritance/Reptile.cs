using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public int BodyLength { get; set; }
        public string ScaleColor { get; set; }
        public string ReptileSpecies { get; set; }
        public bool IsCarnivorous { get; set; }

        public void ReptileFacts(string reptileSpecies, string scaleColor, int bodyLength)
        {
            Console.WriteLine($"{reptileSpecies}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Color: {scaleColor}\nLength of body: {bodyLength} feet");
        }
    }
}
