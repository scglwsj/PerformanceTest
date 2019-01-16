using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Framework.ConsoleApp
{
    public class BinaryFormatterTest
    {
        public static long Test()
        {
            var books = new List<Book>();
            for (var i = 0; i < 1_000_000; i++)
            {
                var id = i.ToString();
                books.Add(new Book {Name = id, Id = id});
            }

            var formatter = new BinaryFormatter();
            var mem = new MemoryStream();
            formatter.Serialize(mem, books);
            mem.Position = 0;

            var sw = Stopwatch.StartNew();
            formatter.Deserialize(mem);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        [Serializable]
        private class Book
        {
            public string Name;
            public string Id;
        }
    }
}