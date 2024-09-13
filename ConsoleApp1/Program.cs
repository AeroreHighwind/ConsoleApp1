using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculatePerimeterV1();

            //TemperatureConverter();

            //RegularPolygonPerimeter();

            BooleanHandling();
        }

        static void CalculatePerimeterV1()
        {
            double height, width, area, perimeter;
            Console.Write("Enter the rectangle height (in m): ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle width (in m): ");
            width = double.Parse(Console.ReadLine());
            perimeter = 2 * (width + height);
            area = width * height;
            Console.WriteLine("The rectangle area is: {0}m², and the perimeter is {1}m", area, perimeter);
        }

        static void TemperatureConverter()
        {
            double temperature;
            Console.Write("Enter the temperature in C°:");
            temperature = double.Parse(Console.ReadLine());
            double convertedTemperature = temperature * 9 / 5 + 32;
            Console.WriteLine($"The temperature in Fahrenheit {convertedTemperature}");
        }

        static void RegularPolygonPerimeter()
        {
            double sideSize;
            int sidesNumber;
            Console.Write("Enter the size of one of the polygon sides: ");
            sideSize = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of the polygon sides: ");
            sidesNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The perimeter of the polygon is: {sidesNumber * sideSize}");
        }

        static void BooleanHandling()
        {
            double userNumber;
            Random randomGen = new Random();

            try
            {
                Console.Write("Enter a number: ");
                userNumber = double.Parse(Console.ReadLine());
                int randomNumb = randomGen.Next(1000);
                if (userNumber >= randomNumb)
                {
                    Console.WriteLine($"The entered number is bigger than {randomNumb}");
                    return;
                }

                Console.WriteLine($"The entered number is smaller than {randomNumb}");
            }
            catch (Exception ex) {
                Console.WriteLine("The entered value is not a number");
            }
        }
    }
}
