using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektarbete.Library;

// 1. Add public void Start()
// 2. Instansiate Converter
// 3. Build for-loop to declare and iterate an int up to the value of 100

namespace Projektarbete
{
    class Runtime
    {
        public void Start()
        {
            Converter converter = new Converter();

            for (int input = 1; input <= 100; input++)  // Declaration of int input that exists only inside this loop
            {
                Console.WriteLine(converter.ChecksInputDividesAndReturns(input));    // Send in our input into the converter method and write out the results
            }
        }
    }
}
