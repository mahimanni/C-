// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

class AlmostPalindrome
{
    string? rev;
    int flag = 0,i;
    public AlmostPalindrome()
    {
        Console.WriteLine("Welcome to the program");
        rev = "";
    }
    public string? reverse(String s)
    {
        rev = "";
        for (i = s.Length - 1; i >= 0; i--)
        {
            rev += s[i];
        }
        return rev;
    }
    public bool almostPalin(String s)
    {
        int count = 0;
        //Method-2
        /*int j=s.Length-1;
        for (i = 0; i <= s.Length / 2; i++)
        {
            if (s[i] != s[j]) count++;
            j--;
        }
        if (count == 1) return true;
        return false;*/

        rev = reverse(s);
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] != rev[i])
                count++;
        }

        if (count == 2)
        {
            return true;
        }
        return false;
    }

    public string? replaceLetter(String s)
    {
        string? r = "";
        //Method-2
        /*s = s.ToLower();
        foreach (char item in s)
        {
            r += item - 'a' + 1;
        }
        return r;*/

        int ind;
        String bigalpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String smallalpha = "abcdefghijklmnopqrstuvwxyz";

        for (i = 0; i < s.Length; i++)
        {
            ind = bigalpha.IndexOf(s[i]);
            if (ind == -1)
            {
                ind = smallalpha.IndexOf(s[i]);
                if (ind != -1)
                {
                    r += (ind + 1).ToString();
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            else
            {
                r += (ind + 1).ToString();
            }
        }
        if (flag == 1) return "String is not only of alphabetic characters";
        return r;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        AlmostPalindrome obj = new AlmostPalindrome();

        Console.WriteLine("Enter a string");
        string? s = Console.ReadLine();
        if (obj.almostPalin(s) == true)
        {
            Console.WriteLine($"{s} is an almost Palindrome");
        }
        else
        {
            Console.WriteLine("Cannot be transformed to a palindrome in exactly one term");
        }

        Console.WriteLine("Enter a string");
        string? s1 = Console.ReadLine();
        Console.WriteLine($"After replacing the characters with their position: {obj.replaceLetter(s1)}");
    }
}