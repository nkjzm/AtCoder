using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC123.C
{
    class Program
    {
        static void Main_()
        {
            var N = long.Parse(Console.ReadLine());
            var limits = new long[5];
            for (var i = 0; i < 5; ++i)
            {
                limits[i] = long.Parse(Console.ReadLine());
            }
            var time = (Math.Ceiling((((Decimal)N) / Min(limits)))) + 4;
            Console.WriteLine(time);
        }

        static long Min(long[] nums)
        {
            var min = long.MaxValue;
            foreach (var n in nums)
            {
                min = min < n ? min : n;
            }
            return min;
        }
    }
}

