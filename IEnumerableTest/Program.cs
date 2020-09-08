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
            Console.WriteLine("IEnumerable twice");
            Console.WriteLine("------------------------------------------");
            var projectedWithIEnumerable = MakeAndReturnIEnumerable(values);
            foreach (var p in projectedWithIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            Console.WriteLine("");

            // IList twice
            Console.WriteLine("IList twice");
            Console.WriteLine("------------------------------------------");
            var projectedWithIList = MakeAndReturnIList(values);
            foreach (var p in projectedWithIList)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIList)
                Console.WriteLine($"Selected value is {p}");
            Console.WriteLine("");


            // List -> IEnumerable twice
            Console.WriteLine("List used via IEnumerable twice");
            Console.WriteLine("------------------------------------------");
            var projectedWithIListReturnIEnumerable = MakeListAndReturnIEnumerable(values);
            foreach (var p in projectedWithIListReturnIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            foreach (var p in projectedWithIListReturnIEnumerable)
                Console.WriteLine($"Selected value is {p}");
            Console.WriteLine("");
        }
    }
}
