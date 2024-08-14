// See https://aka.ms/new-console-template for more information
using stringsLib;
using numbersLib;
class Program
{
    static void Main(string[] args)
    {
        Class1 obj = new Class1();
        ClassNumber numObj = new ClassNumber();

        //String programs
        Console.WriteLine("String Programs: ");
        Console.WriteLine(obj.inputString());
        Console.WriteLine(obj.findLength(obj.inputString()));
        obj.separateChar(obj.inputString());
        obj.totalWords(obj.inputString());
        obj.countAlphaDigitSpecChar(obj.inputString());
        obj.copyString(obj.inputString());
        obj.freqEachChar(obj.inputString());
        obj.findMaxChar(obj.inputString());
        obj.sortStringArray();
        obj.bubbleSortString(obj.inputString());

        //Number programs
        Console.WriteLine("Armstrong Number:");
        numObj.armstrong(inputNumber());

        Console.WriteLine("Right Angled triangle Pattern");
        numObj.righttri();

        Console.WriteLine("Even Odd Check:");
        Console.WriteLine(numObj.evenOdd(inputNumber()));

        Console.WriteLine("Palindrome Number:");
        Console.WriteLine(numObj.palindrome(inputNumber()));

        Console.WriteLine("Reverse Number:");
        Console.WriteLine("Reverse of the number: "+numObj.reverse(inputNumber()));

        Console.WriteLine("Factorial:");
        Console.WriteLine("Factorial of the number is: "+numObj.fact(inputNumber()));

        Console.WriteLine("Fibonaccii Series:");
        numObj.fibo(6);

        Console.WriteLine("\nPrime Number:");
        Console.WriteLine(numObj.prime(inputNumber()));

        Console.WriteLine("Buzz Number:");
        Console.WriteLine(numObj.buzz(inputNumber()));

        Console.WriteLine("Neon Number:");
        Console.WriteLine(numObj.neon(inputNumber()));
    }
    public static int inputNumber()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }
} 
