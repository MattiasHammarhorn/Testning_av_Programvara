using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TDD_Input_Output.Library;

namespace TDD_Input_Output
{
    class Methods
    {
        Evaluator evaluator = new Evaluator();
        static string stringPath = @"C:\Users\Roger och Stina\Desktop\Testning av Programvara Labbar\TDD Input Output";
        static string fileName = "MyFile.txt";
        string filePath = Path.Combine(stringPath, fileName);

        public void CheckIfFileExistsAndCreateIfItDoesNot()
        {
            Console.Clear();
            Console.WriteLine("Checking if file exists and creating one of it does...");
            bool fileExists = false;
            evaluator.CreateIfFileDoNotExist(filePath);             // Calls out the bool method from the Evaluator class

            if (fileExists == true)                                 // If the file exists
                Console.WriteLine("File exists!");        // then write out that it does
            
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("added by ");
            int input2 = int.Parse(Console.ReadLine());

            int actualOutput = evaluator.Addition(input1, input2, filePath);
            evaluator.WriteActualOutputToFile(filePath, actualOutput);
            Console.Write("{0} + {1} = {2} ", input1, input2, actualOutput);
            Console.ReadKey(true);
        }

        public void Subtract()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("subtracted by ");
            int input2 = int.Parse(Console.ReadLine());

            int actualOutput = evaluator.Subtraction(input1, input2, filePath);
            evaluator.WriteActualOutputToFile(filePath, actualOutput);
            Console.WriteLine("{0} - {1} = {2} ", input1, input2, actualOutput);
            Console.ReadKey(true);
        }

        public void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("multiplied by ");
            int input2 = int.Parse(Console.ReadLine());

            int actualOutput = evaluator.Multiplication(input1, input2, filePath);
            evaluator.WriteActualOutputToFile(filePath, actualOutput);
            Console.WriteLine("{0} * {1} = {2} ", input1, input2, actualOutput);
            Console.ReadKey(true);
        }

        public void Divide()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("divided by ");
            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 0)
            {
                Divide();
            }

            int actualOutput = evaluator.Division(input1, input2, filePath);
            evaluator.WriteActualOutputToFile(filePath, actualOutput);
            Console.WriteLine("{0} / {1} = {2} ", input1, input2, actualOutput);
            Console.ReadKey(true);
        }

        public void PrintName(string firstName, string lastName)
        {
            evaluator.WriteFirstAndLastName(filePath, firstName + " " + lastName);
            Console.WriteLine("Thank you {0} {1}! Open up the text-file in the directory and your name should probably be in there! (Unless I screwed up again...)",
                                firstName, lastName);
            Console.ReadKey(true);
        }

        public void CheckIfNameIsValid()
        {
            Console.Clear();

            Console.WriteLine("Please enter your first name and please only use letters: ");
            string firstName = Console.ReadLine();
            bool firstNameIsValid = evaluator.CheckIfNameIsValid(filePath, firstName);


            Console.WriteLine("And the same with your last name, please");
            string lastName = Console.ReadLine();
            bool lastNameIsValid = evaluator.CheckIfNameIsValid(filePath, lastName);

            #region Temporary solution
            if (firstNameIsValid == true && lastNameIsValid == true)
                PrintName(firstName, lastName);
            else
                CheckIfNameIsValid();
            #endregion
        }
    }
}