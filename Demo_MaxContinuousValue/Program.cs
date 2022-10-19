using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int maxSum = 0;
            int[] array = { 0, 3, 3, 0, 0, 3, 3, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {
                    sum += 3;
                    if (sum >= maxSum)
                    {
                        maxSum = sum;
                    }
                }
                else
                {
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
            {
                int sum1 = 0;
                int maxSum1 = 0;
                int[] array1 = { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3 };
                for (int k = 0; k < array1.Length; k++)
                {
                    if (array1[k] == 3)
                    {
                        sum1 += 3;
                        if (sum1 >= maxSum1)
                        {
                            maxSum1 = sum1;
                        }
                    }
                    else
                    {
                        sum1 = 0;
                    }
                }
                Console.WriteLine(maxSum1);
            }
            {
                int sum2 = 0;
                int maxSum2 = 0;
                int[] array2 = { 0, 3, 0, 0 };
                for (int m = 0; m < array2.Length; m++)
                {
                    if (array2[m] == 3)
                    {
                        sum2 += 3;
                        if (sum2 >= maxSum2)
                        {
                            maxSum2 = sum2;
                        }
                    }
                    else
                    {
                        sum2 = 0;
                    }
                }
                Console.WriteLine(maxSum2);
            }
        }
    }
}
