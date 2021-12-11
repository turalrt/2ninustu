using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class PowerOf2
    {
        public int n;
        public void isPowerOfTwo(int n)
        {
            if (n == 0)
                Console.WriteLine("Enter number again!");

            while (n != 1)
            {
                if (n % 2 != 0)
                    Console.WriteLine("No");

                n = n / 2;
            }
            Console.WriteLine("Yes");
        }
    }
}
