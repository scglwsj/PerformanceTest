using System;

namespace Framework.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int loopTime = 10;

            var listMilliseconds = ListTest.Test(loopTime);
            WriteResult("链表测试", listMilliseconds, loopTime);

            var linqMilliseconds = LinqTest.Test(loopTime);
            WriteResult("Linq测试", linqMilliseconds, loopTime);

            var cryptoMilliseconds = CryptoTest.Test(loopTime);
            WriteResult("加密测试", cryptoMilliseconds, loopTime);

            var binaryFormatterMilliseconds = BinaryFormatterTest.Test();
            WriteResult("二进制序列化测试", binaryFormatterMilliseconds, 1);

            Console.WriteLine("按任意键退出:");
            Console.ReadKey();
        }

        private static void WriteResult(string testName, long totalTime, long loopTime)
        {
            Console.WriteLine($"{testName}在framework中耗时{totalTime}毫秒。");
            Console.WriteLine($"{testName}在framework中平均耗时{totalTime / loopTime}毫秒。");
        }
    }
}
