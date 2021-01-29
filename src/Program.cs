using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace src
{
    class Program
    {
        static void Main(string[] args) {
            var summary = BenchmarkRunner.Run<DataTableMonitor>();            
        }
    }
}
