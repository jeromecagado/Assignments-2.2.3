using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_2._2._3
{
    public abstract class Shape
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract Double CalculateShape();

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Area: {CalculateShape()}\n");
        }
    }
}
