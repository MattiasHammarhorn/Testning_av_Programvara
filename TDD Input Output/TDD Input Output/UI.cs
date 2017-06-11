using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Input_Output
{
    class UI
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. File and name functions");
            Console.WriteLine("2. Mathematic functions");
            Console.WriteLine("3. Exit");
        }

        public static void MathMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add and write to file");
            Console.WriteLine("2. Subtract and write to file");
            Console.WriteLine("3. Multiply and write to file");
            Console.WriteLine("4. Divide and write to file");
            Console.WriteLine("5. Go back");
        }

        public static void FileAndNameFunctions()
        {
            Console.Clear();
            Console.WriteLine("1. Write your first and last name to the file");
            Console.WriteLine("2. Go back");
        }
    }
}
