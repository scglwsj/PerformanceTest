using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Framework.ConsoleApp
{
    public class CryptoTest
    {
        public static long Test(long loopTime)
        {
            long sum = 0;
            while (loopTime-- > 0)
            {
                var raw = new byte[100 * 1024 * 1024];
                for (var i = 0; i < raw.Length; i++) raw[i] = (byte) i;

                using (var sha = SHA256.Create())
                {
                    var sw = Stopwatch.StartNew();
                    sha.ComputeHash(raw);
                    sum += sw.ElapsedMilliseconds;
                }
            }

            return sum;
        }
    }
}