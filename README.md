# benchmarks

## ArrayFiller
Different methods of filling an array with the same value.
Using Integer type and [BenchmarkDotNet](https://benchmarkdotnet.org/articles/guides/getting-started.html)

Some results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|           Method |       N |             Mean |          Error |         StdDev |
|----------------- |-------- |-----------------:|---------------:|---------------:|
|          **ForLoop** |       **4** |         **6.945 ns** |      **0.1702 ns** |      **0.1671 ns** |
| EnumerableRepeat |       4 |        25.159 ns |      0.5233 ns |      0.5816 ns |
|           Vector |       4 |         6.426 ns |      0.1372 ns |      0.1283 ns |
|     VectorUnsafe |       4 |         6.382 ns |      0.1603 ns |      0.1500 ns |
|          **ForLoop** |      **10** |        **14.729 ns** |      **0.3242 ns** |      **0.3468 ns** |
| EnumerableRepeat |      10 |        29.554 ns |      0.5865 ns |      0.6276 ns |
|           Vector |      10 |         6.771 ns |      0.1586 ns |      0.1406 ns |
|     VectorUnsafe |      10 |         7.341 ns |      0.1802 ns |      0.2145 ns |
|          **ForLoop** |     **100** |       **135.935 ns** |      **2.6940 ns** |      **2.5200 ns** |
| EnumerableRepeat |     100 |        93.763 ns |      1.8493 ns |      2.1297 ns |
|           Vector |     100 |        26.559 ns |      0.4642 ns |      0.4342 ns |
|     VectorUnsafe |     100 |        28.774 ns |      0.6090 ns |      0.8538 ns |
|          **ForLoop** |    **1000** |     **1,298.630 ns** |     **24.0546 ns** |     **25.7382 ns** |
| EnumerableRepeat |    1000 |       639.518 ns |     12.3740 ns |     12.1530 ns |
|           Vector |    1000 |       229.391 ns |      4.2652 ns |      3.5617 ns |
|     VectorUnsafe |    1000 |       269.353 ns |      5.2650 ns |      8.1970 ns |
|          **ForLoop** |   **10000** |    **13,324.450 ns** |    **255.2321 ns** |    **250.6721 ns** |
| EnumerableRepeat |   10000 |     5,582.608 ns |    109.2099 ns |    112.1506 ns |
|           Vector |   10000 |     2,380.925 ns |     41.5130 ns |     34.6652 ns |
|     VectorUnsafe |   10000 |     2,568.372 ns |     50.9189 ns |     67.9752 ns |
|          **ForLoop** |  **100000** |   **297,958.515 ns** |  **5,704.1826 ns** |  **6,103.4115 ns** |
| EnumerableRepeat |  100000 |   219,518.649 ns |  3,780.7196 ns |  3,536.4874 ns |
|           Vector |  100000 |   197,544.875 ns |  2,438.5006 ns |  2,161.6673 ns |
|     VectorUnsafe |  100000 |   202,613.123 ns |  2,859.6375 ns |  2,674.9067 ns |
|          **ForLoop** | **1000000** | **2,880,449.178 ns** | **55,578.3147 ns** | **61,775.1495 ns** |
| EnumerableRepeat | 1000000 | 2,125,043.359 ns | 40,467.6658 ns | 43,299.9490 ns |
|           Vector | 1000000 | 1,947,696.068 ns | 19,012.7080 ns | 17,784.4989 ns |
|     VectorUnsafe | 1000000 | 1,948,704.844 ns | 29,388.1146 ns | 27,489.6606 ns |


