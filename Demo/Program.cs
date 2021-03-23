using System;
using System.Numerics;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int factValue = 50000;

            object result = TailRecursion.Execute(() => (RecursionResult<BigInteger>)Calc.tailRecursionFactorial(factValue, 1));
            Console.WriteLine(result);

            BigInteger overflowRes = Calc.Factorial(factValue);
            Console.WriteLine(overflowRes);
        }
    }
}
