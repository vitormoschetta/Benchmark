## Benchmark

No universo da computação, benchmark é o ato de comparar de forma eficiente a performance entre dispositivos utilizando um ou mais programas. 


### BenchmarkDotNet
Biblioteca .NET para Micro otimizações.

Adicionar pacote:
```
dotnet add package BenchmarkDotNet --version 0.12.1
```

Executar teste:
```
dotnet run -c Release
```
<br>


### Arquivos gerados
Será gerado um diretório **'BenchmarkDotNet.Artifacts/'** que conterá o arquivo de _log_ da operação e uma pasta denominada 
**results/** que conterá o resultado da análise em três arquivos diferentes: .md, .csv e .html.
<br>
<br>


Referências:

<https://github.com/dotnet/BenchmarkDotNet>  

<https://benchmarkdotnet.org/articles/guides/getting-started.html>