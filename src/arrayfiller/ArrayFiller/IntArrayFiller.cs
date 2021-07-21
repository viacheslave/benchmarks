using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using BenchmarkDotNet.Attributes;

namespace ArrayFiller
{
  public class IntArrayFiller
  {
    [Params(4, 10, 100, 1_000, 10_000, 100_000, 1_000_000)]
    public int N { get; set; }

    public int Value = 42;

    [Benchmark]
    public void ForLoop()
    {
      var arr = new int[N];
      for (var i = 0; i < N; i++)
        arr[i] = Value;
    }

    [Benchmark]
    public void EnumerableRepeat()
    {
      var arr = Enumerable.Repeat(Value, N).ToArray();
    }

    [Benchmark]
    public void Vector()
    {
      var arr = new int[N];

      var offset = Vector<int>.Count;
      var filler = new Vector<int>(Value);
      var i = 0;

      for (; i < arr.Length - offset; i += offset)
        filler.CopyTo(arr, i);

      for (; i < arr.Length; i++)
        arr[i] = Value;
    }

    [Benchmark]
    public void VectorUnsafe()
    {
      var arr = new int[N];

      var offset = Vector256<int>.Count;
      var filler = Vector256.Create(Value);
      var i = 0;

      for (; i < arr.Length - offset; i += offset)
        Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref arr[i]), filler);

      for (; i < arr.Length; i++)
        arr[i] = Value;
    }
  }
}
