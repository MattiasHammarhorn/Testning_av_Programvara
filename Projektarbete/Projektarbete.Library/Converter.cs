using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO 1. Change class name from Class1 to Converter
// TODO 2. Change class file name from Class1.cs to Converter

// TODO 3. Add method ReturnsCokeWhenDividableByThree()
// TODO 4. Add method ReturnsColaWhenDividableByFive()
// TODO 5. Add method ReturnsCokeWhenDividableByFiveAndThree()

namespace Projektarbete.Library
{
    public class Converter
    {
        // A method that takes in an int paramter named 'input', checks if it's dividable by three and five
        // and returns a string based on if it does or not
        public string ChecksInputDividesAndReturns(int input)
        {
            // An empty string of text to store our future values                                                           
            string concatinator = string.Empty;

            // If the value can be divided by three
            if (input % 3 == 0)                                     
            {
                // Coca will be added into the value of our concatinator
                concatinator += "Coca";
            }

            // If the value can be divided by five
            if (input % 5 == 0)
            {
                // Cola will be added int the value of our concatinator
                concatinator += "Cola";
            }

            #region Old stuff
            //if (input % 3 == 0)
            //    return concatinator += "Coca";

            //else if (input % 5 == 0)
            //    return concatinator += "Cola";

            //else if (input % 3 == 0 && input % 5 == 0)
            //    return concatinator += "CocaCola";

            //else
            //    return input.ToString();
            #endregion

            #region Older stuff
            //if (input % 3 == 0)
            //    return "Coca";

            //else if (input % 5 == 0)
            //    return "Cola";

            //else if (input % 3 == 0 && input % 5 == 0)
            //    return "Cocacola";

            //else
            //    return input.ToString();
            #endregion

            // Returns the input that was sent into our method, containing the string we declared here
            return input.ToString(concatinator);
        }
    }
}
