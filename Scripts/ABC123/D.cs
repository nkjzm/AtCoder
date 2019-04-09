using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC123.D
{
    class Program
    {
        static void Main_()
        {
            Solve1();
        }

        static void Solve1()
        {
            var str = Console.ReadLine().Split(' ');
            var X = int.Parse(str[0]);
            var Y = int.Parse(str[1]);
            var Z = int.Parse(str[2]);
            var K = int.Parse(str[3]);
            var A = new long[X];
            var B = new long[Y];
            var C = new long[Z];
            var aa = Console.ReadLine().Split(' ');
            var bb = Console.ReadLine().Split(' ');
            var cc = Console.ReadLine().Split(' ');
            for (var i = 0; i < X; ++i)
            {
                A[i] = long.Parse(aa[i]);
            }
            for (var i = 0; i < Y; ++i)
            {
                B[i] = long.Parse(bb[i]);
            }
            for (var i = 0; i < Z; ++i)
            {
                C[i] = long.Parse(cc[i]);
            }
            var AB = new long[X * Y];
            int count = 0;
            for (var i = 0; i < X; ++i)
            {
                for (var j = 0; j < Y; ++j)
                {
                    AB[count++] = A[i] + B[j];
                }
            }
            Array.Sort(AB);
            Array.Reverse(AB);
            var ABs = AB.Take(K);
            var ABC = new long[ABs.Count() * Z];
            count = 0;
            foreach (var ab in ABs)
            {
                for (var j = 0; j < Z; ++j)
                {
                    ABC[count++] = ab + C[j];
                }
            }
            Array.Sort(ABC);
            Array.Reverse(ABC);
            var ABCs = ABC.Take(K);
            foreach (var res in ABCs)
            {
                Console.WriteLine(res);
            }
        }

        static void Solve2()
        {
            var str = Console.ReadLine().Split(' ');
            var X = int.Parse(str[0]);
            var Y = int.Parse(str[1]);
            var Z = int.Parse(str[2]);
            var K = int.Parse(str[3]);
            var A = new long[X];
            var B = new long[Y];
            var C = new long[Z];
            var aa = Console.ReadLine().Split(' ');
            var bb = Console.ReadLine().Split(' ');
            var cc = Console.ReadLine().Split(' ');
            for (var i = 0; i < X; ++i)
            {
                A[i] = long.Parse(aa[i]);
            }
            for (var i = 0; i < Y; ++i)
            {
                B[i] = long.Parse(bb[i]);
            }
            for (var i = 0; i < Z; ++i)
            {
                C[i] = long.Parse(cc[i]);
            }
            var AB = new long[X * Y];
            int count = 0;
            for (var i = 0; i < X; ++i)
            {
                for (var j = 0; j < Y; ++j)
                {
                    AB[count++] = A[i] + B[j];
                }
            }
            Array.Sort(AB);
            Array.Reverse(AB);
            var ABs = AB.Take(K);
            var ABC = new long[ABs.Count() * Z];
            count = 0;
            foreach (var ab in ABs)
            {
                for (var j = 0; j < Z; ++j)
                {
                    ABC[count++] = ab + C[j];
                }
            }
            Array.Sort(ABC);
            Array.Reverse(ABC);
            var ABCs = ABC.Take(K);
            foreach (var res in ABCs)
            {
                Console.WriteLine(res);
            }
        }

        static bool IsMax(long[] A, long[] B, long[] C, int x, int y, int z)
        {
            if (x == 0)
            {
                return false;
            }
            var aa = A[x - 1];
            var bb = y == 0 ? -1 : B[y - 1];
            var cc = z == 0 ? -1 : C[z - 1];
            return aa >= bb && aa >= cc;
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

