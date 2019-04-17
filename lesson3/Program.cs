using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson3
{
    public class Program
    {   
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
            Console.ReadLine();
        }

        [Benchmark]
        public void Union()
        {
            List<Barcelona> barcelonas = CsvParser.Parse("Barcelona1.csv", false);
            List<Barcelona> barcelonas2 = CsvParser.Parse("barcelona2.csv", true);
            
            var unionResult = barcelonas.Union(barcelonas2);
            Console.WriteLine(@"Union count {0}", unionResult.Count());
        }

        [Benchmark]
        public void UnionAll()
        {
            List<Barcelona> barcelonas = CsvParser.Parse("Barcelona1.csv", false);
            List<Barcelona> barcelonas2 = CsvParser.Parse("barcelona2.csv", true);

            var unionAllResult = barcelonas.UnionAll(barcelonas2);
            Console.WriteLine(@"UnionAll count {0}", unionAllResult.Count());
        }
    }
}
