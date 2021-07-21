using BenchmarkDotNet.Running;

namespace ArrayFiller
{
  class Program
	{
		static void Main(string[] args)
		{
      var summary = BenchmarkRunner.Run<IntArrayFiller>();
    }
	}
}
