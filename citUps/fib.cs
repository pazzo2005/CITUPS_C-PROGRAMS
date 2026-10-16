using System;
using System.Collections;
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
        public void ThreeDim(int layer,int row,int col)

        {
            
            int[,,] arr = new int[layer,row,col];
            for(int i = 0; i < layer; ++i)
            {
                for(int j = 0; j < row; ++j)
                {
                    for(int h=0; h < col; ++h)
                    {
                        Console.WriteLine("Enter the number : ");
                        arr[i, j, h] = Convert.ToInt16(Console.ReadLine());

                    }
                }
            }
            for(int i = 0; i < layer; ++i)
            {
                for(int j = 0; j < row; ++j)
                {
                    for(int k = 0; k < col; ++k)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
            }
            int sum = arr.Cast<int>().Sum();
            Console.WriteLine("The sum of all numbers +"+sum);
        }
        public void StringDimen(int layer , int row , int col)
        {
            string[,,] arr = new string[layer, row, col];
            Console.WriteLine("Enter the string , for assigning it to the matrix");
            for(int i = 0; i < layer; ++i)
            {
                for(int j = 0; j < row; ++j)
                {
                    for(int l = 0; l < col; ++l)
                    {
                        Console.WriteLine("Enter it one by one");
                        arr[i, j, l] = Console.ReadLine();
                    }
                }
            }
            foreach(string element in arr)
            {
                Console.WriteLine(element);
            }
            string[] arr1 = new string[row];
            for(int i = 0; i < row; ++i)
            {
                arr1[i] = Console.ReadLine();
                Console.WriteLine(arr1[i]);
            }
        }
        public void StringModification(String s)
        {
            StringBuilder st = new StringBuilder(s);
            
            
        }
        public void OddEven(int n)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int[] arr = new int[n];
            for(int i = 0; i < n; ++i)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
                

            }
            Console.WriteLine("Following numbers are even");
            foreach(int element in even)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Following numbers are odd");
            foreach(int element in odd)
            {
                Console.Write(element + " ");
            }
        }
        public void MatrixEvenOdd(int layer,int row,int col)
        {
            int[,,] arr = new int[layer, row, col];
            int l = 0, r = 0, c = 0;
            while(l<layer && r<row && c < col)
            {
                if (r == row && c == col)
                {
                    break;
                }
                Console.WriteLine("Give me the number : ");
                int s = Convert.ToInt16(Console.ReadLine());
                if (s % 2 == 0)
                {
                    arr[l, r, c] = s;
                    r++;
                    if (r >= row)
                    {
                        Console.WriteLine("Row completed !");
                        r = 0;
                        c++;
                    }
                }
                else
                {
                    arr[l, r , c] = s;
                    c++;
                    if (c >= col)
                    {
                        Console.WriteLine("Col completed!");
                        c = 0;
                        r++;
                    }
                }
                if (r >= row || c >= col)
                {
                    r = 0;
                    c = 0;
                    l++;
                }
            }

            for (int i = 0; i < layer; ++i)
            {
                for (int j = 0; j < row; ++j)
                {
                    for (int k = 0; k < col; ++k)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
            }
        }

        public void CollectionPractise()

        {
            Console.WriteLine("Enter the size");
            int n = Convert.ToInt16(Console.ReadLine());
            /***
            
            
            ArrayList val = new ArrayList();
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter the element ");
                val.Add(Console.ReadLine());
            }
            foreach(object i in val)
            {
                Console.WriteLine(i);
            }
            
           
           
            
            Hashtable table = new Hashtable();
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter the number ");
                int no = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the string");
                string value = Console.ReadLine();
                table.Add(no, value);
            }
            foreach(object i in table)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter the value to be remove");
            var input = Console.ReadLine();
            if (val.Contains(input))
            {
                val.Remove(input);
            }
            Console.WriteLine("Enter the value to remove from the table ");
            var sup = Console.ReadLine();
            if (table.ContainsKey(sup))
            {
                table.Remove(sup);
            }
            for(int i = 0; i < n; ++i)
            {
                Console.Write(val[i] + " " + table[i]);
            }
            
            
            

            SortedList list = new SortedList();
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter the number ");
                int no = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the string");
                string value = Console.ReadLine();
                list.Add(no, value);
            }

            foreach (object i in list)
            {
                Console.WriteLine(i);
            }
            

        
            
            Stack st = new Stack();
            
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter the value");
                var s = Console.ReadLine();
                st.Push(s);
            }
            
            Queue cit = new Queue();
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter the value");
                var s = Console.ReadLine();
                cit.Enqueue(s);
            }
            foreach(object i in st)
            {
                Console.WriteLine(i);
            }
            foreach(object i in cit)
            {
                Console.WriteLine(i);
            }

            List<string> list1 = new List<string>();
            list1.Add("hello sunEATER");
            list1.Add("I am AshBorn");
            foreach(string i in list1)
            {
                Console.Write(i + " ");
            }
            string[] str = { "Na", "Nenaithal", "nadudhe", "thirum" };
            list1.AddRange(str);
            foreach(string i in str)
            {
                Console.WriteLine(i);
            }
            list1.RemoveAt(1);
            Console.WriteLine("modified list , will  shown here!");
            foreach(string i in list1)
            {
                Console.WriteLine(i);
            }
            
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; ++i)
            {
                
                Console.WriteLine("Enter the string");
                string value = Console.ReadLine();
                set.Add(value);
            }

            foreach (string i in set)
            {
                Console.WriteLine(i);
            }
           
            Dictionary<int, string> dict = new Dictionary<int ,string>();
            dict.Add(1, "hi");
            dict.Add(2, "solla");
            foreach(object i in dict)
            {
                Console.Write(i);
            }
             ***/
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            LinkedListNode<int> node = list.Find(1);
            list.AddAfter(node,2);
            list.AddLast(3);
            LinkedListNode<int> head = list.First;
            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
            list.RemoveFirst();

            head = list.First;

            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
        }
        public static void Main(String[] args)

        {
            fib f = new fib();
            f.CollectionPractise();
            


            

        }
    }
}
      