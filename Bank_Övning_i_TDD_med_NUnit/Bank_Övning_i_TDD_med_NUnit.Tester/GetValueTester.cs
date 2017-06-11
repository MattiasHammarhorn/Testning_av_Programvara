using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Övning_i_TDD_med_NUnit.Library;
using NUnit.Framework;

namespace Bank_Övning_i_TDD_med_NUnit.Tester
{
    // TODO 1. Change class name from Class1 to GetValueTester
    // TODO 2. Change class file name from Class1 to GetValueTester
    // TODO 3. Add reference Bank_Övning_i_TDD_NUnit.Library TO unit test project
    // TODO 4. Install NUnit 3 to this project through NuGet.
    // TODO 5. Add using NUnit.Framework
    // TODO 6. Install NUnit Adapter from Tools-Extensions and Updates
    // TODO 7. Add [TextFixture] to class
    // TODO 8. Add testcases Counter_Debit, Counter_Credit and Counter_Balance;
    // TODO 9. ADD [Test] to method

    [TestFixture]
    public class GetValueTester
    {
        [Test]
        public void Counter_Debit()
        {
            // Arrange (Prepare test case with the required attributes)
            int input = 1;
            int expectedOutput = 1000 - input;

            // Act (Perform the actual test case with actualOutput)
            Counter counter = new Counter();
            int actualOutput = counter.Debit(input);

            // Assert (Check för errors based on the expectedOutput)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Counter_Credit()
        {
            // Arrange (Prepare test case with the required attributes)
            int input = 1;
            int expectedOutput = 1000 + input;

            // Act (Perform the actual test case with actualOutput)
            Counter counter = new Counter();
            int actualOutput = counter.Credit(input);

            // Assert (Check för errors based on the expectedOutput)
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Counter_Balance()
        {
            // Arrange (Prepare test case with the required attributes)
            int expectedOutput = 1000;

            // Act (Perform the actual test case with actualOutput)
            Counter counter = new Counter();
            int actualOutput = counter.Balance();

            // Assert (Check för errors based on the expectedOutput)
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
