using BenchmarkDotNet.Running;
using ListOfMethods;

namespace TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] array = Methods.CreateArray(20);
             Methods.PrintArray(array);
             Console.WriteLine();
             string[] array1 = Methods.CopiArray(array);
             Methods.PrintArray(array1);
             Console.WriteLine();
             string[] resalt1 = Methods.LengthElement(array1);
             Methods.PrintArray(resalt1);
             Console.WriteLine();
             string[] array2 = Methods.CopiArray(array);
             Methods.PrintArray(array2);
             Console.WriteLine();
             string[] resalt2 = Methods.LengthElementSort(array2);
             Methods.PrintArray(resalt2);
            */
            BenchmarkRunner.Run<MethodsBenchmark>();
        }
    }
}