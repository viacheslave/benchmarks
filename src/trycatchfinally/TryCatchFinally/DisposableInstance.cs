using System;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using BenchmarkDotNet.Attributes;

namespace TryCatchFinally
{
  public class DisposableInstance : IDisposable
  {
    private long _field;

    public DisposableInstance() => _field = DateTime.Now.Ticks;

    public void Dispose() => _field = DateTime.Now.Ticks;
  }
}
