using System;
using System.Linq;

namespace AtCoder.Hoge.A
{
    class Program
    {
        public static void Main_()
        {
            Solve();
        }

        static void Solve()
        {
        }

        static void Rep(long n, Action<long> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(long n, int s, Action<long> action) { for (var i = s; i < n; ++i) { action(i); } }

        static string Read() { return Console.ReadLine(); }
        static int ReadInt() { return int.Parse(Read()); }
        static long ReadLong() { return long.Parse(Read()); }
        static int[] ReadArrayInt() { return Read().Split(' ').Select(s => int.Parse(s)).ToArray(); }
        static long[] ReadArrayLong() { return Read().Split(' ').Select(s => long.Parse(s)).ToArray(); }
    }
}
