using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Demo
{
    class Calc
    {
        public static object tailRecursionFactorial(int n,BigInteger acc)
        {
            if (n == 0) return TailRecursion.Return(acc);
            return TailRecursion.Next(() =>(RecursionResult < BigInteger >) tailRecursionFactorial(n - 1, n * acc));
        }

        public static BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n*Factorial(n - 1);
        }
    }
}
