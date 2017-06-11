using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Input_Output.Library;

namespace TDD_Input_Output
{
    class Client
    {
        Methods methods = new Methods();

        public void Start()
        {
            methods.CheckIfFileExistsAndCreateIfItDoesNot();
            bool isRunning = true;

            while (isRunning)
            {
                UI.MainMenu();
                ConsoleKey inputChoice = Console.ReadKey(true).Key;

                switch (inputChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        FileAndNameCase();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        MathematicCases();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        isRunning = false;
                        break;
                }
            }
        }

        public void FileAndNameCase()
        {
            bool isFileRunning = true;

            while (isFileRunning)
            {
                UI.FileAndNameFunctions();
                ConsoleKey fileAndNameChoice = Console.ReadKey(true).Key;

                switch (fileAndNameChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        methods.CheckIfNameIsValid();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        isFileRunning = false;
                        break;
                }
            }
        }

        public void MathematicCases()
        {
            bool isMathRunning = true;

            while (isMathRunning)
            {
                UI.MathMenu();
                ConsoleKey mathChoice = Console.ReadKey(true).Key;

                switch (mathChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        methods.Add();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        methods.Subtract();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        methods.Multiplication();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        methods.Divide();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        isMathRunning = false;
                        break;
                }
            }
        }
    }
}
