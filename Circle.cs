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
        public override string Description { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
