using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main()
        {
            PowerOf2 powerof2 = new PowerOf2();
            powerof2.n = 8;
            powerof2.isPowerOfTwo(powerof2.n);
        }
    }
}
