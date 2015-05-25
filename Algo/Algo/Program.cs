using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Point> list = new List<Point>();
            Point res = new Point(0,0);

            list.Add(new Point(-1, -3));
            list.Add(new Point(2, 1));
            list.Add(new Point(8, -4));

            //FizzBuzz.DoFizzBuzz(100);
            //Console.WriteLine(Fibonacci.DoFibonacci(5));
            res = Barycentre.DoBarycentre(list);
            Console.WriteLine("X = {0}, Y = {1}", res.X, res.Y);
        }
    }
}
