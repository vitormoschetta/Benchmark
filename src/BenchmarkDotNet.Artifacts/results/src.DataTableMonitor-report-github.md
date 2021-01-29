``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
Intel Core i5-3330 CPU 3.00GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|     Method |      Mean |    Error |   StdDev |    Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|---------:|---------:|----------:|-------:|------:|------:|----------:|
| TestStruct |  52.58 ns | 1.009 ns | 1.658 ns |  51.67 ns | 0.0587 |     - |     - |     184 B |
|  TestClass | 111.88 ns | 0.499 ns | 0.467 ns | 111.86 ns | 0.1351 |     - |     - |     424 B |
