

using System.Xml.Serialization;

namespace Assignments_2._2._3
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to calcuating an area of a shape.\n");

            while (true)
            {
                Console.WriteLine("Please enter \"1\" to calculate an area of a circle\n");
                Console.WriteLine("Enter \"2\" to caculate an area of a square\n");
                Console.WriteLine("Enter 0 to exit the program.\n");

                if (!int.TryParse(Console.ReadLine(), out int result) ||  result == 0)
                {
                    Console.WriteLine("You are exiting the program. Goodbye!");
                    break;
                }
                Prompt user = new Prompt(result);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadKey();

            }
        }

        public class Prompt
        {
            public Prompt(int choice)
            {
                switch (choice) 
                {

                    case 1:
                    
                        Console.WriteLine("\nYou decided to find an area of a circle.");
                        Console.WriteLine("Please enter the radius of a circle.\n");

                        if (!double.TryParse(Console.ReadLine(), out double circleRadius))
                        {
                            Console.WriteLine("Incorrect input!");
                            return;
                        }

                        Circle circle = new Circle();
                        circle.Radius = circleRadius;
                        circle.Id = 1;
                        circle.Name = "Circle";
                        circle.Color = "Red";
                        circle.Display();
                        break;

                    case 2:

                        Console.WriteLine("You decided to find an area of a sqare.");
                        Console.WriteLine("Please enter the side of a square.\n");

                        if (!double.TryParse(Console.ReadLine(), out double squareSide))
                        {
                            Console.WriteLine("Incorrect input!");
                            return;
                        }

                        Square square = new Square();
                        square.SideOfSquare = squareSide;
                        square.Id = 1;
                        square.Name = "Square";
                        square.Color = "Red";
                        square.Display();
                        break;
                }
            }
        }    
    }
}
