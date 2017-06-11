using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Projektarbete.Library;

// TODO 1. Change class name from Class1 to DividerTester
// TODO 2. Change class name from Class1.cs to DividerTester.cs

// TODO 3. Add reference Projektarbete.Library to this project
// TODO 4. Install NUnit 3 to this project through NuGet
// TODO 5. Add using NUnit.Framework;
// TODO 6. Add using Projectarbete.Library;

// TODO 7. Add [TestFixture] to class
// TODO 8. Add testcases ReturnsCokeWhenDividableByThree(), ReturnsColaWhenDividableByFive() and ReturnsCocaColaWhenDividableByFiveAndThree()
// TODO 9. Add [Test] to method

namespace Projektarbete.Library.Tester
{
    [TestFixture]
    public class DividerTester
    {
        [Test]
        public void ReturnsCokeWhenDividableByThree()
        {
            // Arrange
            int input = 3;
            string expectedOutput = "Coca";

            // Act
            Converter converter = new Converter();
            string actualOutput = converter.ChecksInputDividesAndReturns(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void ReturnsColaWhenDividableByFive()
        {
            // Arrange
            int input = 5;
            string expectedOutput = "Cola";

            // Act
            Converter converter = new Converter();
            string actualOutput = converter.ChecksInputDividesAndReturns(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void ReturnsCocaColaWhenDividableByFiveAndThree()
        {
            // Arrange
            int input = 15;
            string expectedOutput = "CocaCola";

            // Act
            Converter converter = new Converter();
            string actualOutput = converter.ChecksInputDividesAndReturns(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
