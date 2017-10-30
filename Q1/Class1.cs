using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Class1
    {
        public static int[] FindLargest3Sums1(int[] inp) {
            int len = inp.Length;
            int[] sums3 = new int[Math.Max(len / 3 + 1, 3)];
            for (int i = 0; i < len; i++) sums3[i / 3] += inp[i];

            return sums3
            .OrderByDescending(n => n)
            .Take(3)
            .ToArray();
        }
        public static int[] FindLargest3Sums(int[] inp) {
            int len = inp.Length;
            inp = inp.OrderByDescending(n => n).ToArray();
            int[] sums3 = new int[Math.Max(len / 3 + 1, 3)];
            for (int i = 0; i < len; i++) sums3[i / 3] += inp[i];

            return sums3
            .Take(3)
            .ToArray();
        }
    }
}
