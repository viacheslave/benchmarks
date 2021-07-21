# benchmarks

## ArrayFiller
Different methods of filling an array with the same value.
Using Integer type and [BenchmarkDotNet](https://benchmarkdotnet.org/articles/guides/getting-started.html)

Inspired by K.Kokosa tweet https://twitter.com/konradkokosa/status/1417760179072946176?s=09

Old laptop results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|           Method |       N |             Mean |          Error |         StdDev |           Median |
|----------------- |-------- |-----------------:|---------------:|---------------:|-----------------:|
|          **ForLoop** |       **4** |         **7.454 ns** |      **0.1764 ns** |      **0.4917 ns** |         **7.427 ns** |
|         SpanFill |       4 |         7.867 ns |      0.1903 ns |      0.2036 ns |         7.927 ns |
|        ArrayFill |       4 |         6.582 ns |      0.1550 ns |      0.1846 ns |         6.652 ns |
| EnumerableRepeat |       4 |        29.837 ns |      1.0084 ns |      2.9416 ns |        29.003 ns |
|           Vector |       4 |         7.242 ns |      0.1508 ns |      0.2560 ns |         7.254 ns |
|     VectorUnsafe |       4 |         7.349 ns |      0.1746 ns |      0.1868 ns |         7.403 ns |
|          **ForLoop** |      **10** |        **15.864 ns** |      **0.3144 ns** |      **0.3861 ns** |        **15.848 ns** |
|         SpanFill |      10 |        11.245 ns |      0.2515 ns |      0.2994 ns |        11.286 ns |
|        ArrayFill |      10 |        10.189 ns |      0.2311 ns |      0.2838 ns |        10.179 ns |
| EnumerableRepeat |      10 |        31.053 ns |      0.5926 ns |      0.5253 ns |        30.961 ns |
|           Vector |      10 |         7.408 ns |      0.1802 ns |      0.1686 ns |         7.451 ns |
|     VectorUnsafe |      10 |         8.111 ns |      0.0692 ns |      0.0614 ns |         8.113 ns |
|          **ForLoop** |     **100** |       **149.477 ns** |      **2.9453 ns** |      **3.8297 ns** |       **150.073 ns** |
|         SpanFill |     100 |        52.013 ns |      0.9914 ns |      0.9274 ns |        51.647 ns |
|        ArrayFill |     100 |        77.039 ns |      1.2551 ns |      1.1741 ns |        76.935 ns |
| EnumerableRepeat |     100 |       101.613 ns |      1.9881 ns |      1.8596 ns |       101.331 ns |
|           Vector |     100 |        28.149 ns |      0.5799 ns |      0.5696 ns |        28.235 ns |
|     VectorUnsafe |     100 |        34.113 ns |      0.7175 ns |      2.0585 ns |        33.542 ns |
|          **ForLoop** |    **1000** |     **1,479.875 ns** |     **28.2597 ns** |     **30.2376 ns** |     **1,485.999 ns** |
|         SpanFill |    1000 |       524.938 ns |     10.3749 ns |     13.4903 ns |       526.881 ns |
|        ArrayFill |    1000 |       650.743 ns |     12.6834 ns |     14.6062 ns |       649.274 ns |
| EnumerableRepeat |    1000 |       720.821 ns |     14.0954 ns |     17.8261 ns |       716.369 ns |
|           Vector |    1000 |       259.270 ns |      4.8561 ns |      6.3143 ns |       259.358 ns |
|     VectorUnsafe |    1000 |       311.501 ns |      6.0991 ns |      6.2634 ns |       311.947 ns |
|          **ForLoop** |   **10000** |    **14,628.800 ns** |    **261.6607 ns** |    **244.7575 ns** |    **14,647.926 ns** |
|         SpanFill |   10000 |     5,011.987 ns |     78.8189 ns |     65.8174 ns |     5,026.836 ns |
|        ArrayFill |   10000 |     6,064.872 ns |    120.6732 ns |    134.1279 ns |     6,077.274 ns |
| EnumerableRepeat |   10000 |     6,286.792 ns |    122.7673 ns |    126.0730 ns |     6,275.406 ns |
|           Vector |   10000 |     2,615.605 ns |     49.6652 ns |     48.7779 ns |     2,629.477 ns |
|     VectorUnsafe |   10000 |     2,820.813 ns |     55.8525 ns |     62.0799 ns |     2,821.610 ns |
|          **ForLoop** |  **100000** |   **330,773.592 ns** |  **6,450.9698 ns** |  **6,902.4654 ns** |   **333,918.115 ns** |
|         SpanFill |  100000 |   228,113.641 ns |  4,548.7372 ns |  5,586.2577 ns |   229,176.233 ns |
|        ArrayFill |  100000 |   242,668.495 ns |  4,741.2156 ns |  6,646.5222 ns |   244,897.949 ns |
| EnumerableRepeat |  100000 |   240,222.748 ns |  4,781.7521 ns |  5,872.4210 ns |   241,256.262 ns |
|           Vector |  100000 |   221,498.505 ns |  4,132.9553 ns |  4,059.1147 ns |   221,244.873 ns |
|     VectorUnsafe |  100000 |   219,131.230 ns |  4,306.6626 ns |  4,229.7185 ns |   219,787.048 ns |
|          **ForLoop** | **1000000** | **3,203,815.842 ns** | **61,157.7035 ns** | **65,438.0576 ns** | **3,203,581.641 ns** |
|         SpanFill | 1000000 | 2,275,043.413 ns | 43,563.9317 ns | 53,500.4204 ns | 2,301,090.039 ns |
|        ArrayFill | 1000000 | 2,356,118.848 ns | 45,537.6372 ns | 52,441.2107 ns | 2,364,718.164 ns |
| EnumerableRepeat | 1000000 | 2,368,221.500 ns | 46,724.9141 ns | 62,376.4182 ns | 2,373,231.641 ns |
|           Vector | 1000000 | 2,184,348.326 ns | 15,647.6820 ns | 13,871.2625 ns | 2,189,460.156 ns |
|     VectorUnsafe | 1000000 | 2,159,664.868 ns | 41,966.4736 ns | 41,216.6885 ns | 2,184,183.789 ns |



