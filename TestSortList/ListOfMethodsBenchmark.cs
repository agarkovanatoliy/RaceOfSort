using BenchmarkDotNet.Attributes;
using ListOfMethods;

namespace TestMethods
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MethodsBenchmark
    {
        string[] array = Methods.CreateArray(1000);

        [Benchmark]
        public void TestLengthElement()
        {
            string[] array1 = Methods.CopiArray(array);
            string[] resalt1 = Methods.LengthElement(array1);
        }

        [Benchmark]
        public void TestLengthElement1()
        {
            string[] array3 = Methods.CopiArray(array);
            string[] resalt1 = Methods.LengthElement1(array3);
        }

        [Benchmark]
        public void TestSortQuick()
        {
            string[] array2 = Methods.CopiArray(array);
            int size = array2.Length;
            Methods.SortQuick(array2,0,size - 1);
        }

        [Benchmark]
        public void TestLengthElementSort()
        {
            string[] array2 = Methods.CopiArray(array);
            string[] resalt2 = Methods.LengthElementSort(array2);
        }
    }
}
