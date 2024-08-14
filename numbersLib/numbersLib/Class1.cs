namespace numbersLib
{
    public class ClassNumber
    {
        //1. Armstrong number
        public void armstrong(int n)
        {
            int a, m = n, p = n, count = 0;
            double s = 0;
            while (p > 0)
            {
                count++;
                p = p / 10;
            }
            while (n > 0)
            {
                a = n % 10;
                s = s + Math.Pow(a, count);
                n = n / 10;
                count--;
            }
            if (m == s)
            {
                Console.WriteLine("Armstrong no");
            }
            else
            {
                Console.WriteLine("Not a Armstsrong no");
            }
        }

        //2. printing right angled triangle
        public void righttri()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        //3. Even odd
        public String evenOdd(int n)
        {
            string res=(n % 2 == 0) ? "even" : "odd";
            return $"{n} is a {res} number";
        }

        //4. Palindrome
        public String palindrome(int n)
        {
            int m = n, a,newNo=0;
            while (n > 0)
            {
                a = n % 10;
                newNo = (newNo * 10) + a;
                n = n / 10;
            }
            string res= (newNo == m) ? "Palindrome number" : "not a Palindrome Number";
            return $"{m} is {res}";
        }

        //5. Reverse of a number
        public int reverse(int n)
        {
            int a, rev = 0;
            while (n > 0)
            {
                a = n % 10;
                rev = rev * 10 + a;
                n = n / 10;
            }
            return rev;
        }

        //6. Factorial
        public int fact(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        //7. Fibonaccii Series upto n
        public void fibo(int n)
        {
            int a = 0, b = 1, c ,i=0;
            Console.Write(a + " " + b + " ");
            while (i < n - 2)
            {
                c= a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
                i++;
            }
        }

        //8. Prime Number
        public String prime(int n)
        {
            for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return $"{n} is not a prime number";
            }
            return $"{n} is a prime number";
        }

        //9. Buzz number: a number is said to be Buzz if it ends with 7 or is divisible by 7
        public String buzz(int n)
        {
            if(n%10==7 || n%7==0)
                return $"{n} is a buzz number";
            else
               return $"{n} is not a buzz number";
        }

        //10. Neon number: A positive integer whose sum of digits of its square is equal to the number itself is called a neon number
        public String neon(int n)
        {
            int sq = n * n,sum=0;
            while (sq > 0)
            {
                sum += sq % 10;
                sq = sq / 10;
            }
            if(sum==n)
                return $"{n} is a neon number";
            else
                return $"{n} is not a neon number";
        }
    }
}
