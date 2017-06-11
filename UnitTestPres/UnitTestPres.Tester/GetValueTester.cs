using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestPres.Library;
using NUnit.Framework;

// TODO 1. Change class name from Class1 to GetValueTester
// TODO 2. Change class file name from Class 1.cs to GetValueTester.cs
// TODO 3. Add reference UnitTestPres.Library TO unit test project
// TODO 4. Through NuGet, install NUnit 3 to this project. Add using NUnit.FrameWork
// TODO 5. Add using NUnit.FrameWork
// TODO 6. Install NUnit Adapter from Tools-Extensions and Updates
// TODO 7. Add [TestFixture] to class
// TODO 8. Add Testcase named Converter_From_Int_1_To_String1()
// TODO 9. Add [Test] to method

namespace UnitTestPres.Tester
{
    [TestFixture]
    public class GetValueTester
    {
        [Test]
        public void Converter_From_Int_1_To_String1()
        {
            // Arrange (Prepare test case with the required attributes)
            int input = 1;
            string expectedOutput = "1";

            // Act (Perform the test case and the actualOutput)
            Converter converter = new Converter();
            string actualOutput = converter.convertIntToString(input);

            // Assert (Check for errors based on the expectedOutput)
            Assert.AreEqual(expectedOutput, actualOutput);   
        }
    }
}
