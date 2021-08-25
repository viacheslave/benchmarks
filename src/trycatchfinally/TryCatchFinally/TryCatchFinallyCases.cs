using BenchmarkDotNet.Attributes;

namespace TryCatchFinally
{
  public class TryCatchFinallyCases
  {
    [Benchmark]
    public void Using()
    {
      using var _ = new DisposableInstance();
    }

    [Benchmark]
    public void CreateDispose()
    {
      var obj = new DisposableInstance();
      obj.Dispose();
    }
  }
}
