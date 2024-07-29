// See https://aka.ms/new-console-template for more information
namespace doubleDimensionalTen
{
    class Handler
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the size of the double dimensional matrix ");
            Console.Write("\nEnter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m= Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];
            Console.WriteLine("Enter the elements of the " + n + "*" + m + " matrix");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + arr.GetLength(1) + " elements for row " + (i+1));
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Console.WriteLine(arr.GetLength(0)+"  "+ arr.GetLength(1));
            Programs p = new Programs();
            p.display(arr);
            p.saddlePoint(arr);
            p.transpose(arr);
        }
    }//class Handler ends here

    class Programs
    {
        //1. Displaying Array
        public void display(int[,] arr)
        {
            Console.WriteLine("\n2D-integer array is:");
            for(int i=0;i< arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //2. SaddlePoint:  A saddle point is an element of the matrix such that it is the minimum element in its row and the maximum in its column.
        public void saddlePoint(int[,] arr)
        {
            int n = arr.GetLength(0);//gives no of rows
            int m = arr.GetLength(1);//gives no of columns
            int colNo=0;
            int flag = 0;

            for(int i=0;i<n;i++)
            {
                int min = arr[i, 0];
                int rowNo = i;
                for(int j = 0; j < m; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        colNo = j;
                    }
                }
                //Console.WriteLine("min colno rowno: "+min+"\t"+colNo+"\t"+rowNo);
                bool res= checkColMax(arr, colNo, rowNo);

                if (res == true)
                    flag = 1;
            }
            if (flag == 0)
                Console.WriteLine("No Saddle Point in the matrix");
        }//saddlePoint method ends here

        //method to check if the min elt found in row is the max elt in the col or not for the saddle point
        public bool checkColMax(int[,] arr, int colNo, int rowNo)
        {
            int n = arr.GetLength(0);//gives no of rows          
            for(int i = 0; i < n; i++)
            {
                if (arr[i, colNo] > arr[rowNo, colNo])
                {
                    //Console.WriteLine(arr[i, colNo] + "is greater found at row col "+i+" "+colNo);
                    return false;
                }
            }
            Console.WriteLine(arr[rowNo, colNo] + " is a Saddle Point");
            return true;    
        }
    
  
        //3. Transpose of the matrix
        public void transpose(int[,] arr)
        {
            Console.WriteLine("\nTranspose of the matrix is:");
            for(int i = 0; i < arr.GetLength(1); i++)
            {
                for(int j=0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[j, i]+"\t");
                }
                Console.WriteLine();
            }
        }
        

    }//class Programs ends here
}
