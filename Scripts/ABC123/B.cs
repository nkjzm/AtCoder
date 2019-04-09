using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC123.B
{
    class Program
    {
        public static void Main_()
        {
            var nums = new int[5];
            for (var i = 0; i < 5; ++i)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            var res = new List<int>();
            for (var i1 = 0; i1 < 5; ++i1)
            {
                for (var i2 = 0; i2 < 5; ++i2)
                {
                    if (i1 == i2) { continue; }
                    for (var i3 = 0; i3 < 5; ++i3)
                    {
                        if (i1 == i3) { continue; }
                        if (i2 == i3) { continue; }
                        for (var i4 = 0; i4 < 5; ++i4)
                        {
                            if (i1 == i4) { continue; }
                            if (i2 == i4) { continue; }
                            if (i3 == i4) { continue; }
                            for (var i5 = 0; i5 < 5; ++i5)
                            {
                                if (i1 == i5) { continue; }
                                if (i2 == i5) { continue; }
                                if (i3 == i5) { continue; }
                                if (i4 == i5) { continue; }
                                var sum = 0;
                                sum = (int)(Math.Ceiling((sum + nums[i1]) / 10f) * 10f);
                                sum = (int)(Math.Ceiling((sum + nums[i2]) / 10f) * 10f);
                                sum = (int)(Math.Ceiling((sum + nums[i3]) / 10f) * 10f);
                                sum = (int)(Math.Ceiling((sum + nums[i4]) / 10f) * 10f) + nums[i5];
                                res.Add(sum);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(res.OrderBy(n => n).First());
        }
    }
}

