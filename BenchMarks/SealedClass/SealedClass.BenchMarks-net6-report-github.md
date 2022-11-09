``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2006/21H2/November2021Update)
Intel Xeon CPU E5-1620 v4 3.50GHz, 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2


```
|             Method |      Mean |     Error |    StdDev |    Median | Allocated |
|------------------- |----------:|----------:|----------:|----------:|----------:|
|     BaseVoidMethod | 3.4882 ns | 0.0418 ns | 0.0326 ns | 3.4865 ns |      24 B |
|     OpenVoidMethod | 0.8383 ns | 0.0051 ns | 0.0048 ns | 0.8380 ns |         - |
|   SealedVoidMethod | 0.0000 ns | 0.0001 ns | 0.0001 ns | 0.0000 ns |         - |
|   BaseStringMethod | 3.2986 ns | 0.0767 ns | 0.0717 ns | 3.2886 ns |      24 B |
|   OpenStringMethod | 0.5394 ns | 0.0117 ns | 0.0109 ns | 0.5388 ns |         - |
| SealedStringMethod | 0.0037 ns | 0.0053 ns | 0.0049 ns | 0.0013 ns |         - |
|      BaseIntMethod | 3.4700 ns | 0.0171 ns | 0.0151 ns | 3.4700 ns |      24 B |
|      OpenIntMethod | 0.5377 ns | 0.0036 ns | 0.0033 ns | 0.5379 ns |         - |
|    SealedIntMethod | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |         - |
