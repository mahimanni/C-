// See https://aka.ms/new-console-template for more information
using C = System.Console;
class StringPrograms
{
    public void findCharFindNearVowel(string? s, char ch)
    {
        int nearest1 = -1, nearest2=-1, flag=0, pos=-1;

        for(int i = 0; i < s.Length; i++)
        {
            if ((flag == 0) && s[i] == ch)
            {
                C.WriteLine($"First occurrence of character '{ch}' found in string '{s}' at position {i+1}");
                pos = i;
                flag = 1;
            }
            if ((flag == 0) && (s[i] == 'a' || s[i]=='e' || s[i]=='o' || s[i] == 'u' || s[i] == 'i'))
            {
                nearest1 = i;//nearest vowel before the first occurrence of character
            }
            if ((flag == 1) && (s[i] == 'a' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i'))
            {
                nearest2 = i;//nearest vowel after the first occurrence of character
                break;
            }
        }
        if (flag == 0)
        {
            C.WriteLine($"Character '{ch}' not found in the string '{s}'");
        }
        else
        {
            //C.WriteLine(nearest1+" " + nearest2+" "+pos);
            int loc=0,check=0;
            if (nearest1 != -1 && nearest2 != -1){
                loc = (Math.Abs(pos - nearest2) > Math.Abs(pos - nearest1)) ? nearest1 : nearest2;
            }
            else if (nearest1 != -1){
                loc = nearest1;
            }
            else if (nearest2 != -1){
                loc = nearest2;
            }
            else{
                C.WriteLine("No vowel exists in the string");
                check = 1;
            }

            if(check!=1)    
                C.WriteLine($"Nearest vowel of given character '{ch}' is '{s[loc]}' found at position {loc+1}");
        }

        //for finding nearest vowel according to the alphabets
        if (ch >= 97 && ch <= 122)
        {
            C.WriteLine($"Nearest vowel of '{ch}' is {nearestVowel(ch)}");
        }
        else if (ch >= 65 && ch <= 90)
        {
            ch = (char)(ch + 32);//converting uppercase character to lowercase
            C.WriteLine($"Nearest vowel of '{(char)(ch-32)}' is {(char)(nearestVowel(ch)-32)}");//converting lowecase vowel to uppercase
        }
        else
        {
            C.WriteLine("The given character is not a alphabet");
        }
    }
    public char nearestVowel(char ch)//find the nearest vowel of a given character in the alhpabets
    {
        C.WriteLine("Nearest vowel in the alphabets");
        //int a = 'a', e='e', i='i', o='o', u='u';
        //C.WriteLine(a);//97
        int[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int min = 26;
        char nearest = ' ';

        for(int i=0; i < vowels.GetLength(0); i++)
        {
            if( Math.Abs(vowels[i]-ch) < min)
            {
                min= Math.Abs(vowels[i]-ch);
                nearest = (char)vowels[i];
            }
        }
        return nearest;
    }

    //print frequency of each letter in the string
    public void freqEachLetter(string? s)
    {
        int count;
        string occurred = "";
        C.WriteLine("\nCalculating frequency of each character in the given string " + s);
        for(int i = 0; i < s.Length; i++)
        {
            count = 0;
            if (occurred.IndexOf(s[i])==-1)//if we have not calculated the count of that character yet
            {
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j]) count++;
                }
                C.WriteLine($"Frequency of character {s[i]} is {count}");
                occurred += s[i];
            }
        }
    }

    //extract words from string and find out which word contains the maximum no of vowels
    public void extractWordMaxVowel(string? s)
    {
        string str="",strMaxVowel="";
        char ch;
        int maxVowelCount = 0,vowelCountWord;
        List<string> words = new List<string>();
        C.WriteLine($"\nThe extracted words of the string '{s}'are:");

        for(int i = 0; i < s.Length; i++)
        {
            ch = s[i];
            if(ch==' ')
            {
                words.Add(str);

                vowelCountWord = vowelCount(str);
                if (vowelCountWord > maxVowelCount)
                {
                    strMaxVowel = str;
                    maxVowelCount = vowelCountWord;
                }
                str = "";
            }
            else
            {
                str += ch;
            }
        }
        words.Add(str);//for adding the last word formed 

        foreach(string word in words)
        {
            C.WriteLine(word);
        }
        if (strMaxVowel != "")
        {
            C.WriteLine("Word containing max vowel is: " + strMaxVowel + " having vowel count: " + maxVowelCount);
        }
        else
        {
            C.WriteLine("No word contains a single vowel");
        }
    }
    public int vowelCount(string s)
    {
        int count = 0;
        foreach(char ch in s)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                count++;
        }
        return count;
    }

    public static void Main(string[] args)
    {
        StringPrograms obj = new StringPrograms();

        string? s;
        char ch;
        Console.WriteLine("Enter string");
        s= Console.ReadLine();
        C.WriteLine("Enter character to find in string:");
        ch = Console.ReadLine()[0];

        obj.findCharFindNearVowel(s, ch);
        obj.freqEachLetter(s);
        obj.extractWordMaxVowel(s);
    }
}