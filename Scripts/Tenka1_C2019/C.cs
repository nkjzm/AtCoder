using System;
using System.Linq;

namespace AtCoder.Tenka1_C2019.C
{
    class Program
    {
        static void Rep(long n, Action<long> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(long n, int s, Action<long> action) { for (var i = s; i < n; ++i) { action(i); } }
        public static void Main()
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
            // ....####

            Solve(3, "#.#"); // 1
            Solve(5, "#.##."); // 2
            Solve(9, "........."); // 0
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
            // Solve(1, "."); // 0
            // Solve(1, "#"); // 0
            // Solve(2, ".."); // 0
            // Solve(2, ".#"); // 0
            // Solve(2, "#."); // 1
            // Solve(2, "##"); // 0
            Solve(10, "##...##.##"); // 3
            // [.#]####
            // ....[.#]

            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();
            Solve(N, S);
        }

        static void Solve_(long N, string S)
        {
            int count1 = 0; // ?#######との比較
            int count2 = 0; // ......?との比較
            Rep(S.Length, i =>
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
            if (S.Last() == '#')
            {
                --count2;
            }
            if (S.First() != '#')
            {
                --count1;
            }
            // if (count1 < 0)
            // {
            //     count1 = 0;
            // }
            // if (count2 < 0)
            // {
            //     count2 = 0;
            // }
            Console.WriteLine((int)(count1 >= count2 ? count2 : count1));
        }

        // Solve(3, "#.#"); // 1
        // Solve(5, "#.##."); // 2
        // Solve(9, "........."); // 0

        static void Solve(int N, string S)
        {
            var black = 0;
            var white = 0;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '.') white++;
            }
            var ans = white;
            for (int i = 0; i < N; i++)
            {
                if (S[i] == '#')
                {
                    black++;
                }
                else
                {
                    white--;
                }
                if (black + white < ans) ans = black + white;
            }

            Console.WriteLine(ans);
        }
    }
}
