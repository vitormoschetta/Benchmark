``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
Intel Core i5-3330 CPU 3.00GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|     Method |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
| TestStruct |  52.36 ns | 1.080 ns | 1.244 ns | 0.0587 |     - |     - |     184 B |
|  TestClass | 117.04 ns | 2.363 ns | 4.138 ns | 0.1351 |     - |     - |     424 B |
