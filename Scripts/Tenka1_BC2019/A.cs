using System;
using System.Linq;

namespace AtCoder.Tenka1_BC2019.A
{
    class Program
    {
        static void Rep(long n, Action<long> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(long n, long s, Action<long> action) { for (var i = s; i < n; ++i) { action(i); } }
        public static void Main_()
        {
            // NG: #.
            // #.# 1
            // ..#
            // #.##. 2
            // #.##. 2
            // #####
            // OK
            // ......#
            // .#######

            // Solve(3, "#.#"); // 1
            // Solve(5, "#.##."); // 2
            // Solve(9, "........."); // 0
            // Solve(5, "####."); // 1
            // Solve(5, "###.."); // 2
            // Solve(5, "#...#"); // 1
            // Solve(5, "#...."); // 1
            // Solve(5, ".###."); // 1
            // Solve(5, "####."); // 1
            // Solve(5, "#####"); // 0
            // Solve(5, ".####"); // 0
            // Solve(5, "#.###"); // 1
            // Solve(5, "..###"); // 1
            // Solve(5, "....."); // 0
            // Solve(5, "....#"); // 0
            // Solve(5, "...#."); // 1
            // Solve(6, ".###.."); // 2
            // Solve(6, ".#.#.#"); // 2
            // Solve(6, "#.#.#."); // 3
            // [.#]####
            // ....[.#]

            var N = long.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            Solve(N, S);
        }

        static void Solve(long N, string S)
        {
            Console.WriteLine(0);
            return;
            long count1 = 0; // ?#######との比較
            long count2 = 0; // ......?との比較
            Rep(N, i =>
             {
                 if (S[(int)i] == '#')
                 {
                     ++count2;
                 }
                 else
                 {
                     ++count1;
                 }
             });
            if (S[(int)N - 1] == '#')
            {
                --count2;
            }
            if (S[0] != '#')
            {
                --count1;
            }
            Console.WriteLine(count1 >= count2 ? count2 : count1);
        }
    }
}
