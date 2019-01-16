using System.Collections.Generic;
using System.Diagnostics;

namespace Core.ConsoleApp
{
    public class ListTest
    {
        public static long Test(long loopTime)
        {
            long sum = 0;
            while (loopTime-- > 0)
            {
                var l = new List<int>();
                var sw = Stopwatch.StartNew();
                for (var i = 0; i < 100_000_000; i++)
                {
                    l.Add(i);
                    l.RemoveAt(0);
                }

                sum += sw.ElapsedMilliseconds;
            }

            return sum;
        }
    }
}