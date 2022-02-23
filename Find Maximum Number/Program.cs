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
            GenericMaximum1<int> generic = new GenericMaximum1<int>(intArray);
            generic.FindMaximum();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum1<double> genericDouble = new GenericMaximum1<double>(doubleArray);
            genericDouble.FindMaximum();


            string[] stringArray = { "111", "222", "444", "888" };
            GenericMaximum1<string> genericString = new GenericMaximum1<string>(stringArray);
            genericString.FindMaximum();
            Console.ReadKey();

        }
    }
}
