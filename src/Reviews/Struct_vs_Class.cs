using BenchmarkDotNet.Attributes;
using src.Models;

namespace src
{
    [MemoryDiagnoser]
    public class Struct_vs_Class
    {
        [Benchmark]
        public bool TestStruct()
        {
            CarroStruct[] cars = new CarroStruct[10]
            {
                new CarroStruct("red", 2020),
                new CarroStruct("blue", 2015),
                new CarroStruct("orange", 2014),
                new CarroStruct("black", 2015),
                new CarroStruct("orange", 2019),
                new CarroStruct("red", 2010),
                new CarroStruct("blue", 2019),
                new CarroStruct("blue", 2016),
                new CarroStruct("red", 2012),
                new CarroStruct("black", 2017)
            };

            foreach (var item in cars) { }

            return true;
        }


        [Benchmark]
        public bool TestClass()
        {
            CarroClass[] cars = new CarroClass[10]
            {
                new CarroClass("red", 2020),
                new CarroClass("blue", 2015),
                new CarroClass("orange", 2014),
                new CarroClass("black", 2015),
                new CarroClass("orange", 2019),
                new CarroClass("red", 2010),
                new CarroClass("blue", 2019),
                new CarroClass("blue", 2016),
                new CarroClass("red", 2012),
                new CarroClass("black", 2017)
            };

            foreach (var item in cars) { }

            return true;
        }
    }
}