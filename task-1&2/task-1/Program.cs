﻿using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int max = Max(10, 22, 123, 23, 1, 34, 78212, 12);
            Console.WriteLine("max eded: " +max);


            Console.WriteLine("2lik say sistemine cevrilme");
            Console.WriteLine(DecToBin(8));
        }

        static int Max(params int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];

                }
            }
            return max;
        }

        static string DecToBin(int n)
        {
            string bin = "";
            int temp = 0;

            if (n==0)
            {
                return "0";
            }
            else
            {
                while (n != 0)
                {
                    temp = n % 2;
                    bin = temp.ToString() + bin;
                    n /= 2;
                }

            }
          
            return bin;
        }
    }
}
