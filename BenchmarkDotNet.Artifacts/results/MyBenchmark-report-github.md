``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 14.2.1 (23C71) [Darwin 23.2.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT
  DefaultJob : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT


```
|                  Method |     Mean |    Error |   StdDev |
|------------------------ |---------:|---------:|---------:|
|    ErrorCodesInARowTest | 21.25 ns | 0.368 ns | 0.540 ns |
| ErrorCodesNOTInARowTest | 21.60 ns | 0.436 ns | 0.466 ns |
