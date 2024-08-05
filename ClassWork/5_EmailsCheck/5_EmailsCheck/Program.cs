// See https://aka.ms/new-console-template for more information
namespace stringEmails
{
    class EmailsDotComCheck
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of emails you want to enter: ");
            int n=Convert.ToInt32(Console.ReadLine());
            string[] emails = new string[n];
            input(n, emails);
            check(emails);
        }
        public static void input(int n, string[] emails)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter email " + (i+1)+" :");
                emails[i] = Console.ReadLine();
            }
        }
        public static void check(string[] emails)
        {
            int flag = 0;
            for(int i = 0; i < emails.Length; i++)
            {
                if (emails[i].IndexOf(".com") != -1 && emails[i].LastIndexOf(".com") == emails[i].IndexOf(".com") && (emails[i].IndexOf(".com") + 4) == emails[i].Length)
                {
                    Console.WriteLine("\n"+emails[i] +" has .com in the end");
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\nNo email in the list has .com in the end");
            }
        }
    }
}