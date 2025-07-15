using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_2._2._3
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override double CalculateShape()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine("\nCircle Information:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateShape()}\n");
        }


    }
}
