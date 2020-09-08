using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableTest
{
    class Program
    {
        static IEnumerable<int> SelectWithoutToList(IEnumerable<int> values)
            => values.Select(v => { Console.WriteLine("Select with IEnumerable"); return v + 1; });

        static IList<int> SelectWithToList(IEnumerable<int> values)
            => values.Select(v => { Console.WriteLine("Select with IList"); return v + 1; }).ToList();

        static void ForeachTwice(IEnumerable<int> projected, string caption)
        {
            Console.WriteLine(caption);
            Console.WriteLine("------------------------------------------");
            foreach (var p in projected)
                Console.WriteLine($"Projected value is {p}");
            foreach (var p in projected)
                Console.WriteLine($"Projected value is {p}");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            var values = new List<int> { 0 };
            ForeachTwice(SelectWithoutToList(values), "Without .ToList()");
            ForeachTwice(SelectWithToList(values), "With .ToList()");
        }
    }
}
