using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public class Class1
    {
        /*
         * Instead than ordering the sums, I first order the input and then calculate the sums in sequence like in Q1
         * I get necessarily the greatest 3 sums with not adjacent groups
         */
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
