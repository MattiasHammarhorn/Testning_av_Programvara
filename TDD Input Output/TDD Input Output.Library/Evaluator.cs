using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// TODO 1. Change class name from Class1 to Class to Evaluator
// TODO 2. Change class filename from Class1.cs to Evaluator.cs
// TODO 3. Add using System.Text.RegularExpressions to allow Regex.

// TODO 4. Add method Evaluate_CreateIfFileDoNotExists()
// TODO 5. Add method Evaluate_CheckIfFileDoNotExist()
// TODO 6. Add method Evaluate_CreateFile()
// TODO 7. Add method Evaluate_PrintFirstAndLastName()
// TODO 8. Add method Evaluate_ReadFromFileAndCheckIfNameIsCorrectlyWriten()
// TODO 9. Add method Evaluate_Addition()
// TODO 10. Add method Evaluate_Subtraction()
// TODO 11. Add method Evaluate_Multiplication()
// TODO 12. Add method Evaluate_Division


namespace TDD_Input_Output.Library
{
    public class Evaluator
    {
        public bool CreateIfFileDoNotExist(string filePath)         // Checks if a file exists or not, and creates one if it does not
        {
            //bool fileExists;

            //if (!File.Exists(filePath))
            //    using (var file = File.Create(filePath))
            //file.Close();

            //        return fileExists = true;

            if (!CheckIfFileExist(filePath))                        // If CheckIfFileExists can't find an existing file
            {
                CreateFile(filePath);                               // Call a method that creates a file
                return true;
            }
            return true;
        }
        public bool CreateFile(string filePath)                     // Assigns value to a bool if it is possible to create a file
        {
            try {
                using (FileStream file = File.Create(filePath))     // Try creating a file in the .txt-file in filePath
                    file.Close();                                   // Close the file when done
            }catch(Exception e)
            {
                return false;                                       // Test fails if an exception is caught and you cannot make a new file
            }
            return true;
        }

        public bool CheckIfFileExist(string filePath)                       // Assigns value to a bool if a file exists
        {
            return File.Exists(filePath);                                   // Returns a true if the file in filePath if it exists
        }

        public bool CheckIfNameIsValid(string filePath, string currentName)
        {
            if (currentName.Any(char.IsDigit) || currentName.Any(char.IsSymbol) ||(currentName.Any(char.IsWhiteSpace)))
            {
                //throw new ArgumentException("Name cannot include numbers or symbols.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool WriteFirstAndLastName(string filePath, string fullName) // Send in the filepath and fullName that consists of (firstName and lastName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))    // Create a StreamWriter that writes to the file
                {
                    sw.WriteLine(fullName);                             // Write "fullName" to the file, using the StreamWriter-class
                    sw.Close();                                         // Close the StreamWriter
                    if (ReadFromFileAndCheckIfNameIsCorrectlyWritten(filePath, fullName)) // If it could successfully add the full name
                        return true;                                                      // to the file, then return true

                    else
                        return false;
                }
            }catch (Exception e)
            {
                //throw new Exception("Error writing to file at: " + filePath);
                return false;
            }
            
        }

        public bool ReadFromFileAndCheckIfNameIsCorrectlyWritten(string filePath, string fullName) 
        {
            string[] ArrayFromFile = File.ReadAllLines(filePath);   // Make a string array out of the .txt-file

            foreach(string line in ArrayFromFile)
            {
                if (line == fullName)                               // Check if each of the lines has the fullName written into it
                {
                    Console.WriteLine("Firstname and Lastname has succesfully been written to file!");
                    return true;                                    // Returns true if it did
                }
            }
            return false;                                           // Return false (fail) if it fullName isn't written
        }

        public int Addition(int input1, int input2, string filePath)
        {
            return input1 + input2;                                 // Adds the integers from input 1 and 2 and returns them as one
        }

        public int Subtraction(int input1, int input2, string filePath)
        {
            return input1 - input2;                                 // Subtracts input1 from input 2 and returns them as one
        }

        public int Multiplication(int input1, int input2, string filePath)
        {
            return input1 * input2;                                 // Multiplies the inputs and returns them as one
        }

        public int Division(int input1, int input2, string filePath)
        {
            return input1 / input2;                                 // Divides the inputs and returns them as one
        }

        public bool WriteActualOutputToFile(string filePath, int actualOutput)    // Bool to write out the actual output to the .txt-file
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))                // Use a StreamWriter to write to our .txt-file
                {
                    sw.WriteLine(actualOutput);                                     // Write the actual output to the file
                    sw.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;                                                       // Return false if an exception is caught
            }
        }
    }
}
