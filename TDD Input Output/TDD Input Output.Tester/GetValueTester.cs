using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Input_Output.Library;
using NUnit.Framework;
using System.IO;

// TODO 1. Change class name from Class 1 to GetValueTester
// TODO 2. Change class filename from Class1.cs to GetValueTester.cs
// TODO 3. Add reference TDD Input Output.Library TO Unit Test Project
// TODO 4. Install NUnit 3 to this project through NuGet.
// TODO 5. Add using NUnit.Framework
// TODO 6. Install NUnit Adapter from Tools-Extensions and Updates
// TODO 7. Add using System.IO;
// TODO 8. Add [TextFixture] to class
// TODO 9. Create a string path to project directory and a string for the txt-filename
// TODO 10. Add testcases Evaluator_CheckIfFileExists, Evaluator_PrintFirstAndSurName,
//         Evaluator_CheckIfFileIsCorrectWritten, Evaluator_Addition, Evaluator_Subtraction, Evaluator_Multiplication, Evaluator_Division and Evaluator_ReadFromFile
// TODO 11. ADD [Test] to method

namespace TDD_Input_Output.Tester
{
    [TestFixture]
    public class GetValueTester
    {
        string stringPath = @"C:\Users\Roger och Stina\Desktop\Testning av Programvara Labbar\TDD Input Output";
        string fileName = "MyFile.txt";
  
        [Test]
        public void Evaluator_CheckIfFileExists()
        {
            // Arrange
            string filePath = Path.Combine(stringPath, fileName);           // Combines two string paths into one path

            // Act
            Evaluator evaluator = new Evaluator();                          // Runs a new instance of Evaluator
            bool fileExists = evaluator.CreateIfFileDoNotExist(filePath);   // Assigns a value to the bool
                                                                            // based on the conditions inside the method
                                                                            // where the filePath was sent
            // Assert
            Assert.IsTrue(fileExists);
        }

        [Test]
        public void Evaluator_CheckIfNameIsValid()
        {
            // Assert
            string filePath = Path.Combine(stringPath, fileName);
            string testName = "Hellokitty";

            // Act
            Evaluator evaluator = new Evaluator();
            bool nameIsCorrectlyWritten = evaluator.CheckIfNameIsValid(filePath, testName);
            // Assert
            Assert.IsTrue(nameIsCorrectlyWritten);
        }
        
        [Test]
        public void WriteFirstAndLastName()
        {
            // Arrange
            string filePath = Path.Combine(stringPath, fileName);

            string firstName = "Firstname";
            string lastName = "Lastname";

            // Act
            Evaluator evaluator = new Evaluator();
            bool nameIsPrintedCorrectlyToFile = evaluator.WriteFirstAndLastName(filePath, firstName + " " + lastName);

            // Assert
            Assert.IsTrue(nameIsPrintedCorrectlyToFile);
        }
        //[Test]
        //public void Evaluator_CheckIfFileIsCorrectWritten()
        //{
        //    // Assert
        //    string filePath = Path.Combine(stringPath, fileName);
        //    string firstName = "Firstname";
        //    string lastName = "Lastname";
        //    string fullName = firstName + " " + lastName;
        //    // Act
        //    Evaluator evaluator = new Evaluator();
        //    bool canBeWritten = evaluator.WriteFirstAndLastName(filePath, firstName + " " + lastName);
        //    bool isCorrectlyWritten =evaluator.ReadFromFileAndCheckIfNameIsCorrectlyWritten(filePath, fullName);
        //    // Assert
        //    Assert.AreEqual(canBeWritten, isCorrectlyWritten);  // Asserts if you could write your full name and adding it to the file
        //}

        [Test]
        public void Evaluator_Addition()
        {
            // Arrange
            string filePath = Path.Combine(stringPath, fileName);
            int input1 = 1;                                             // Declaration of ints to be calculated
            int input2 = 1;
            int expectedOutput = 2;                       // Expected to be

            // Act
            Evaluator evaluator = new Evaluator();
            int actualOutput = evaluator.Addition(input1, input2, filePath);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);              // Asserts if the the inputs were correctly calculated
        }

        [Test]
        public void Evaluator_Subtraction()
        {
            //Arrange
            string filePath = Path.Combine(stringPath, fileName);
            int input1 = 1;                                             // Declaration of ints to be calculated
            int input2 = 1;
            int expectedOutput = 0;                       // Expected to be

            // Act
            Evaluator evaluator = new Evaluator();
            int actualOutput = evaluator.Subtraction(input1, input2, filePath);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);              // Asserts if the the inputs were correctly calculated
        }

        [Test]
        public void Evaluator_Multiplication()
        {
            //Arrange
            string filePath = Path.Combine(stringPath, fileName);
            int input1 = 1;                                             // Declaration of ints to be calculated
            int input2 = 1;
            int expectedOutput = 1;                       // Expected to be

            // Act
            Evaluator evaluator = new Evaluator();
            int actualOutput = evaluator.Multiplication(input1, input2, filePath);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);              // Asserts if the the inputs were correctly calculated
        }

        [Test]
        public void Evaluator_Division()
        {
            // Arrange
            string filePath = Path.Combine(stringPath, fileName);
            int input1 = 1;                                             // Declaration of ints to be calculated
            int input2 = 1;
            int expectedOutput = 1;                       // Expected to be

            // Act
            Evaluator evaluator = new Evaluator();
            int actualOutput = evaluator.Division(input1, input2, filePath);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);              // Asserts if the the inputs were correctly calculated
        }

        [Test]
        public void WriteActualOutputToFile()
        {
            // Arrange
            string filePath = Path.Combine(stringPath, fileName);
            int actualOutput = 5;

            // Act
            Evaluator evaluator = new Evaluator();
            bool actualOutputHasBeenWrittenToFile = evaluator.WriteActualOutputToFile(filePath, actualOutput);

            // Assert
            Assert.IsTrue(actualOutputHasBeenWrittenToFile);
        }
    }
}
