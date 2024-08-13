// See https://aka.ms/new-console-template for more information
namespace stringPrograms{
    class Programs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("String programs:");
            //display(inputString());//displaying the string that the user entered
            //Console.WriteLine("Length of the string is: "+findLength(inputString()));
            //separateChar(inputString());
            //totalWords(inputString());//also finding largest and smallest word in the string

            //changeCase(inputString());
            //replaceVowels(inputString());
            //addTwoCapital(inputString());
            //capitalAlphabeticOrder(inputString());

            //compareStrings(inputString(), inputString());
            //countAlphaDigitSpecChar(inputString());
            //copyString(inputString());

            //freqEachChar(inputString());
            //findMaxChar(inputString());
            //sortStringArray();
            //bubbleSortString(inputString());

            //extractSubstring(inputString());
            //checkString(inputString());
            //findNoOfTimesWord(inputString());
            //combineTwoStrings(inputString(), inputString());

            printOnlyBeforeNewLine(inputString());
        }

        //1. to input a string 
        public static string inputString()
        {
            Console.WriteLine("\nEnter a string");
            string str = Console.ReadLine();
            return str;
        }
        public static void display(string str)
        {
            Console.WriteLine("The string you entered is: "+str);
        }

        //2. length of a string without using library function Length
        public static int findLength(string str)
        {
            str += " ";
            int last = str.LastIndexOf(" ");
            int len = 0;
            while (len<last)
            {
                Console.WriteLine(str[len]);
                len++;
            }
            return len;
        }

        //3.  separate individual characters from a string
        public static void separateChar(string str)
        {
            char[] c = new char[str.Length];
            int i = 0;
            for(i = 0; i < str.Length; i++)
            {
                c[i] = str[i];
            }
            displayCharArray(c);
            displayReverseCharArray(c);
        }
        public static void displayCharArray(char[] c)
        {
            int i;
            Console.WriteLine("\nThe characters of the string are:");
            for (i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }

        //4. print individual characters of a string in reverse order.
        public static void displayReverseCharArray(char[] c)
        {
            int i;
            Console.WriteLine("\nThe characters of the string in reversed order are:");
            for (i = c.Length - 1; i >= 0; i--)
            {
                Console.Write(c[i] + " ");
            }
        }

        //5. to count the total number of words in a string
        // also finding largest and smallest word in the string
        public static void totalWords(string str)
        {
            string word="";
            int count = 0;
            str += " ";//so that the last word can be added

            string largest=str, smallest=str;
            int countL = 0, countS= str.Length;

            Console.WriteLine("The words of the string are:");
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    if (word.Length < countS)
                    {
                        smallest = word;
                        countS = word.Length;
                    }
                    if (word.Length > countL)
                    {
                        largest = word;
                        countL = word.Length;
                    }
                    Console.WriteLine(word);
                    count++;
                    word = "";
                }
            }
            Console.WriteLine("\nThe total no of words in the string " + str + " are: " + count);
            Console.WriteLine("Largest word= {0}\nSmallest word= {1}",largest,smallest);
        }

        //6. changing uppercase to lowercase and lowercase to uppercase
        public static void changeCase(string str)
        {
            Console.WriteLine("\nChanging uppercase to lowercase and lowercase to uppercase");
            Console.WriteLine("Name= " + str);
            int val;
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                val = (int)str[i]; ;
                if (val >= 65 && val <= 90)
                {
                    newstr += (char)(val + 32);
                }
                else if (val >= 97 && val <= 122)
                {
                    newstr += (char)(val - 32);
                }
                else
                {
                    newstr += str[i];
                }
            }
            Console.WriteLine("New name= "+newstr);
        }

        //7. Convert to lowercase if word is in uppercase and replacing vowels with char following it
        public static void replaceVowels(string str)
        {
            string newstr = "";
            int val;
            for(int i=0;i<str.Length;i++)
            {
                char ch = str[i];
                val = (int)ch;
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    newstr += (char)(ch + 1);
                }
                else if(ch>=65 && ch <= 90)
                {
                    if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')//if the char is both uppercase and vowel
                        newstr += (char)(val + 32 + 1);//converting to lowercase and replacing with char following it
                    else
                        newstr += (char)(val + 32);
                }
                else
                {
                    newstr += ch;
                }              
            }
            Console.WriteLine("New word after replacing vowel by it's succeeding character and uppercase with lowercase: "+newstr);
        }
    
        //8. Convert string(can be a sentence) to capital and add 2 in each char
        public static void addTwoCapital(string str)
        {
            Console.WriteLine("\nConvert string(can be a sentence) to capital and add 2 in each char");
            Console.WriteLine(str+ " is the Input string");

            string newstr="";
            int val, toadd;
            for(int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                val= (int)ch;
                toadd = 0;
                if(!(ch >= 97 && ch <= 122 || ch >= 65 && ch <= 90))
                {
                    newstr += ch;
                }
                else
                {
                    if (ch >= 97 && ch <= 122)
                        val -= 32;
                    if (val + 2 > 90)
                    {
                        toadd = 64 + (2 - (90 - val));
                        newstr += (char)toadd;
                    }
                    else
                    {
                        newstr += (char)(val + 2);
                    }
                }
            }
            Console.WriteLine(newstr+" is the Modified string");
        }
   
        //9. Convert word in capital and arrange in A-Z order(sort)
        public static void capitalAlphabeticOrder(string str)
        {
            Console.WriteLine("\nConverting word in capital and then arranging in A-Z order");
            Console.WriteLine("Given word: " + str);

            //int val;
            string capitalstr = "", sortedstr="";
            for(int i=0;i< str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 97 && ch <= 122)
                    capitalstr += (char)(ch - 32);
                else
                    capitalstr += ch;
            }
            Console.WriteLine("Word in capital: " + capitalstr);

            for(int i = 65; i <= 90; i++)
            {
                int j = 0;
                while (j < capitalstr.Length)
                {
                    if (capitalstr[j] == (char)i)
                        sortedstr += (char)i;
                    j++;
                }
            }
            Console.WriteLine("Word after sorting: " + sortedstr);
        }

        //10. to compare two strings without using string library functions
        public static void compareStrings(string str1, string str2)
        {
            int flag = 0;
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("\nStrings are not equal");
            }
            else
            {
                for(int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                 Console.WriteLine("\nStrings "+str1+" and "+str2+" are equal");
            }
        }

        //11. to count the total number of alphabets, digits and special characters in a string
        public static void countAlphaDigitSpecChar(string str)
        {
            int countAlpha = 0, countDigit = 0, countSpecChar = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                    countAlpha++;
                else if (str[i] >= 48 && str[i] <= 57)
                    countDigit++;
                else
                    countSpecChar++;
            }
            Console.WriteLine("No of alphabets: " + countAlpha);
            Console.WriteLine("No of digits: " + countDigit);
            Console.WriteLine("No of special characters: " + countSpecChar);
        }

        //12. copy one string to another string
        public static void copyString(string str)
        {
            string copiedstr = "";
            int count = 0;

            for(int i = 0; i < str.Length; i++)
            {
                copiedstr += str[i];
                count++;
            }
            Console.WriteLine("The copied string is: " + copiedstr);
            Console.WriteLine("No of characters copied: " + count);
        }

        //13. count frequency of each character in a given string
        public static void freqEachChar(string str)
        {
            string newstr = "";
            char ch;
            int i, j, count;
            for(i = 0; i < str.Length; i++)
            {
                ch = str[i];
                count = 0;
                if (str.IndexOf(ch) == i)//going only for first occurrence
                {
                    for (j = i; j < str.Length; j++)//checking that first occurrence have any more occurrences or not for calc freq
                    {
                        if (newstr.IndexOf(ch) != -1)
                        {
                            if (ch == str[j])
                             count++;
                        }
                        else{
                            newstr += ch;
                            count = 1;//for first time it is not present in newstr so adding it and making it's freq 1
                        }
                    }
                    Console.WriteLine("Frequency of char " + ch + " is: " + count);
                }
            }
        }

        //14. to find the maximum number of characters in a string
        public static void findMaxChar(string str)
        {
            string newstr = "";
            char ch,maxchar=' ';
            int i, j, count,maxcount=0;
            for (i = 0; i < str.Length; i++)
            {
                ch = str[i];
                count = 0;
                if (str.IndexOf(ch) == i)//going only for first occurrence
                {
                    for (j = i; j < str.Length; j++)//checking that first occurrence have any more occurrences or not for calc freq
                    {
                        if (newstr.IndexOf(ch) != -1)
                        {
                            if (ch == str[j])
                                count++;
                        }
                        else
                        {
                            newstr += ch;
                            count = 1;//for first time it is not present in newstr so adding it and making it's freq 1
                        }
                    }
                    Console.WriteLine("Frequency of char " + ch + " is: " + count);
                    if (count > maxcount)
                    {
                        maxcount = count;
                        maxchar = ch;
                    }
                }
            }
            Console.WriteLine("Highest freq char is {0} and appears {1} number of times", maxchar, maxcount);
        }

        //15. sort a string array in ascending order
        public static void sortStringArray()
        {
            string temp;

            Console.WriteLine("Enter no of elts of string array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strarr = new string[n];
            Console.WriteLine("Enter string elements of array:");

            for(int i = 0; i < n; i++)
            {
                strarr[i] = Console.ReadLine();
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (strarr[j].CompareTo(strarr[j + 1]) > 0)//if first string greater than second string
                    {
                        temp=strarr[j];
                        strarr[j] = strarr[j + 1];
                        strarr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting the string array in ascending order: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(strarr[i]);
            }
        }

        //16. read a string from the keyboard and sort it using bubble sort
        public static void bubbleSortString(string str)
        {
            string sortedStr = "";

            //normal sort clever way but have to arrange all the elts in capital or lower.... here we have a capital string
            /*
            for (int i = 65; i <= 90; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {
                    if ((char)i == str[j])
                        sortedStr += (char)i;
                }
            }
            */

            //using bubble sort now no boundation of capital or lower cases here
            char t;

            //first converting string into character array
            int n = str.Length;
            char[] chArr = new char[n];
            for(int i = 0; i < n; i++)
            {
                chArr[i] = str[i];
            }

            //sorting the char array using bubble sort
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (chArr[j] > chArr[j + 1])
                    {
                        t = chArr[j];
                        chArr[j] = chArr[j + 1];
                        chArr[j + 1] = t;
                    }
                }
            }

            //converting char array into string
            for(int i = 0; i < n; i++)
            {
                sortedStr += chArr[i];
            }

            Console.WriteLine("After sorting {0} string, we get {1}", str, sortedStr);
        }

        //17. extract a substring from a given string
        public static void extractSubstring(string str)
        {
            string extractedSubstring="";

            Console.Write("Input the position to start extraction : ");
            int extractPos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the length of substring: ");
            int len = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < str.Length; i++)
            {
                if (i == extractPos - 1)
                {
                    int pos = i;
                    while (i < pos + len)
                    {
                        extractedSubstring += str[i];
                        i++;
                    }
                    break;
                }
            }
            Console.WriteLine("\nSubstring: "+str.Substring(extractPos-1,len));//using inbuilt method
            Console.WriteLine("\nThe substring extracted from '{0}' from position {1} is {2}", str, extractPos, extractedSubstring);
        }

        //18. check whether a substring is present in a string
        public static void checkString(string str)
        {
            Console.WriteLine("Enter the substring to be searched: ");
            string toCheckStr = Console.ReadLine();

            int i, j, counteri,flag=0,found=0;
            for(i = 0; i < str.Length; i++)
            {
                flag = 0;
                if (str[i] == toCheckStr[0])
                {
                    counteri = i;
                    j = 0;
                    while (j < toCheckStr.Length)
                    {
                        if (str[counteri]!= toCheckStr[j])
                        {
                            flag = 1;
                            break;
                        }
                        counteri++;
                        j++;
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("String '{0}' is found at position '{1}'", toCheckStr, (i+1));
                        found = 1;
                        break;
                    }
                }
            }
            if(found==0)
                Console.WriteLine("String '{0}' does not exists in the string '{1}'", toCheckStr, str);

            //using inbuilt method
            Console.WriteLine("\nUsing inbuilt methods: ");
            if (str.IndexOf(toCheckStr) == -1)
            {
                Console.WriteLine("Substring does not exists in the main string");
            }
            else
            {
                Console.WriteLine("Substring found at pos " + (str.IndexOf(toCheckStr) + 1));
            }
        }

        //19. find the number of times a given word entered by user appears in the given string
        public static void findNoOfTimesWord(string str)
        {
            Console.WriteLine("Enter the word whose appearance has to be checked:");
            string word = Console.ReadLine();
            Console.WriteLine("\n");

            int i, j, counteri,flag,found=0,count=0;
            for (i = 0; i < str.Length; i++)
            {
                flag = 0;
                if (str[i] == word[0])
                {
                    j = 0;
                    counteri = i;
                    while (j < word.Length)
                    {
                        if (str[counteri] != word[j])
                        {
                            flag = 1;
                            break;
                        }
                        counteri++;
                        j++;
                    }
                    if (flag == 0)
                    {
                        count++;
                        Console.WriteLine("Occurrence found at: "+(i+1));
                        found = 1;
                    }
                }
            }
            if (found == 0)
                Console.WriteLine("Word '{0}' has not appeared anywhere in the string '{1}'",word,str);
            else
                Console.WriteLine("The word has appeared " + count + " no of times");
        }

        //20. combine two strings
        public static void combineTwoStrings(string m, string p)
        {
            Console.WriteLine("\nCombining using .Concat func: "+ string.Concat(m,p));

            Console.WriteLine("Combining using '+' operator: "+ m + p);

            string combine = "";
            for (int i = 0; i < m.Length; i++)
                combine += m[i];
            for (int i = 0; i < p.Length; i++)
                combine += p[i];
            Console.WriteLine("Combining manually: "+ combine);
        }

        //21.  print only the string before the new line character
        public static void printOnlyBeforeNewLine(string str)
        {
            string t = "",newStr="";
            int flag = 0;

            for (int i = 0; i < str.Length-1; i++)
            {
                t+= str[i];
                t+= str[i + 1];
                Console.WriteLine(i + " " + t);
                if (t.Equals("\n"))//t == "\n"
                {
                    flag = i;
                    break;
                }
                else
                {
                    newStr += str[i];
                }
                t = "";
            }
            if (flag != str.Length - 1)
            {
                newStr += str[str.Length - 1];
            }
            Console.WriteLine("String before the new line character: " + newStr);
        }
    }
}
