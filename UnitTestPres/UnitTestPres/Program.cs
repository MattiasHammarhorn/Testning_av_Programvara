using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestPres.Library;

namespace UnitTestPres
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            string two = converter.convertIntToString(2);
            Console.WriteLine(two);
        }
    }
}
