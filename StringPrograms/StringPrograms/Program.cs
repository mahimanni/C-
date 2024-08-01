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
            //totalWords(inputString());

            //changeCase(inputString());
            //replaceVowels(inputString());
            //addTwoCapital(inputString());
            capitalAlphabeticOrder(inputString());
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

        //5. to count the total number of words in a string.
        public static void totalWords(string str)
        {
            string word="";
            int count = 0;
            str += " ";//so that the last word can be added
            Console.WriteLine("The words of the string are:");
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    Console.WriteLine(word);
                    count++;
                    word = "";
                }
            }
            Console.WriteLine("\nThe total no of words in the string " + str + " are: " + count);
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
   
        //9. Convert word in capital and arrange in A-Z order
        public static void capitalAlphabeticOrder(string str)
        {
            Console.WriteLine("\nConverting word in capital and then arranging in A-Z order");
            Console.WriteLine("Given word: " + str);

            int val;
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
    }
}
