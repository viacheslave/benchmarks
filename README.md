# benchmarks

## ArrayFiller
Different methods of filling an array with the same value.
Using Integer type and [BenchmarkDotNet](https://benchmarkdotnet.org/articles/guides/getting-started.html)

Inspired by K.Kokosa tweet https://twitter.com/konradkokosa/status/1417760179072946176?s=09

```
// * Summary *

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.14393.3443 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon Gold 6136 CPU 3.00GHz, 2 CPU, 48 logical and 24 physical cores
Frequency=2922816 Hz, Resolution=342.1358 ns, Timer=TSC
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```

|           Method |       N |             Mean |          Error |          StdDev |           Median |
|----------------- |-------- |-----------------:|---------------:|----------------:|-----------------:|
|          ForLoop |       4 |         7.284 ns |      0.1928 ns |       0.5310 ns |         7.114 ns |
|         SpanFill |       4 |        10.083 ns |      0.2347 ns |       0.5153 ns |        10.020 ns |
|        ArrayFill |       4 |         8.747 ns |      0.1989 ns |       0.4952 ns |         8.620 ns |
| EnumerableRepeat |       4 |        29.256 ns |      0.6165 ns |       1.5467 ns |        28.736 ns |
|           Vector |       4 |         7.459 ns |      0.1775 ns |       0.4706 ns |         7.332 ns |
|     VectorUnsafe |       4 |         8.945 ns |      0.2043 ns |       0.4309 ns |         8.884 ns |
|          ForLoop |      10 |        14.429 ns |      0.3186 ns |       0.7509 ns |        14.393 ns |
|         SpanFill |      10 |        10.777 ns |      0.2456 ns |       0.2828 ns |        10.869 ns |
|        ArrayFill |      10 |        10.433 ns |      0.2280 ns |       0.1904 ns |        10.389 ns |
| EnumerableRepeat |      10 |        33.976 ns |      0.7032 ns |       1.8401 ns |        33.605 ns |
|           Vector |      10 |         8.118 ns |      0.1921 ns |       0.3102 ns |         8.000 ns |
|     VectorUnsafe |      10 |         7.789 ns |      0.1783 ns |       0.1982 ns |         7.710 ns |
|          ForLoop |     100 |       108.496 ns |      2.1946 ns |       2.8536 ns |       107.754 ns |
|         SpanFill |     100 |        72.053 ns |      1.4693 ns |       2.4549 ns |        72.183 ns |
|        ArrayFill |     100 |        95.167 ns |      1.9111 ns |       4.0727 ns |        94.535 ns |
| EnumerableRepeat |     100 |       122.987 ns |      2.7766 ns |       8.1433 ns |       121.733 ns |
|           Vector |     100 |        36.494 ns |      0.7481 ns |       1.2080 ns |        36.547 ns |
|     VectorUnsafe |     100 |        34.914 ns |      0.7293 ns |       1.6312 ns |        34.517 ns |
|          ForLoop |    1000 |     1,005.640 ns |     20.1234 ns |      55.4258 ns |     1,001.698 ns |
|         SpanFill |    1000 |       595.364 ns |     11.9092 ns |      30.3128 ns |       587.630 ns |
|        ArrayFill |    1000 |       832.154 ns |     14.7162 ns |      26.9094 ns |       821.171 ns |
| EnumerableRepeat |    1000 |       871.682 ns |     17.4339 ns |      32.7451 ns |       865.868 ns |
|           Vector |    1000 |       339.206 ns |      6.5463 ns |      12.9217 ns |       338.248 ns |
|     VectorUnsafe |    1000 |       411.596 ns |      8.1581 ns |      18.5801 ns |       410.408 ns |
|          ForLoop |   10000 |     7,765.828 ns |    146.9752 ns |     130.2897 ns |     7,761.431 ns |
|         SpanFill |   10000 |     5,115.015 ns |     30.5612 ns |      27.0917 ns |     5,114.086 ns |
|        ArrayFill |   10000 |     7,733.817 ns |    150.1370 ns |     166.8769 ns |     7,721.386 ns |
| EnumerableRepeat |   10000 |     6,621.446 ns |    125.1296 ns |     110.9241 ns |     6,593.316 ns |
|           Vector |   10000 |     4,963.895 ns |     96.6805 ns |      94.9531 ns |     4,927.697 ns |
|     VectorUnsafe |   10000 |     4,448.028 ns |     85.2660 ns |      87.5619 ns |     4,475.555 ns |
|          ForLoop |  100000 |   251,181.508 ns |  2,271.9054 ns |   2,013.9849 ns |   250,332.648 ns |
|         SpanFill |  100000 |   234,109.369 ns |  1,076.8504 ns |   1,007.2865 ns |   233,961.584 ns |
|        ArrayFill |  100000 |   249,116.892 ns |  1,353.7727 ns |   1,200.0843 ns |   248,853.095 ns |
| EnumerableRepeat |  100000 |   242,105.290 ns |  2,108.2951 ns |   1,972.1005 ns |   241,777.499 ns |
|           Vector |  100000 |   235,122.216 ns |  3,520.2854 ns |   2,939.5978 ns |   235,128.404 ns |
|     VectorUnsafe |  100000 |   229,300.986 ns |  3,488.6718 ns |   3,092.6167 ns |   228,268.648 ns |
|          ForLoop | 1000000 | 2,684,192.521 ns | 52,793.4705 ns | 102,969.6097 ns | 2,711,756.349 ns |
|         SpanFill | 1000000 | 2,367,821.150 ns | 45,919.5188 ns |  54,663.9206 ns | 2,358,319.372 ns |
|        ArrayFill | 1000000 | 2,398,216.773 ns | 42,148.2131 ns |  39,425.4647 ns | 2,387,930.157 ns |
| EnumerableRepeat | 1000000 | 2,347,596.973 ns | 46,154.1438 ns |  71,856.4414 ns | 2,318,538.734 ns |
|           Vector | 1000000 | 2,256,204.245 ns | 34,031.9414 ns |  30,168.4296 ns | 2,252,355.503 ns |
|     VectorUnsafe | 1000000 | 2,320,131.069 ns | 43,977.5746 ns |  50,644.6403 ns | 2,312,886.143 ns |
