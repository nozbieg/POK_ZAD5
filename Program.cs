using System;
using System.Collections.Generic;

namespace POK_ZAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<Data> f = new List<Data>()
            {
                 new Data(0, 2),
                 new Data(1, 3),
                 new Data(2, 12),
                 new Data(5, 147),
                 new Data(12, 53),
                 new Data(25, 33),
                 new Data(57, 68),
            };


            var results = Lagrange.InterpolateAll(f, f.Count, f.Count);
            var pos = 1;
            foreach (var res in results)
            {

                Console.WriteLine("Value of f(" + pos + ") is : " + res);
                pos++;
            }
        }
    }
}
