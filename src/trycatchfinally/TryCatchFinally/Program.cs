using BenchmarkDotNet.Running;

namespace TryCatchFinally
{
  class Program
	{
		static void Main(string[] args)
		{
      var summary = BenchmarkRunner.Run<TryCatchFinallyCases>();
    }
	}
}
