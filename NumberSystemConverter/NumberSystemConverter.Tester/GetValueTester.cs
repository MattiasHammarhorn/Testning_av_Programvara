using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

// TODO 1. Change class name from Class1 to GetValueTester
// TODO 2. Change class file name from Class1.cs to GetValueTester.cs
// TODO 3. Add reference RomanNumeralConverter to Unit Test Project
// TODO 4. Install NUnit 3 to this project through NuGet
// TODO 5. Add using NUnit.Framework
// TODO 6. Install NUnit Adapter from Tools-Extensions and Updates
// TODO 7. Add using System.IO;
// TODO 8. Add [TestFixture] to class
// TODO 9. Add testcases AssertIf5IsV(), AssertIf4IsIV(), AssertIf9IsIX(), AssertIf90IsXC(), AssertIf900IsCM(),
//         CheckIfInvalidInputWorks()
// TODO 10. Add [Test] to methods

namespace NumberSystemConverter.Tester
{
    [TestFixture]
    public class GetValueTester
    {
        [Test]
        public void AssertIf5IsV()
        {
            // Arrange
            string input = "5";
            string expectedOutput = "V";
            
            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);  // Fails because Assert expected one less in value
        }

        [Test]
        public void AssertIf4IsIV()
        {
            // Arrange
            string input = "4";
            string expectedOutput = "IV";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void AssertIf9IsIX()
        {
            // Arrange
            string input = "9";
            string expectedOutput = "IX";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void AssertIf40IsXL()
        {
            // Arrange
            string input = "40";
            string expectedOutput = "XL";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void AssertIf90IsXC()
        {
            // Arrange
            string input = "90";
            string expectedOutput = "XC";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void AssertIf400IsCD()
        {
            // Arrange
            string input = "400";
            string expectedOutput = "CD";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void AssertIf900IsCM()
        {
            // Arrange
            string input = "900";
            string expectedOutput = "CM";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string actualOutput = converter.ConvertToRomanNumeral(int.Parse(input));

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void CheckIfInvalidInputWorks()
        {
            // Arrange
            string input = "3001";

            // Act
            RomanNumeralConverter converter = new RomanNumeralConverter();
            bool invalidInputWorks = converter.CheckIfInputIsValid(input);

            // Assert
            Assert.IsTrue(invalidInputWorks);
        }
    }
}
