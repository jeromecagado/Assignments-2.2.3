

using System.Xml.Serialization;

namespace Assignments_2._2._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to caculating the area of a shape. " +
                    "Please enter \"1\" for Circle, \"2\" for Square, and \"0\" to exit the program.");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice == 0)
                {
                    Console.WriteLine("Exiting the program... Goodbye.");
                    break;
                }
                Prompt user = new Prompt(choice);
                Console.WriteLine("Press Enter to continue...\n");
                Console.ReadLine();
            }
            
        }

        public class Prompt
        {
            public Prompt (int choice)
            {
                if (choice == 1)
                {
                    Console.WriteLine("\nEnter the radius of the circle.");
                    if (!double.TryParse(Console.ReadLine(), out double radius))
                    {
                        Console.WriteLine("Invalid Input!");
                        return;
                    }
                    Circle circle = new Circle();
                    circle.Radius = radius;
                    double circleArea = circle.CalculateArea();
                    Console.WriteLine($"Area of a circle is: {circleArea}");
                }
                else if(choice == 2)
                {
                    Console.WriteLine("\nEnter the side of a square.");
                    if(!double.TryParse(Console.ReadLine(), out double squareSide))
                    {
                        Console.WriteLine("Invalid Input!");
                        return;
                    }
                    Square square = new Square();
                    square.SideOfSquare = squareSide;
                    double squareArea = square.CalculateArea();
                    Console.WriteLine($"Area of a square is: {squareArea}");
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                    return;
                }
            }
            
        }
       

    }
}
