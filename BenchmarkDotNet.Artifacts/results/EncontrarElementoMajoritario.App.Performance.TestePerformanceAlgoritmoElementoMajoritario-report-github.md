``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                               Method |       Array |       Mean |    Error |   StdDev |     Median | Rank | Allocated |
|--------------------------------------------------------------------- |------------ |-----------:|---------:|---------:|-----------:|-----:|----------:|
| **MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeQuadratica** | **Int32[1000]** | **1,101.8 μs** | **21.72 μs** | **19.26 μs** | **1,095.2 μs** |    **2** |       **1 B** |
|     MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeLinear | Int32[1000] |   131.2 μs |  2.59 μs |  7.04 μs |   128.6 μs |    1 |         - |
| **MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeQuadratica** |   **Int32[10]** |   **128.3 μs** |  **2.53 μs** |  **5.75 μs** |   **125.6 μs** |    **1** |         **-** |
|     MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeLinear |   Int32[10] |   124.7 μs |  2.05 μs |  1.71 μs |   124.3 μs |    1 |         - |
| **MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeQuadratica** |  **Int32[200]** |   **131.4 μs** |  **2.28 μs** |  **2.53 μs** |   **130.6 μs** |    **1** |         **-** |
|     MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeLinear |  Int32[200] |   124.2 μs |  1.01 μs |  1.12 μs |   124.1 μs |    1 |         - |
| **MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeQuadratica** |   **Int32[50]** |   **123.4 μs** |  **0.83 μs** |  **0.73 μs** |   **123.6 μs** |    **1** |         **-** |
|     MedirPerformanceEncontrarElementoMajoritarioEmComplexidadeLinear |   Int32[50] |   125.4 μs |  1.86 μs |  1.74 μs |   124.9 μs |    1 |         - |
