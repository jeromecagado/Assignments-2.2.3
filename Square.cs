using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_2._2._3
{
    public class Square : Shape
    {
        public double SideOfSquare { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override double CalculateShape()
        {
            return SideOfSquare * SideOfSquare;
        }
        public override void Display()
        {
            Console.WriteLine("\nSquare Information:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Side of Square: {SideOfSquare}");
            Console.WriteLine($"Area: {CalculateShape()}\n");
        }
    }
}
