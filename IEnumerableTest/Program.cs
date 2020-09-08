using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableTest
{
    class Program
    {
        static IEnumerable<int> MakeAndReturnIEnumerable(IEnumerable<int> values)
            => values.Select(v => { Console.WriteLine("Select with IEnumerable"); return v + 1; });

        static IList<int> MakeAndReturnIList(IEnumerable<int> values)
            => values.Select(v => { Console.WriteLine("Select with IList"); return v + 1; }).ToList();

        static IEnumerable<int> MakeListAndReturnIEnumerable(IEnumerable<int> values)
            => values.Select(v => { Console.WriteLine("Select with IList"); return v + 1; }).ToList();

        static void Main(string[] args)
        {
            var values = new List<int> { 0 };

            // IEnumerable twice
            var projectedWithIEnumerable = MakeAndReturnIEnumerable(values);
            foreach (var p in projectedWithIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIEnumerable)
                Console.WriteLine($"Selected value is {p}");

            // IList twice
            var projectedWithIList = MakeAndReturnIList(values);
            foreach (var p in projectedWithIList)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIList)
                Console.WriteLine($"Selected value is {p}");

            // IList -> IEnumerable twice
            var projectedWithIListReturnIEnumerable = MakeListAndReturnIEnumerable(values);
            foreach (var p in projectedWithIListReturnIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIListReturnIEnumerable)
                Console.WriteLine($"Selected value is {p}");

        }
    }
}
