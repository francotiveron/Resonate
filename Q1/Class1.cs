using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public static class Extensions {
        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] array, int size) {
            for (var i = 0; i < (float)array.Length / size; i++) {
                yield return array.Skip(i * size).Take(size);
            }
        }
    }
    public class Class1
    {
        public static int[] FindLargest3Sums(int[] inp) {
            return inp
                    .Split(3)
                    .Select(grp => grp.Sum())
                    .OrderByDescending(n => n)
                    .Concat(new int[] {0, 0, 0})
                    .Take(3)
                    .ToArray();
        }
        public static int[] FindLargest3SumsNonAdj(int[] inp) {
            return inp
                    .OrderByDescending(n => n)
                    .ToArray()
                    .Split(3)
                    .Select(grp => grp.Sum())
                    .Concat(new int[] { 0, 0, 0 })
                    .Take(3)
                    .ToArray();
        }
    }
}
