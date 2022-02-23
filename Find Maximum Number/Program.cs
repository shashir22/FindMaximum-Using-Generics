using System;

namespace MaximumNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics program");
            //Console.WriteLine("Find maximum Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 44);
            //Console.WriteLine(output);

            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(12.7, 20.47, 80.56);
            //Console.WriteLine(doubleoutput);

            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("111", "222", "333");
            //Console.WriteLine(strigoutput);

            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);


            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);


            string[] stringArray = { "apple", "peach", "Banana", "Grapes" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);

            Console.ReadKey();

        }
    }
}