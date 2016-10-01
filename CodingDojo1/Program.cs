using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to temp convertor app from wi15b156");

            do
            {
                Console.WriteLine("\nSelect the converted measure from menu \nto which u are going to convert:");
                Menu();

                char to_temp = Console.ReadKey().KeyChar;

                Console.WriteLine("\nTemperature to convert");


                double enter_number = 0;

                try
                {
                    enter_number = Convert.ToSingle(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error reading from user. Enter double type.");
                }
                
                
                Console.WriteLine("\nConvertion result");
                Converter(enter_number, to_temp);

                Console.WriteLine("\nPress y if you want to to keep converting \nor any key to break the process.");
            }
            while (Console.ReadKey().KeyChar == 'y');
        }

        private static void Menu()
        {
            Console.WriteLine("\tc: Celsius");
            Console.WriteLine("\tf: Fahrenheit");
            Console.WriteLine("\tk: Kelvin");
            Console.WriteLine("\tr: Reaumur");
        }

        private static void Converter(double temp, char tempType)
        {
            if(tempType == 'c' || tempType == '1')
            {
                Console.WriteLine("\t{0}° Celsius", CelsiusConv(temp));
            }
            else if(tempType == 'f' || tempType == '2')
            {
                Console.WriteLine("\t{0}° Fahrenheit", FahrenheitConv(temp));
            }
            else if (tempType == 'k' || tempType == '3')
            {
                Console.WriteLine("\t{0}° Kelvin", KelvinConv(temp));
            }
            else if (tempType == 'r' || tempType == '4')
            {
                Console.WriteLine("\t{0}° Reaumur", ReaumurConv(temp));
            }
        }

        private static double CelsiusConv(double x)
        {
            return x;
        }

        private static double FahrenheitConv(double x)
        {
            return (x * 1.8) + 32;
        }

        private static double KelvinConv(double x)
        {
            return x + 273.15;
        }

        private static double ReaumurConv(double x)
        {
            return x * 4 / 5;
        }
    }
}
