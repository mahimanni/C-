// See https://aka.ms/new-console-template for more information
namespace GoldBachNumber
{
    class GoldBach
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n%2==0 && n > 4)
            {
                Console.WriteLine(n+" is a GoldBach Number");
                Console.WriteLine("Pairs of 2 odd prime numbers from whose sum "+n+" can be formed are:");
                findPairs(n);
            }
            else
            {
                Console.WriteLine(n+" is not a GoldBach Number");
            }
        }

        //to find and display all the pairs from whose sum the entered goldbach no can be formed
        public static void findPairs(int n)
        {
            int[] prime= findPrime(n);

            int start = 0, end = prime.Length - 1, sum;
            while (start <= end)
            {
                sum = prime[start] + prime[end];
                if (sum == n)
                {
                    Console.WriteLine($"({prime[start]},{prime[end]})");
                    start++;
                    end--;
                }
                else if (sum > n)
                {
                    end--;
                }
                else if (sum < n)
                {
                    start++;
                }
            }
        }

        //to find all the odd prime no(primes except 2) less than the number
        public static int[] findPrime(int n)
        {
            int[] a=new int[100];
            int index = 0;
            for(int i = 3; i < n; i++)//as finding from odd prime no
            {
                int flag = 0;
                for(int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    a[index] = i;
                    index++;
                }
            }

            int[] b = new int[index];
            for(int i = 0; i < index; i++)
            {
                //Console.WriteLine("Prime no: " + a[i]);
                b[i] = a[i];
            }
            return b;
        }

    }//class ends here
}//namespace ends here
