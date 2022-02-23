using System;

namespace MaximumNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics program");
            Console.WriteLine("Find maximum Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 44);
            Console.WriteLine(output);
        }
    }
}