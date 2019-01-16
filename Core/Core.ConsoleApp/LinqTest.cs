using System.Diagnostics;
using System.Linq;

namespace Core.ConsoleApp
{
    public class LinqTest
    {
        public static long Test(long loopTime)
        {
            var tenMillionToZero = Enumerable.Range(0, 10_000_000).Reverse().ToArray();
            long sum = 0;
            while (loopTime-- > 0)
            {
                var sw = Stopwatch.StartNew();
                var fifth = tenMillionToZero.Select(i => i).ToList().OrderBy(i => i).Skip(4).First();
                sum += sw.ElapsedMilliseconds;
            }

            return sum;
        }
    }
}