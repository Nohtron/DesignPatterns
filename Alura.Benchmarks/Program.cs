using BenchmarkDotNet.Running;

namespace Alura.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ISSCalculaSpeed>();
        }
    }
}
