using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC124.C
{
    class Program
    {
        static void Rep(int n, Action<int> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(int n, int s, Action<int> action) { for (var i = s; i < n; ++i) { action(i); } }


        public static void Main_()
        {
            // Solve("000"); // 1  ng:2
            // Solve("10010010"); // 3 ng:5 
            // Solve("0"); // 0 ng:1

            // return;
            var S = Console.ReadLine();
            Solve(S);
        }

        static void Solve(string S)
        {
            var len = S.Length;
            // var p1 = "";
            // Rep(len / 2, i =>
            // {
            //     p1 += "01";
            // });
            // if (len % 2 == 1)
            // {
            //     p1 += "0";
            // }
            var count = 0;
            Rep(len, i =>
            {
                if (S[(int)i] != (i % 2 == 0 ? '0' : '1'))
                {
                    ++count;
                }
            });
            if (count > len / 2)
            {
                Console.WriteLine(len - count);
            }
            else
            {
                Console.WriteLine(count);
            }
        }
        static int popcount3(int x)
        {
            x = (x & 0x55555555) + (x >> 1 & 0x55555555);
            x = (x & 0x33333333) + (x >> 2 & 0x33333333);
            x = (x & 0x0F0F0F0F) + (x >> 4 & 0x0F0F0F0F);
            x = (x & 0x00FF00FF) + (x >> 8 & 0x00FF00FF);
            x = (x & 0x0000FFFF) + (x >> 16 & 0x0000FFFF);
            return x;
        }
    }
}

