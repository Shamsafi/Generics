﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{

    public class PrintMaxValue<T> where T : IComparable<T>
    {
        private T[] values;

        public PrintMaxValue(params T[] values)
        {
            this.values = values;
        }

        public T Maximum()
        {
            T max = FindMaximum();
            PrintMax(max);
            return max;
        }

        private T FindMaximum()
        {
            if (values.Length == 0)
            {
                return default;
            }
            else if (values.Length == 1)
            {
                return values[0];
            }
            else
            {
                T max = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i].CompareTo(max) > 0)
                    {
                        max = values[i];
                    }
                }
                return max;
            }
        }

        public void PrintMax(T max)
        {
            Console.WriteLine("Maximum value is: " + max);
        }

    }
    public class P
    {
        public static void Main()
        {
            int[] m = { 10, 20, 30, 40 };
            PrintMaxValue<int> Gen = new PrintMaxValue<int>(m);
            Console.WriteLine(Gen.Maximum());

        }
    }



}

