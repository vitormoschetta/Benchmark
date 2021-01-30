using System;
using BenchmarkDotNet.Attributes;

namespace src
{
    public class FuncoesMatematicas
    {
        [Params(1000)]
        public double Number { get; set; }

        [Benchmark]
        public double NumeroAoQuadrado()
        {
            return this.Number * this.Number;
        }

        [Benchmark]
        public double NumeroAoQuadradoMathPow()
        {
            return Math.Pow(this.Number, 2);
        }
    }
}