using System;
namespace CasCap
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TestClass1();
            obj.ThrowDivideByZeroException();

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}