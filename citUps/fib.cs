using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace citUps
{
    internal class fib


    {

        public void InputArr(int n)
        {
            int[] arr = new int[n];
            int max = 0;
            int min = int.MaxValue;
            for(int i = 0; i < n; ++i)
            {
               
                Console.Write("Enter the number ");
                Console.Write(i + 1);
                arr[i] = Convert.ToInt16(Console.ReadLine());
                max = Math.Max(arr[i], max);
                min = Math.Min(arr[i], min);
            }
            Console.WriteLine("Max :" + max + "Min :" + min);
            int sum = 0;
            Array.ForEach(arr, a => sum += a);
            Console.WriteLine(sum);

        }
        public void TwoDimArr(int row,int col)
        {
            int[,] arr = new int[row, col];
            for(int k = 0; k < row; ++k)
            {
                for(int j = 0; j < col; ++j)
                {
                    Console.WriteLine("Enter the number ");
                    arr[k,j] = Convert.ToInt16(Console.ReadLine());

                }

            }
            int sum = 0;
            for(int i = 0; i < row; ++i)
            {
                for(int j = 0; j < col; ++j)
                {
                    Console.WriteLine(arr[i, j]+" ");
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);

        }
        public bool Palindrome(string str)
        {
            int left = 0, right = str.Length - 1;
            while (left <= right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;

        }
        public  void Fact(int n)

        {
            int total = 1;
            for (int i = 1; i <= n; ++i)
            {
                total *= i;
            }
            Console.WriteLine(total);
                
        }
        public static void Main(String[] args)

        {
            fib f = new fib();
            f.TwoDimArr(2,2);
            

        }
    }
}
      