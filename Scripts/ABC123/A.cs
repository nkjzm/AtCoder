using System;
using System.Linq;

namespace AtCoder.ABC123.A
{
    class Program
    {
        public static void Main_()
        {
            var a = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            var e = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine(e - a > k ? ":(" : "Yay!");
        }
    }
}
