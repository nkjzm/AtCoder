using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtCoder.ABC124.D
{
    class Program
    {
        static void Rep(int n, Action<int> action) { for (var i = 0; i < n; ++i) { action(i); } }
        static void Rep(int n, int s, Action<int> action) { for (var i = s; i < n; ++i) { action(i); } }

        public static void Main_()
        {
            Solve(5, 1, "00010"); // 4
            Solve(14, 2, "11101010110011"); // 8
            Solve(1, 1, "1"); // 1
            return;
            var str = Console.ReadLine().Split(' ');
            var N = int.Parse(str[0]);
            var K = int.Parse(str[1]);
            var S = Console.ReadLine();
            Solve(N, K, S);
        }

        // 総当たり
        // TBD

        // 長い0を埋める戦略
        //10001011 ok
        //1000101111111111 ng

        // 連続した1の近くを埋める戦略
        //10001011 ng
        //1000101111111111 ok

        // 1+(0+)1+が最も長い場所を探す
        //10001011 ok 1011を抽出
        //1000101111111111 ok 101111111111を抽出
        //これっぽい

        static void Solve(int N, int K, string S)
        {
            Rep(K, j =>
              {
                  Console.WriteLine("---" + S);
                  var max = 0;
                  var maxPattern = "";
                  var r = new Regex(@"1+(0+)1+", RegexOptions.Compiled);
                  var matches = r.Matches(S);
                  foreach (Match m in matches)
                  {
                      Console.WriteLine(m);
                      if (m.Value.Length > max)
                      {
                          max = m.Value.Length;
                          maxPattern = m.Value;
                      }
                  }

                  var after = "";
                  Rep(max, i =>
                   {
                       after += "1";
                   });
                  if (!string.IsNullOrEmpty(maxPattern))
                  {
                      S = S.Replace(maxPattern, after);
                  }
              });
            {
                var r = new Regex(@"1+", RegexOptions.Compiled);
                var max = 0;
                var matches = r.Matches(S);
                foreach (Match m in matches)
                {
                    if (m.Value.Length > max)
                    {
                        max = m.Value.Length;
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}

