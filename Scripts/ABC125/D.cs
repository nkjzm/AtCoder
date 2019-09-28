using System;
using System.Linq;

namespace AtCoder.ABC125.D
{
    class Program
    {
        static void Rep(long n, Action<long> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(long n, long s, Action<long> action) { for (var i = s; i < n; ++i) { action(i); } }

        public static void Main_()
        {
            // 00, 0000, 0000 = 0
            // 01, 0001, 0001 = 1
            // 02, 0010, 0011 = 3
            // 03, 0011, 0000 = 0
            // 04, 0100, 0100 = 4
            // 05, 0101, 0001 = 1
            // 06, 0110, 0111 = 7
            // 07, 0111, 0000 = 0
            // 08, 1000, 1000 = 8
            // 09, 1001, 0001 = 1
            // 10, 1010, 1011 = 11
            // 11, 1011, 0000 = 0


            Solve(2, 3);
            Solve(3, 4);
            Solve(4, 5);
            Solve(2, 4);
            Solve(123, 456);
            Solve(123456789012, 123456789012);
            Solve(2, 123456789012);
            return;
            var str1 = Console.ReadLine().Split(' ');
            var A = long.Parse(str1[0]);
            var B = long.Parse(str1[1]);
            Solve(A, B);
        }

        static void Solve(long A, long B)
        {
            long ans = 0;
            Rep(B - A + 1, i =>
            {
                ans ^= A + i;
            });
            Console.WriteLine(ans);
        }
    }
}
