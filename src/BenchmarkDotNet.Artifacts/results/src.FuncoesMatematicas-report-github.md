``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
Intel Core i5-3330 CPU 3.00GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|                  Method | Number |       Mean |     Error |    StdDev |     Median |
|------------------------ |------- |-----------:|----------:|----------:|-----------:|
|        NumeroAoQuadrado |   1000 |  0.0738 ns | 0.0453 ns | 0.0445 ns |  0.0530 ns |
| NumeroAoQuadradoMathPow |   1000 | 47.9485 ns | 0.8845 ns | 0.8273 ns | 47.7438 ns |
