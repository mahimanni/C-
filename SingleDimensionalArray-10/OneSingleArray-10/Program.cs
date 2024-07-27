// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

namespace singleDimensionalTen
{
    class Handler
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nInput the 1D-integer array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the array elements");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Programs p = new Programs();
            p.display(arr);
            //p.stringArrayInput();
            p.unique(arr);
            p.duplicatesOnce(arr);
            p.patternRightTriangle(arr);
        }
    }
    class Programs
    {
        //1. Displaying array
        public void display(int[] a)
        {
            Console.WriteLine("1D-integer array is:");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //2. Taking 1d-string array and displaying it
        public void stringArrayInput()
        {
            Console.WriteLine("\nEnter the size of string array");
            int size= Convert.ToInt32(Console.ReadLine());
            string[] sarr = new string[size];
            Console.WriteLine("Enter the string elements:");
            for(int i=0; i< sarr.Length; i++)
            {
                sarr[i] = Console.ReadLine();
            }
            Console.WriteLine("1D-string array is:");
            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine(sarr[i]);
            }
        }

        //3. Finding only the unique values of the integer array
        public void unique(int[] a)
        {
            Console.WriteLine("\nUnique elements are:");
            for(int i=0;i< a.Length; i++)
            {
                int flag = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] && i != j)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                    Console.Write(a[i] + " ");
            }
        }

        //4. Printing duplicates only once along with the unique elements
        public void duplicatesOnce(int[] a)
        {
            Console.WriteLine("\nConsidering Duplicate elements only once:");
            for (int i=0; i < a.Length; i++)
            {
                int flag = 0;
                for(int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                    Console.Write(a[i] + " ");
            }
        }

        //5.  Printing right angle triangle pattern from array elements & when array becomes empty it simply places 0 to form right angled triangle
        public void patternRightTriangle(int[] a)
        {
            //int n = a.Length/5;
            int count = a.Length;
            int i = 1,j=0,k=0;
            Console.WriteLine("\nRight angled triangle is:");
            while(count>0)
            {
                while(k<i)
                {
                    if (count == 0)
                    {
                        Console.Write("0 ");
                        k++;
                    }
                    else
                    {
                        Console.Write(a[j] + " ");
                        j++;
                        count -= 1;
                        k++;
                    }
                }
                Console.WriteLine();
                i += 1;
                k = 0;
            }
        }
    }
}