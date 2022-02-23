using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberGenerics
{
    public class GenericMaximum1<T> where T : IComparable

    {
        private T[] value;
        public GenericMaximum1(T[] value)
        {
            this.value = value;
        }

        public void FindMaximum()
        {
            var max = maxValue(this.value);
            Console.WriteLine("Maximum is : " + max);
        }
        public T maxValue(params T[] values)
        {
            var sortMax = Sort(values);
            return sortMax[sortMax.Length - 1];
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;

        }
    }
}