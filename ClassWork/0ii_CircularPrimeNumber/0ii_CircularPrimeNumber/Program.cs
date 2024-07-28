// See https://aka.ms/new-console-template for more information
namespace CircularPrimeNumber
{
    class CircularPrime
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (!checkPrime(n))
            {
                Console.WriteLine(n + " is not a Circular Prime Number as it is not even a prime number");
            }
            else
            {
                Console.WriteLine("Cyclically permuting the digits....");

                string number = n.ToString();
                int len = number.Length;
                int flag = 0;

                for(int i = 0; i < len-1; i++)
                {
                    string newNumber = number.Substring(i + 1) + number.Substring(0,i+1);
                    Console.WriteLine(newNumber);

                    if (!checkPrime(Convert.ToInt32(newNumber))){
                        Console.WriteLine(newNumber + " is not a Prime Number so " + n + " is not a Circular Prime Number");
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("Numbers generated at each intermediate steps are prime");
                    Console.WriteLine("\n"+n + " is a Circular Prime Number");
                }
            }
        }

        //for checking if a number is prime
        public static bool checkPrime(int n)
        {
            for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
