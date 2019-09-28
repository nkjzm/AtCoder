using System;
using System.Linq;

namespace AtCoder.ABC124.A
{
    class Program
    {
        public static void Main_()
        {
            // Solve(5, 3);
            // Solve(3, 4);
            // Solve(6, 6);
            // return;
            var str = Console.ReadLine().Split(' ');
            var A = int.Parse(str[0]);
            var B = int.Parse(str[1]);
            Solve(A, B);
        }

        static void Solve(int A, int B)
        {
            var coin = 0;
            if (A > B)
            {
                coin += A;
                --A;
            }
            else
            {
                coin += B;
                --B;
            }
            if (A > B)
            {
                coin += A;
                --A;
            }
            else
            {
                coin += B;
                --B;
            }
            Console.WriteLine(coin);
        }
    }
}
