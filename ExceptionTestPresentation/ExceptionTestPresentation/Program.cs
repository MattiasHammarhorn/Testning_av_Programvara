using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            do
            {
                result = Run();
            } while (result);
        }

        private static bool Run()
        {
            // Täljare
            int numerator;
            // Nämnare
            int denominator;
            bool functionResult = false;

            try
            {
                Console.Clear();
                Console.WriteLine("Division: _ / x");
                numerator = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Division: {0} / x", numerator);
                denominator = int.Parse(Console.ReadLine());
                Console.Clear();
                double result = SafeDivide(numerator, denominator);
                Console.WriteLine("Divison: {0} / {1} = {2}", numerator, denominator, result);
            } catch(Exception ex)
            {
                if(ex is ArgumentException || ex is OverflowException || ex is System.IO.IOException || ex is ArgumentNullException || ex is FormatException)
                {
                    Console.WriteLine("Invalid integer input led to error: {0}", ex.Message);
                }
                else if(ex is NullDenominatorException)
                {
                    Console.WriteLine("Divsion by zero: {0}", ex.Message);
                }
            }
            finally
            {
                numerator = 0;
                denominator = 0;
                // Console.Clear();
            }
            functionResult = true;
            Console.ReadKey();
            return functionResult;
        }

        private static double SafeDivide(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new NullDenominatorException("Exception Message From SafeDivide()");
            }
            return numerator / denominator;
        }

        public class NullDenominatorException : Exception
        {
            public override string Message
            {
                get
                {
                    return "Exception for Division By Zero";
                }
            }

            public NullDenominatorException() : base()
            {

            }
            public NullDenominatorException(string message) : base(message)
            {
                
            }
            public NullDenominatorException(string message, Exception inner) : base(message, inner)
            {

            }
        }
    }
}
