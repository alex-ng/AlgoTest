using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Fibonacci
    {
        public static int DoFibonacci(int nb)
        {
            if (nb < 2)
                return 1;
            return DoFibonacci(nb - 1) + DoFibonacci(nb - 2);
        }
    }
}
