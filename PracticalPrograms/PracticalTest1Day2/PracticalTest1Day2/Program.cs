// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class AnagramDuplicate
{
    //to check if anagram of a string exists in the other string
    public bool anagram(string? s1,string? s2)
    {
        int i,j;
        if (s1.Length > s2.Length) return false;

        for(i = 0; i < s2.Length; i++)
        {
            if (s1.IndexOf(s2[i]) != -1)
            {
                j = i;
                while (j < s1.Length)
                {
                    if (s1.IndexOf(s2[j]) == -1)
                    {
                        return false;
                    }
                    j++;
                }
                return true;
            }
        }
        return true;
    }


    //to count the number of duplicate pairs in a string
    public int countPairs(string? s)
    {
        int i, count = 0;
        char ch;

        s = sortascii(s);
        //s = new string(s.OrderBy(c => c).ToArray());//for sorting a string
        for (i = 0; i < s.Length-1; i++)
        {
            ch = s[i+1];
            if (s[i] == ch)
            {
                count++;
                i += 1;
            }
        }
        return count;
    }

    public string? sortascii(string? s)
    {
        string str = "";
        char[] ch = new char[s.Length];
        char t;

        for(int i = 0; i < s.Length; i++)
        {
            ch[i] = s[i];
        }
        for (int i = 0; i < s.Length-1; i++)
        {
            for(int j = 0; j < s.Length - 1 - i; j++)
            {
                if (ch[j]>ch[j+1])
                {
                    t = ch[j];
                    ch[j] = ch[j + 1];
                    ch[j + 1] = t;
                }
            }
        }
        for(int i = 0; i < s.Length; i++)
        {
            str += ch[i];
        }

        /*str += 12;

        str += (char)(s[0]-0);
        str += s[0];

        str += (char)s[1] - 0;
        str += (int)s[1];
        Console.WriteLine(str);*/

        return str;
    }

    public static void Main(string[] args)
    {
        AnagramDuplicate obj = new AnagramDuplicate();
        string? s1, s2;
        Console.WriteLine("Enter string 1 whose anagram is to be found:");
        s1 = Console.ReadLine();
        Console.WriteLine("Enter string in which anagram is to be found: ");
        s2 = Console.ReadLine();

        if (obj.anagram(s1, s2))
            Console.WriteLine("Anagram exists");
        else
            Console.WriteLine("Anagram does not exists");

        string? s;
        Console.WriteLine("Enter string in which duplicates count has to be found:");
        s= Console.ReadLine();
        Console.WriteLine("The no of duplicate pairs are: "+obj.countPairs(s));
    }
}
