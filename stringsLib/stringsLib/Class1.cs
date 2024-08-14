
namespace stringsLib
{
    public class Class1
    {
        //1. to input a string
        public string inputString()
        {
            Console.WriteLine("\nEnter a string");
            string str = Console.ReadLine();
            return str;
        }
        public void display(string str)
        {
            Console.WriteLine("The string you entered is: " + str);
        }

        //2. length of a string without using library function Length
        public int findLength(string str)
        {
            str += " ";
            int last = str.LastIndexOf(" ");
            int len = 0;
            while (len < last)
            {
                //Console.WriteLine(str[len]);
                len++;
            }
            return len;
        }

        //3.  separate individual characters from a string
        public void separateChar(string str)
        {
            char[] c = new char[str.Length];
            int i = 0;
            for (i = 0; i < str.Length; i++)
            {
                c[i] = str[i];
            }
            displayCharArray(c);
            displayReverseCharArray(c);
        }
        public void displayCharArray(char[] c)
        {
            int i;
            Console.WriteLine("\nThe characters of the string are:");
            for (i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }

        //4. print individual characters of a string in reverse order.
        public void displayReverseCharArray(char[] c)
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
        public void totalWords(string str)
        {
            string word = "";
            int count = 0;
            str += " ";//so that the last word can be added

            string largest = str, smallest = str;
            int countL = 0, countS = str.Length;

            Console.WriteLine("The words of the string are:");
            for (int i = 0; i < str.Length; i++)
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
            Console.WriteLine("Largest word= {0}\nSmallest word= {1}", largest, smallest);
        }

        //6. to count the total number of alphabets, digits and special characters in a string
        public void countAlphaDigitSpecChar(string str)
        {
            int countAlpha = 0, countDigit = 0, countSpecChar = 0;
            for (int i = 0; i < str.Length; i++)
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

        //7. copy one string to another string
        public void copyString(string str)
        {
            string copiedstr = "";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                copiedstr += str[i];
                count++;
            }
            Console.WriteLine("The copied string is: " + copiedstr);
            Console.WriteLine("No of characters copied: " + count);
        }

        //8. count frequency of each character in a given string
        public void freqEachChar(string str)
        {
            string newstr = "";
            char ch;
            int i, j, count;
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
                }
            }
        }

        //9. to find the maximum number of characters in a string
        public void findMaxChar(string str)
        {
            string newstr = "";
            char ch, maxchar = ' ';
            int i, j, count, maxcount = 0;
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

        //10. sort a string array in ascending order
        public void sortStringArray()
        {
            string temp;

            Console.WriteLine("Enter no of elts of string array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strarr = new string[n];
            Console.WriteLine("Enter string elements of array:");

            for (int i = 0; i < n; i++)
            {
                strarr[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (strarr[j].CompareTo(strarr[j + 1]) > 0)//if first string greater than second string
                    {
                        temp = strarr[j];
                        strarr[j] = strarr[j + 1];
                        strarr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting the string array in ascending order: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strarr[i]);
            }
        }

        //11. read a string from the keyboard and sort it using bubble sort
        public void bubbleSortString(string str)
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
            for (int i = 0; i < n; i++)
            {
                chArr[i] = str[i];
            }

            //sorting the char array using bubble sort
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
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
            for (int i = 0; i < n; i++)
            {
                sortedStr += chArr[i];
            }

            Console.WriteLine("After sorting {0} string, we get {1}", str, sortedStr);
        }
    }
}
