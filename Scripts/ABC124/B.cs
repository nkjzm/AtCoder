using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC124.B
{
    class Program
    {
        static void Rep(long n, Action<long> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(long n, long s, Action<long> action) { for (var i = s; i < n; ++i) { action(i); } }


        public static void Main_()
        {
            // Solve(4, new int[] { 6, 5, 6, 8 });
            // Solve(5, new int[] { 4, 5, 3, 5, 4 });
            // Solve(5, new int[] { 9, 5, 6, 8, 4 });
            // return;
            var N = int.Parse(Console.ReadLine());
            var str = Console.ReadLine().Split(' ');
            var H = new int[N];
            Rep(N, i =>
             {
                 H[i] = int.Parse(str[i]);
             });
            Solve(N, H);
        }

        static void Solve(int N, int[] H)
        {
            var count = 0;
            var max = H[0];
            Rep(N, i =>
            {
                if (H[i] >= max)
                {
                    ++count;
                    max = H[i];
                }
            });

            Console.WriteLine(count);
        }
    }
}

