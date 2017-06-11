#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
// DO NOT CHANGE
namespace NumberSystemConverter
{
    class Program
    {
        static RomanNumeralConverter converter;

        static void Main(string[] args)
        {
            converter = new RomanNumeralConverter();
            Run();
        }
        
        static void Run()
        {
            #region Runs the program expecting only integral inputs and calls ConvertToRomanNumeral() upon receiving
            while (true)
            {
                int result;
                Console.WriteLine("Numeral Registry");
                Console.WriteLine("M - 1000");
                Console.WriteLine("D - 500");
                Console.WriteLine("C - 100");
                Console.WriteLine("L - 50");
                Console.WriteLine("X - 10");
                Console.WriteLine("V - 5");
                Console.WriteLine("I - 1\n");

                Console.WriteLine("Please enter an integer value OR roman numeral to be converted...");
                string userInput = Console.ReadLine();
                if(converter.CheckIfInputIsValid(userInput) == true) {  // Added a bool to a method to validate input 
                    Console.WriteLine(userInput + " = " + converter.ConvertToRomanNumeral(int.Parse(userInput)));
                }else
                {
                    Console.WriteLine(userInput + " Invalid Input");
                }
                Console.Write("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
            }
            #endregion
        }
    }
}
