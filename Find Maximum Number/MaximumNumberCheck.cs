using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberGenerics
{
    public class MaximumNumberCheck
    {
        public static void MaximumNumber(int firstValue, int SecondValue, int ThirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) > 0)
                Console.WriteLine(firstValue);
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
                Console.WriteLine(SecondValue);
            if (ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                Console.WriteLine(ThirdValue);
            else
                throw new Exception("All numbers are same");
        }
        public static double MaximumFloatNumber(double firstValue, double SecondValue, double ThirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) > 0)
                return firstValue;
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
                return SecondValue;
            if (ThirdValue.CompareTo(firstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                return ThirdValue;
            else
                throw new Exception("All numbers are same");
        }
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}