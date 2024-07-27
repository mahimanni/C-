// See https://aka.ms/new-console-template for more information
namespace npgc
{
    class controller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("You are the controller here");

            //Patterns
            patterns patterns = new patterns();
            Console.WriteLine("Patterns");
            patterns.righttri();

            //Numbers
            Console.Write("\nEnter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is:" + n);
            numbers num = new numbers();
            num.armstrong(n);

            //branching
            branching b = new branching();

            //ifelse
            Console.Write("\nEnter a character:");
            char ch = Console.ReadLine()[0];
            //char ch= Console.ReadKey().KeyChar;
            b.ifelse(ch);

            //switch
            Console.WriteLine("\nMENU\nEnter 1 for C#\nEnter 2 for Java");
            int chswitch = Convert.ToInt32(Console.ReadLine());
            b.switchUse(chswitch);
        }
    }
    class patterns
    {
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
    }
    class numbers
    {
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
    }

    class branching
    {
        public void ifelse(char choice)
        {
            if (choice == 'M' || choice == 'R')
            {
                Console.WriteLine("You are beautiful");
            }
            else
            {
                Console.WriteLine("You are ordinary");
            }
        }
        public void switchUse(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("C# selected");
                    break;
                case 2:
                    Console.WriteLine("Java selected");
                    break;
                default:
                    Console.WriteLine("Sorry, option not available");
                    break;
            }
        }
    }
}
