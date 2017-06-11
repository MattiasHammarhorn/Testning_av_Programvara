using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Library: Convert int to string

// TODO 1. Change class name from Class1 to Counter
// TODO 2. Change filename from Class1.cs to Counter.cs

// TODO 3. Add method Convert_Debit(int input)
// TODO 4. Add method Convert_Credit(int input)
// TODO 5. Add method Convert_Balance(int input)

namespace Bank_Övning_i_TDD_med_NUnit.Library
{
    public class Counter
    {
        int saldo = 1000;

        public int Debit(int input)
        {
            return saldo - input;
        }

        public int Credit(int input)
        {
            return saldo + input;
        }

        public int Balance()
        {
            return saldo;
        }

        public int DebitWhenZeroOrBelow(int debitSum)
        {
            throw new NotImplementedException();
        }
    }
}
